using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    internal class FletcherReevesMethod : GeneralData, IMethod
    {
        int maxIterations;
        int iterations;
        double[] d;
        double[] gradF;
        public FletcherReevesMethod(double epsilon) : base()
        {
            this.epsilon = epsilon;
            maxIterations = 1000;
            iterations = 0;
            gradF = gradient(x);
            d = neg(gradF);
            alpha = getAlpha(x, d);
            Method();
        }
        public double MethodForX1()
        {
            return x[0];
        }
        public double MethodForX2()
        {
            return x[1];
        }
        public double MethodForF()
        {
            return f(x);
        }
        public void Method()
        {
            while (norm(gradF) > epsilon && iterations < maxIterations)
            {
                x = add(x, scalarMult(alpha, d));
                double[] gradFNew = gradient(x);
                double beta = Math.Pow(norm(gradFNew), 2) / Math.Pow(norm(gradF), 2);
                d = add(neg(gradFNew), scalarMult(beta, d));
                gradF = gradFNew;
                alpha = getAlpha(x, d);
                iterations++;
            }
        }
        double[] gradient(double[] x)
        {
            double[] grad = new double[2];
            grad[0] = 2 * x[0] + Math.Exp(x[0] + x[1]);
            grad[1] = 10 * x[1] + Math.Exp(x[0] + x[1]);
            return grad;
        }
        double[] add(double[] a, double[] b)
        {
            double[] result = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                result[i] = a[i] + b[i];
            }
            return result;
        }
        double[] scalarMult(double a, double[] x)
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = a * x[i];
            }
            return result;
        }
        double[] neg(double[] x)
        {
            double[] result = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                result[i] = -x[i];
            }
            return result;
        }
        double norm(double[] x)
        {
            double sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += Math.Pow(x[i], 2);
            }
            return Math.Sqrt(sum);
        }
        double getAlpha(double[] x, double[] d)
        {
            double a = 0;
            double b = 1;
            double alpha = (a + b) / 2;
            while (Math.Abs(b - a) > 0.0001)
            {
                alpha = (a + b) / 2;
                double f1 = f(add(x, scalarMult(alpha, d)));
                double f2 = f(add(x, scalarMult((alpha + 0.0001), d)));
                if (f1 <= f2)
                {
                    b = alpha;
                }
                else
                {
                    a = alpha;
                }
            }
            return alpha;
        }
    }
}
