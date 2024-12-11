namespace VentCalcWpfApp
{
    public class RectangularDuct : AirDuct
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double EquivalentDiameter => Math.Round((2 * (Width * Height)) / (Width + Height), 2);

        public RectangularDuct(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return (Width/1000d) * (Height/1000d) ;
        }
    }
}
