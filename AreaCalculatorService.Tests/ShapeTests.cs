namespace AreaCalculatorService.Tests;

public class ShapeTests
{
    [Theory]
    [InlineData(5, Math.PI * 25)]
    [InlineData(10, Math.PI * 100)]
    public void CircleAreaTest(double radius, double expectedArea)
    {
        IShape circle = ShapeFactory.CreateCircle(radius);
        double area = circle.CalculateArea();
        Assert.Equal(expectedArea, area, 10);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(6, 8, 10, 24)]
    public void TriangleAreaTest(double sideA, double sideB, double sideC, double expectedArea)
    {
        IShape triangle = ShapeFactory.CreateTriangle(sideA, sideB, sideC);
        double area = triangle.CalculateArea();
        Assert.Equal(expectedArea, area, 10);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void CircleInvalidRadiusTest(double radius)
    {
        Assert.Throws<ArgumentException>(() => ShapeFactory.CreateCircle(radius));
    }

    [Theory]
    [InlineData(-1, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, -1)]
    [InlineData(0, 1, 1)]
    [InlineData(1, 0, 1)]
    [InlineData(1, 1, 0)]
    public void TriangleInvalidSidesTest(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => ShapeFactory.CreateTriangle(sideA, sideB, sideC));
    }
}