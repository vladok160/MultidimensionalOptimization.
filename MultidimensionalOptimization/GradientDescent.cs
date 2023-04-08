using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    public class GradientDescent : GeneralData, IMethod
    {
        double beta; // коэффициент дробления шага

        public GradientDescent(double epsilon) : base()
        {
            this.epsilon = epsilon;
            alpha = 1.0;
            beta = 0.5;
            Method();
        }
        public int GetCountOfIterations()
        {
            return count;
        }
        public double MethodForF() 
        {
            double AnswF = f(x1, x2);
            return AnswF;
        }
        public double MethodForX1()
        {
            return x1;
        }
        public double MethodForX2()
        {
            return x2;
        }
        public void Method()
        {
            double fx = f(x1, x2);
            double dfx1 = dfdx1(x1, x2);
            double dfx2 = dfdx2(x1, x2);

            while (Math.Max(Math.Abs(dfx1), Math.Abs(dfx2)) > epsilon)
            {
                double x1new = x1 - alpha * dfx1;
                double x2new = x2 - alpha * dfx2;
                double fxnew = f(x1new, x2new);

                while (fxnew > fx)
                {
                    alpha *= beta;
                    x1new = x1 - alpha * dfx1;
                    x2new = x2 - alpha * dfx2;
                    fxnew = f(x1new, x2new);
                }

                x1 = x1new;
                x2 = x2new;
                fx = fxnew;
                dfx1 = dfdx1(x1, x2);
                dfx2 = dfdx2(x1, x2);
                count++;
            }
        }
        double dfdx2(double x1, double x2)
        {
            return 10 * x2 + Math.Exp(x1 + x2);
        }
        double dfdx1(double x1, double x2)
        {
            return 2 * x1 + Math.Exp(x1 + x2);
        }
    }
}
