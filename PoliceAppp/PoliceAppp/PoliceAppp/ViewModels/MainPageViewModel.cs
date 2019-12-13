using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using PoliceAppp.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoliceAppp.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private ISecurityService _securityService;
        private IEventAggregator _eventAggregator;

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));


        public MainPageViewModel(INavigationService navigation, ISecurityService securityService, IEventAggregator eventAggregator) : base(navigation)
        {
            _securityService = securityService;

            _eventAggregator = eventAggregator;
        }

        void ExecuteLoginCommand()
        {
            // DO YOUR OWN LOGIN LOGIC AND VALIDATION
            var loginResult = _securityService.LogIn("Test User", "Password");

            // I may have gotten a user profile somewhere..  Use whatever your app does
            var userProfile = new UserProfile();

            if (loginResult)
            {
                _eventAggregator.GetEvent<LoginMessage>().Publish(userProfile);
            }
        }
    }
}
