using AreaCalculatorService.Shapes;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TriangleBenckmark
    {
        [Benchmark(Description = "Rectangular_WithCheck")]
        public void Calculate_Rectangular_TriangeAreaWithCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            var result = triangle.CalculateAreaWithChechIsRectangular();
        }

        [Benchmark(Description = "NotRectangular_WithCheck")]
        public void Calculate_NotRectangularTriangeAreaWithCheck()
        {
            var triangle = new Triangle(3);
            var result = triangle.CalculateAreaWithChechIsRectangular();
        }

        [Benchmark(Description = "Rectangular_WithoutCheck")]
        public void Calculate_Rectangular_TriangeAreaWithoutCheck()
        {
            var triangle = new Triangle(3, 4, 5);
            var result = triangle.CalculateArea();
        }

        [Benchmark(Description = "NotRectangular_WithoutCheck")]
        public void Calculate_NotRectangularTriangeAreaWithoutCheck()
        {
            var triangle = new Triangle(3);
            var result = triangle.CalculateArea();
        }
    }
}
