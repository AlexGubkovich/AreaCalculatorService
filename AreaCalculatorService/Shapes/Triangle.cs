namespace AreaCalculatorService.Shapes;

public class Triangle : IShape
{
    private readonly double SideA;
    private readonly double SideB;
    private readonly double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Sides can't be zero or less");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public Triangle(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Side can't be zero or less");

        SideA = SideB = SideC = side;
    }

    public double CalculateArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRightTriangle()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);

        var a = sides[0];
        var b = sides[1];
        var c = sides[2];

        return Math.Abs((a * a + b * b) - c * c) < 1e-10;
    }
}
