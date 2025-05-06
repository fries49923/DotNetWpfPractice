using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Diagnostics;

namespace WpfDictionaryBindingTest
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        protected Dictionary<string, BaseMethod> _methods;

        public MainViewModel()
        {
            _methods = new Dictionary<string, BaseMethod>
            {
                { typeof(Add).Name, new Add() },
                { typeof(Sub).Name, new Sub() },
                { typeof(Mul).Name, new Mul() }
            };
        }

        [RelayCommand]
        public void SelectChange(object obj)
        {
            try
            {
                var key = "";
                BaseMethod? method = null;
                switch (obj)
                {
                    case KeyValuePair<string, BaseMethod> kvp:
                        key = kvp.Key;
                        method = kvp.Value;
                        break;

                    case string str:
                        if (string.IsNullOrEmpty(str) is true)
                            return;

                        key = str;

                        if (Methods.TryGetValue(key, out BaseMethod? value) is false)
                            return;

                        method = value;

                        break;

                    default:
                        Debug.WriteLine("Not a matching type.");
                        return;
                }

                int tmp = method.Execute(1, 2);
                Debug.WriteLine($"{key}: {tmp}");
            }
            catch (Exception)
            { }
        }
    }
}
