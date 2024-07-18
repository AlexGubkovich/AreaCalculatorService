using AreaCalculatorService.Shapes;

namespace AreaCalculatorService.Tests;

public class TriangleTest
{
    [Fact]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void NotRightTriangleTest()
    {
        var triangle = new Triangle(3, 3, 3);
        Assert.False(triangle.IsRightTriangle());
    }
}
