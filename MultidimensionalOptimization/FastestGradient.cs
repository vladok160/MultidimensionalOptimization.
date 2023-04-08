using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    internal class FastestGradient : GeneralData, IMethod
    {
        double[] gradient;
        double[] prevX;
        double currentValue;
        double prevValue;
        public FastestGradient(double epsilon) : base()
        {
            this.epsilon = epsilon;
            alpha = 0.1;
            gradient = new double[2]; // градиент функции
            prevX = new double[2]; // предыдущее значение x
            prevValue = double.MaxValue; // предыдущее значение функции
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
            return currentValue; 
        }
        public void Method()
        {
            while (true)
            {
                currentValue = f(x); // значение функции в текущей точке
                if (Math.Abs(currentValue - prevValue) < epsilon)
                {
                    break; // достигнута требуемая точность
                }

                gradient[0] = PartialDerivative(x, 0); // вычисляем частную производную по x1
                gradient[1] = PartialDerivative(x, 1); // вычисляем частную производную по x2

                prevX[0] = x[0];
                prevX[1] = x[1];

                x[0] -= alpha * gradient[0]; // обновляем значение x1
                x[1] -= alpha * gradient[1]; // обновляем значение x2

                prevValue = currentValue;
            }
        }
        double PartialDerivative(double[] x, int index)
        {
            double delta = 0.0001; // шаг для вычисления производной
            double[] newX = new double[] { x[0], x[1] };
            newX[index] += delta;

            double derivative = (f(newX) - f(x)) / delta;
            return derivative;
        }
    }
}
