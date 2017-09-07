using Nautae.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nautae
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MmdpMaster : ContentPage
    {
        public ListView ListView;

        public MmdpMaster()
        {
            InitializeComponent();
            Init();
            BindingContext = new MmdpMasterViewModel();
            ListView = MenuItemsListView;

        }

        void Init()
        {

            BackgroundColor = Constants.BackgroudColor;

        }
        class MmdpMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MmdpMenuItem> MenuItems { get; set; }

            public MmdpMasterViewModel()
            {
                MenuItems = new ObservableCollection<MmdpMenuItem>(new[]
                {

                    new MmdpMenuItem { Id = 0, Title = "Duyurular" },
                    new MmdpMenuItem { Id = 1, Title = "İrtibatlar" },
                    new MmdpMenuItem { Id = 2, Title = "Yardım" },
                    new MmdpMenuItem { Id = 3, Title = "Hesap Ayarları" },
                    new MmdpMenuItem { Id = 4, Title = "Hesaptan Çık" }
                });

            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }

    }
}