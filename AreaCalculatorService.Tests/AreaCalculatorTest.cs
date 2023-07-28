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
            Assert.Equal(AreaCalculator.CalculateArea(circle), result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalculateAreaForCircleWithRadiusEqualToZeroOrLess(double radius)
        {
            void act()
            {
                var circle = new Circle(radius);
                AreaCalculator.CalculateArea(circle);
            }

            Assert.Throws<ArgumentException>(act);
        }

        [Theory]
        [InlineData(4, 6, 8, 11.61895003862225)]
        [InlineData(3, 4, 5, 6)]
        public void CalculateAreaForTriangle(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(result, AreaCalculator.CalculateArea(triangle));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CalculateAreaForTriangleWithSideEqualToZero(double side)
        {
            void act()
            {
                var triangle = new Triangle(side);
                AreaCalculator.CalculateArea(triangle);
            }

            Assert.Throws<ArgumentException>(act);
        }
    }
}