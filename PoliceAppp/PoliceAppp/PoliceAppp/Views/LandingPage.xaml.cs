using Xamarin.Forms;

namespace PoliceAppp.Views
{
    public partial class LandingPage : ContentPage
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private async void Tip_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new TipOff());
        }

        private async void ChatPage_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Chat());
        }

        private async void Miss_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ReportMissingPersons());
        }

        private async void Case_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Case());
        }

        private async void Clearance_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Clearance());
        }

        private async void Police_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PoliceStation());
        }

        private async void Car_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Car());
        }

        private async void Danger_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Car());
        }

        private async void Call_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Call());
        }
    }
}
