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
    public partial class Platform : ContentPage
    {
        public static string Text { get; set; }
        public Platform()
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

            await Navigation.PushAsync(new PlatformQuestions());
        }

        private void Button_Kokpit(object sender, EventArgs e)
        {

        }

        private void Button_Cenova(object sender, EventArgs e)
        {

        }

        private void Button_Basustu(object sender, EventArgs e)
        {

        }

        private void Button_Kopruustu(object sender, EventArgs e)
        {

        }

        private void Button_Piano(object sender, EventArgs e)
        {

        }
        private void Button_AnaYelken(object sender, EventArgs e)
        {

        }
        private void Button_Serdumen(object sender, EventArgs e)
        {

        }
    }
}