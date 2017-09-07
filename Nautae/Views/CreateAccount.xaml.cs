using Nautae.Models;
using Nautae.CloudData;
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
	public partial class CreateAccount : ContentPage
	{
        Connection cnn;
        public CreateAccount()
        {
            InitializeComponent();
            ActivitySpinner.IsVisible = false;
            cnn = new Connection();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Models.users user = new Models.users(usernameEntry.Text, userpasswordEntry.Text);
            var result = cnn.userAll().ToList();

            //usernameEntry.Text = result;

            DisplayAlert("Login", "Success", "Okey");
        }
    }
}