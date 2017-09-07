using Nautae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nautae.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformQuestions : ContentPage
    {
        public PlatformQuestions()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {

            BackgroundColor = Constants.BackgroudColor;



        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            await Navigation.PopAsync();

        }
    }
}