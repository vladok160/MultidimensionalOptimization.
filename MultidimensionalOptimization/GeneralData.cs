using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    public class GeneralData
    {
        protected double x1, x2, epsilon;
        protected double alpha; // начальный шаг
        protected double[] x;
        protected int count;
        public GeneralData()
        {
            //эт все крч начальные значения x (берется из вашего варика)
            x1 = -3.0;
            x2 = -3.0;
            x = new double[] { -3, -3 };
            count = 0;
        }
        //для методов без массива
        protected double f(double x1, double x2)
        {
            return x1 * x1 + 5 * x2 * x2 + Math.Exp(x1 + x2);
        }
        // которые принимеют в себя массив чурок богдана
        protected double f(double[] x)
        {
            return Math.Pow(x[0], 2) + 5 * Math.Pow(x[1], 2) + Math.Exp(x[0] + x[1]);
        }
    }
}
