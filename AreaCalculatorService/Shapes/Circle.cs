namespace AreaCalculatorService.Shapes;

public class Circle : IShape
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius can't be zero or less");

        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}
