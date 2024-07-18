namespace AreaCalculatorService;

public class AreaCalculator
{
    public static double CalculateArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}
