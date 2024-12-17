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

        public double? Radius
        {
            get => (duct as RoundDuct)?.Radius;
            set
            {
                if (value.HasValue)
                {
                    if (duct is RectangularDuct rectangularDuct)
                    {
                        rectangularDuct.Width = 0;
                        rectangularDuct.Height = 0;
                    }
                }
                if (duct is RoundDuct roundDuct)
                {
                    roundDuct.Diameter = value.Value * 2;
                }
                OnPropertyChanged();
            }
        }

        public double? Width
        {
            get => (duct as RectangularDuct)?.Width;
            set
            {
                if (value.HasValue)
                {
                    if (duct is RoundDuct roundDuct)
                    {
                        roundDuct.Diameter = 0;
                    }
                }
                if (duct is RectangularDuct rectangularDuct)
                {
                    rectangularDuct.Width = value ?? 0;
                }
                OnPropertyChanged();
            }
        }

        public double? Height
        {
            get => (duct as RectangularDuct)?.Height;
            set
            {
                if (value.HasValue)
                {
                    if (duct is RoundDuct roundDuct)
                    {
                        roundDuct.Diameter = 0;
                    }
                }
                if (duct is RectangularDuct rectangularDuct)
                {
                    rectangularDuct.Height = value ?? 0;
                }
                OnPropertyChanged();
            }
        }
    }
}
