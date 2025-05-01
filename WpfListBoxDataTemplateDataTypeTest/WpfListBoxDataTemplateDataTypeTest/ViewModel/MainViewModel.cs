using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using WpfListBoxDataTemplateDataTypeTest.Model;

namespace WpfListBoxDataTemplateDataTypeTest.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<VehicleBase> Vehicles
        { get; protected set; }

        public MainViewModel()
        {
            Vehicles = [];
        }

        [RelayCommand]
        protected void WindowLoad()
        {
            Vehicles.Add(
                new Car
                {
                    Name = "SportCar X1",
                    Horsepower = 320,
                    Weight = 1350.5
                });

            Vehicles.Add(
                new Boat
                {
                    Name = "SeaRider 200",
                    EnginePower = 500,
                    Length = 12.3
                });

            Vehicles.Add(
                new Boat
                {
                    Name = "WaveSurfer",
                    EnginePower = 320,
                    Length = 9.7
                });

            Vehicles.Add(
                new Airplane
                {
                    Name = "SkyJet A5",
                    Thrust = 180.0,
                    Wingspan = 27.8,
                    EngineCount = 2
                });

            Vehicles.Add(
                new Car
                {
                    Name = "EcoCar Z",
                    Horsepower = 110,
                    Weight = 980.0
                });
        }
    }
}
