using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorService.Shapes
{
    public class Circle : IAreaCalсulate
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
