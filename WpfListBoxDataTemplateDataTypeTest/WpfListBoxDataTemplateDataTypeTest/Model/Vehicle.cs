using CommunityToolkit.Mvvm.ComponentModel;

namespace WpfListBoxDataTemplateDataTypeTest.Model
{
    public abstract partial class VehicleBase : ObservableObject
    {
        [ObservableProperty]
        protected string _name = "";
    }

    public partial class Car : VehicleBase
    {
        [ObservableProperty]
        protected int _horsepower;

        [ObservableProperty]
        protected double _weight;
    }

    public partial class Boat : VehicleBase
    {
        [ObservableProperty]
        protected int _enginePower;

        [ObservableProperty]
        protected double _length;
    }

    public partial class Airplane : VehicleBase
    {
        [ObservableProperty]
        protected double _thrust;

        [ObservableProperty]
        protected double _wingspan;

        [ObservableProperty]
        protected int _engineCount;
    }
}
