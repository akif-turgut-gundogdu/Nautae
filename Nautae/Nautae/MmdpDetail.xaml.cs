using Nautae.Models;
using Nautae.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nautae
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MmdpDetail : ContentPage
    {
        public MmdpDetail()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {

            BackgroundColor = Constants.BackgroudColor;

        }

        private async void SimulationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Simulation());
        }

        private async void PlatformButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Platform());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Egitim());
        }
    }
}