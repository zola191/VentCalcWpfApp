namespace VentCalcWpfApp
{
    public class RowVentilationData
    {
        public int SectionNumber { get; set; }
        public double AirFlow { get; set; }
        public double Length { get; set; }
        public AirDuct Duct { get; set; }

        public double Velocity => Duct != null ? Math.Round(AirFlow / (3600 * Duct.GetArea()), 2) : 0;
        public double ResistancePerMeter => Math.Round(0.02 * Math.Pow(Velocity, 2) / Duct.EquivalentDiameter, 2);
        public double LocalResistanceCoefficient { get; set; }
        public double DynamicPressureLoss { get; set; }
        public double LocalResistanceLoss { get; set; }
        public double TotalPressureLoss => DynamicPressureLoss + LocalResistanceLoss;

    }
}
