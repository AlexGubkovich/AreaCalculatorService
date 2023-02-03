namespace AreaCalculatorService.Shapes
{
    public class Square : IAreaCalсulate
    {
        private double side;

        public Square(double side)
        {
            this.side = side;
        }

        public double CalculateArea()
        {
            return side * side;
        }
    }
}