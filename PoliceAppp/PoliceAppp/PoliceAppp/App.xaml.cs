using Prism;
using Prism.Ioc;
using PoliceAppp.ViewModels;
using PoliceAppp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PoliceAppp.Security;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PoliceAppp
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();


            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ISecurityService,FakeSecurityService> ();


            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<Call, CallViewModel>();
            containerRegistry.RegisterForNavigation<Signup, SignupViewModel>();
            containerRegistry.RegisterForNavigation<TipOff, TipOffViewModel>();
            containerRegistry.RegisterForNavigation<ReportMissingPersons, ReportMissingPersonsViewModel>();
            containerRegistry.RegisterForNavigation<LandingPage, LandingPageViewModel>();
            containerRegistry.RegisterForNavigation<Car, CarViewModel>();
            containerRegistry.RegisterForNavigation<PoliceStation, PoliceStationViewModel>();
            containerRegistry.RegisterForNavigation<Chat, ChatViewModel>();
            containerRegistry.RegisterForNavigation<Case, CaseViewModel>();
            containerRegistry.RegisterForNavigation<Clearance, ClearanceViewModel>();
            containerRegistry.RegisterForNavigation<Report, ReportViewModel>();
        }
    }
}
