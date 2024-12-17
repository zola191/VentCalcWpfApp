using CommunityToolkit.Mvvm.ComponentModel;

namespace VentCalcWpfApp
{
    public partial class RowVent:ObservableObject
    {
        [ObservableProperty]
        private int sectionNumber;

        [ObservableProperty]
        private double airFlow;

        [ObservableProperty]
        private double length;

        [ObservableProperty]
        private AirDuct duct;

        public double CalculatedVelocity => duct != null ? Math.Round(airFlow / (3600 * duct.GetArea()), 2) : 0;

        public double ResistancePerMeter => duct != null ? Math.Round(0.02 * Math.Pow(CalculatedVelocity, 2) / duct.EquivalentDiameter, 2) : 0;

        [ObservableProperty]
        private double localResistanceCoefficient;

        [ObservableProperty]
        private double dynamicPressureLoss;

        [ObservableProperty]
        private double localResistanceLoss;

        public double TotalPressureLoss => dynamicPressureLoss + localResistanceLoss;
    }
}
