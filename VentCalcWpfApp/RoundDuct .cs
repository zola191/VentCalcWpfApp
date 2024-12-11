namespace VentCalcWpfApp
{
    public class RoundDuct : AirDuct
    {
        public double Diameter { get; set; }

        public RoundDuct(double diameter)
        {
            Diameter = diameter;
        }

        public double Radius => Diameter / 2;

        public override double EquivalentDiameter => Diameter;

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
