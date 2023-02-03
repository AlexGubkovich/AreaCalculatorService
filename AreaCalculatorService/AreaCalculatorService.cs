using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorService
{
    public static class AreaCalculatorService<T> where T : IAreaCalсulate
    {
        public static double CalculateArea(T shape)
        {
            return shape.CalculateArea();
        }
    }
}
