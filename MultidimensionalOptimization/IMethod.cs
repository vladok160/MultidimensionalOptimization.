using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalOptimization_
{
    public interface IMethod
    {
        public double MethodForX1();
        public double MethodForX2();
        public double MethodForF();
        public int GetCountOfIterations();
    }
}
