using System.Collections.Generic;
using Xamarin.Forms;

namespace PoliceAppp.Security
{
   
        public interface ISecurityService
        {
            IList<MenuItem> GetAllowedAccessItems();
            bool LogIn(string userName, string password);
            void LogOut();
        }

}