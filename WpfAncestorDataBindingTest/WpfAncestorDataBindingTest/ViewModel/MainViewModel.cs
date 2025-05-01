using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WpfAncestorDataBindingTest.Model;

namespace WpfAncestorDataBindingTest.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        protected bool _isShowDetail;

        public ObservableCollection<PersonData> Persons
        { get; set; }

        public MainViewModel()
        {
            _isShowDetail = false;

            Persons =
            [
                new ()
                {
                    Name = "Wang Wu",
                    Phone = "0923456789",
                    Email = "wangwu@example.com",
                    Address = "Banqiao District, New Taipei City, Taiwan"
                },

                new ()
                {
                    Name = "Zhang San",
                    Phone = "0912345678",
                    Email = "zhangsan@example.com",
                    Address = "Xinyi District, Taipei City, Taiwan"
                },

                new ()
                {
                    Name = "John Doe",
                    Phone = "+1-202-555-0172",
                    Email = "johndoe@example.com",
                    Address = "1234 Elm Street, Anytown, USA"
                },

                new ()
                {
                    Name = "Jane Smith",
                    Phone = "+1-202-555-0191",
                    Email = "janesmith@example.com",
                    Address = "5678 Oak Street, Anytown, USA"
                },

                new ()
                {
                    Name = "Li Si",
                    Phone = "0987654321",
                    Email = "lisi@example.com",
                    Address = "Sanmin District, Kaohsiung City, Taiwan"
                },
            ];
        }
    }
}
