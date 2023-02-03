using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorService
{
    public static class AreaCalculatorService
    {
        public static double CalculateArea(IAreaCalсulate shape)
        {
            return shape.CalculateArea();
        }
    }
}
