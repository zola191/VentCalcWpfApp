using System.Collections.ObjectModel;

namespace VentCalcWpfApp
{
    public class CalculationViewModel
    {
        private readonly ObservableCollection<RowVentilationData> _ventilationDataRows;
        public ObservableCollection<RowVent> VentilationDataRows { get; set; }

        public CalculationViewModel()
        {
            VentilationDataRows = new ObservableCollection<RowVent>
            {
                new RowVent {SectionNumber = 1,AirFlow=500,Length=5},
                new RowVent {SectionNumber = 2, AirFlow=700,Length=10 },
            };
        }

        public void AddRow()
        {
            _ventilationDataRows.Add(new RowVentilationData { AirFlow = 700, Length = 20, SectionNumber = 4 });
        }
    }
}
