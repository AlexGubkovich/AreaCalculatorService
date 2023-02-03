using AreaCalculatorService.Shapes;

namespace AreaCalculatorService.Tests
{
    public class AreaCalculatorTest
    {
        [Theory]
        [InlineData(2, Math.PI * 4)]
        [InlineData(3, Math.PI * 9)]
        public void CalculateAreaForCircle(double radius, double result)
        {
            var circle = new Circle(radius);
            Assert.Equal(AreaCalculatorService.CalculateArea(circle), result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalculateAreaForCircleWithRadiusEqualToZeroOrLess(double radius)
        {
            Action act = () =>
            {
                var circle = new Circle(radius);
                AreaCalculatorService.CalculateArea(circle);
            };
            
            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [InlineData(4, 6, 8, 11.61895003862225)]
        [InlineData(3, 4, 5, 6)]
        public void CalculateAreaForTriangle(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(result, AreaCalculatorService.CalculateArea(triangle));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalculateAreaForTriangleWithSideEqualToZero(double side)
        {
            Action act = () =>
            {
                var triangle = new Triangle(side);
                AreaCalculatorService.CalculateArea(triangle);
            };

            Assert.Throws<ArgumentException>(act);
        }
    }
}