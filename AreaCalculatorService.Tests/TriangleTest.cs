using AreaCalculatorService.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorService.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void IsTriangleRactangularWhenItIs()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsTriangleRactangularWhenItIsNot()
        {
            var triangle = new Triangle(3, 3, 3);
            Assert.False(triangle.IsRectangular());
        }
    }
}
