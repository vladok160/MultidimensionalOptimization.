using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    internal class ModifiedNewtonsMethod : GeneralData, IMethod
    {
        public ModifiedNewtonsMethod(double epsilon) : base()
        {
            this.epsilon = epsilon;
            Method();
        }
        public int GetCountOfIterations()
        {
            return count;
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
            while (true)
            {
                double[,] H = Hessian(x); // вычисляем гессиан
                double[] grad = Gradient(x); // вычисляем градиент
                double[] dx = SolveSystem(H, grad); // решаем систему линейных уравнений
                double norm = Norm(dx); // вычисляем норму вектора приращения

                if (norm < epsilon) // достигнута требуемая точность
                {
                    break;
                }
                // обновляем значение x
                x[0] -= dx[0];
                x[1] -= dx[1];
                count++;
            }
        }
        // вычисляет градиент функции в точке x
        double[] Gradient(double[] x)
        {
            double[] grad = new double[2];
            grad[0] = 2 * x[0] + Math.Exp(x[0] + x[1]);
            grad[1] = 10 * x[1] + Math.Exp(x[0] + x[1]);
            return grad;
        }
        // вычисляет гессиан функции в точке x
        double[,] Hessian(double[] x)
        {
            double[,] H = new double[2, 2];
            H[0, 0] = 2 + Math.Exp(x[0] + x[1]);
            H[0, 1] = H[1, 0] = Math.Exp(x[0] + x[1]);
            H[1, 1] = 10 + Math.Exp(x[0] + x[1]);
            return H;
        }
        // решает систему линейных уравнений Ax = b
        double[] SolveSystem(double[,] A, double[] b)
        {
            double det = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            double[] dx = new double[2];
            dx[0] = (b[0] * A[1, 1] - b[1] * A[0, 1]) / det;
            dx[1] = (b[1] * A[0, 0] - b[0] * A[1, 0]) / det;
            return dx;
        }
        // вычисляет норму вектора
        double Norm(double[] x)
        {
            return Math.Sqrt(x[0] * x[0] + x[1] * x[1] * x[1]);
        }
    }
}
