using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PoliceAppp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Signing_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Signup());
        }

        private async void MyPolice_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LandingPage());
        }
    }
}