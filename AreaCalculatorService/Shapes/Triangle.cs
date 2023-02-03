using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorService.Shapes
{
    public class Triangle : IAreaCalсulate
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public Triangle(double side)
        {
            sideA = sideB = sideC = side;
        }

        public bool IsRectangular()
        {
            if ((sideA * sideA + sideB * sideB == sideC * sideC) 
                || (sideA * sideA + sideC * sideC == sideB * sideB)
                || (sideB * sideB + sideC * sideC == sideA * sideA))
                return true;
            else return false;
        }

        public double CalculateArea()
        {
            var p = (sideA + sideB + sideC) / 2;
            var S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));

            return S;
        }

        public double CalculateAreaWithChechIsRectangular()
        {
            if (IsRectangular())
            {
                return sideA * sideB / 2;
            }
            else
            {
                var p = (sideA + sideB + sideC) / 2;
                var S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                return S;
            }
        }
    }
}
