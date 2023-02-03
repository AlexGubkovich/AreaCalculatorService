using AreaCalculatorService.Shapes;
using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TriangleBenckmark
    {
        private readonly Triangle rectangularTriangle = new Triangle(3, 4, 5);
        private readonly Triangle notRectangularTriangle = new Triangle(3, 3, 3);

        //[Benchmark(Description = "Rectangular_WithCheck")]
        //public void Calculate_Rectangular_TriangeAreaWithCheck()
        //{
        //    var result = rectangularTriangle.CalculateAreaWithChechIsRectangular();
        //}

        //[Benchmark(Description = "NotRectangular_WithCheck")]
        //public void Calculate_NotRectangularTriangeAreaWithCheck()
        //{
        //    var result = notRectangularTriangle.CalculateAreaWithChechIsRectangular();
        //}

        [Benchmark(Description = "Rectangular_WithoutCheck")]
        public void Calculate_Rectangular_TriangeAreaWithoutCheck()
        {
            var result = rectangularTriangle.CalculateArea();
        }

        [Benchmark(Description = "NotRectangular_WithoutCheck")]
        public void Calculate_NotRectangularTriangeAreaWithoutCheck()
        {
            var result = notRectangularTriangle.CalculateArea();
        }
    }
}
