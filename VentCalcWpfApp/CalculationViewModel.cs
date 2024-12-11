using System.Collections.ObjectModel;

namespace VentCalcWpfApp
{
    public class CalculationViewModel
    {
        public ObservableCollection<RowVentilationData> VentilationDataRows { get; set; }

        public CalculationViewModel()
        {
            VentilationDataRows = new ObservableCollection<RowVentilationData>
            {
            new RowVentilationData { SectionNumber = 1, AirFlow = 500, Length = 20, Duct = new RoundDuct(100) },
            new RowVentilationData { SectionNumber = 2, AirFlow = 600, Length = 25, Duct = new RectangularDuct(500, 1000) }
            };
        }
    }
}
