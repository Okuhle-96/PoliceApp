using Xamarin.Forms;

namespace PoliceAppp.Views
{
    public partial class Signup : ContentPage
    {
        public Signup()
        {
            InitializeComponent();
        }

        private async void OffToLogin_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
 }

