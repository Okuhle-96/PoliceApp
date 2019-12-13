using Xamarin.Forms;

namespace PoliceAppp.Views
{
    public partial class TipOff : ContentPage
    {
        public TipOff()
        {
            InitializeComponent();
        }

        private async void Verify_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Case());
        }

        private async void Home_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LandingPage());
        }
    }
}
