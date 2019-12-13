using System;
using Xamarin.Forms;

namespace PoliceAppp.Views
{
    public partial class ReportMissingPersons : ContentPage
    {
        public ReportMissingPersons()
        {
            InitializeComponent();
        }

        public object Browser { get; private set; }

        private async void MoreMissing_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Report());
        }

        private async void Report_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Report());
        }
    }
}
