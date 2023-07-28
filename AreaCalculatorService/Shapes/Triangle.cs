namespace AreaCalculatorService.Shapes
{
    public class Triangle : IAreaCalсulable
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Side can't be zero or less");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public Triangle(double side)
        {
            if (side <= 0)
                throw new ArgumentException("Side can't be zero or less");

            sideA = sideB = sideC = side;
        }

        public bool IsRectangular()
        {
            return Math.Abs(sideA * sideA + sideB * sideB - sideC * sideC) < 1e-10
                   || Math.Abs(sideA * sideA + sideC * sideC - sideB * sideB) < 1e-10
                   || Math.Abs(sideB * sideB + sideC * sideC - sideA * sideA) < 1e-10;
        }

        public double CalculateArea()
        {
            var p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
    }
}
