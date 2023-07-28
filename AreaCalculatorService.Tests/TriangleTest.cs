using AreaCalculatorService.Shapes;

namespace AreaCalculatorService.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void IsTriangleRectangularWhenItIs()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRectangular());
        }

        [Fact]
        public void IsTriangleRectangularWhenItIsNot()
        {
            var triangle = new Triangle(3, 3, 3);
            Assert.False(triangle.IsRectangular());
        }
    }
}
