using Nautae.Models;
using Nautae.Views;
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
	public partial class loginPage : ContentPage
	{
		public loginPage ()
		{
			InitializeComponent ();
            Init();
		}
        void Init()
        {

            BackgroundColor = Constants.BackgroudColor;
            ActivitySpinner.IsVisible = false;

        }
        private async void signInButton(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new Mmdp());


            //if (user.CheckInformation())
            //{
            //    DisplayAlert("Login", "Login Success", "Oke");

            //}
            //else {

            //    DisplayAlert("Login", "Please Type a Username and a Password", "Oke");
            //}
        }
        private async void signUpButton(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CreateAccount());


            //if (user.CheckInformation())
            //{
            //    DisplayAlert("Login", "Login Success", "Oke");

            //}
            //else {

            //    DisplayAlert("Login", "Please Type a Username and a Password", "Oke");
            //}
        }
    }
}