namespace AreaCalculatorService
{
    public class AreaCalculator
    {
        public static double CalculateArea(IAreaCalсulable shape)
        {
            return shape.CalculateArea();
        }
    }
}
