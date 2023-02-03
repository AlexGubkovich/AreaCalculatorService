using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Side can't be zero or less");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public Triangle(double side)
        {
            if (side <= 0)
                throw new ArgumentException("Side can't be zero or less");

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

        //it's slower
        //Rectangular_WithCheck | 6.342 ns | 
        //NotRectangular_WithCheck | 9.878 ns | 
        //Rectangular_WithoutCheck | 6.813 ns |
        //NotRectangular_WithoutCheck | 7.053 ns |
        //public double CalculateAreaWithChechIsRectangular()
        //{
        //    if (IsRectangular())
        //    {
        //        return sideA * sideB / 2;
        //    }
        //    else
        //    {
        //        var p = (sideA + sideB + sideC) / 2;
        //        var S = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        //        return S;
        //    }
        //}
    }
}
