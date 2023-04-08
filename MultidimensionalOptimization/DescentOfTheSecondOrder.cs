using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    internal class DescentOfTheSecondOrder : GeneralData, IMethod
    {
        Func<double[], double[]> grad;
        double[] d;
        double[] x_new;
        public DescentOfTheSecondOrder(double epsilon) : base()
        {
            this.epsilon = epsilon;
            //Градиент
            grad = x => new double[] { 2 * x[0] + Math.Exp(x[0] + x[1]), 10 * x[1] + Math.Exp(x[0] + x[1]) };
            //тут начальная точка находится в первородном классе GeneralData, в принципе, как и все остальные
            //для начала алгоритма
            d = new double[] { 0, 0 };
            Method();
        }
        public double MethodForX1()
        {
            return x_new[0];
        }
        public double MethodForX2()
        {
            return x_new[1];
        }
        public double MethodForF()
        {
            return f(x_new);
        }
        public void Method() 
        {
            while (true)
            {
                // Compute the gradient and Hessian
                double[] g = grad(x);
                double[,] H = new double[,] { { 2 + Math.Exp(x[0] + x[1]), Math.Exp(x[0] + x[1]) }, { Math.Exp(x[0] + x[1]), 10 + Math.Exp(x[0] + x[1]) } };

                // Compute the descent direction
                double[,] H_inv = Inverse(H);
                for (int i = 0; i < 2; i++)
                {
                    d[i] = 0;
                    for (int j = 0; j < 2; j++)
                    {
                        d[i] -= H_inv[i, j] * g[j];
                    }
                }

                // Compute the step size
                double alpha = 1.0;
                x_new = new double[2];
                while (true)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        x_new[i] = x[i] + alpha * d[i];
                    }
                    if (f(x_new) < f(x) + 0.5 * alpha * DotProduct(g, d))
                    {
                        break;
                    }
                    alpha *= 0.5;
                }
                // Check for convergence
                double norm = Math.Sqrt(Math.Pow(d[0], 2) + Math.Pow(d[1], 2));
                if (norm < epsilon)
                {
                    //Console.WriteLine("Converged to x = [{0}, {1}] with f(x) = {2}", x_new[0], x_new[1], f(x_new));
                    break;
                }

                // Update the point
                x = x_new;
            }
        }
        double[,] Inverse(double[,] a) //штука для нахождения обратной матрицы
        {
            int n = a.GetLength(0);
            double[,] b = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                b[i, i] = 1;
            }
            for (int k = 0; k < n; k++)
            {
                for (int j = k; j < n; j++)
                {
                    double sum = 0;
                    for (int p = 0; p < k; p++)
                    {
                        sum += a[k, p] * b[p, j];
                    }
                    b[k, j] = (a[k, j] - sum) / a[k, k];
                }
            }
            for (int k = n - 1; k >= 0; k--)
            {
                for (int j = k; j >= 0; j--)
                {
                    double sum = 0;
                    for (int p = k + 1; p < n; p++)
                    {
                        sum += a[k, p] * b[p, j];
                    }
                    b[k, j] -= sum;
                    b[k, j] /= a[k, k];
                }
            }
            return b;
        }
        double DotProduct(double[] a, double[] b) // хрень для вычисления скалярного произведения двух векторов
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i] * b[i];
            }
            return sum;
        }
    }
}
