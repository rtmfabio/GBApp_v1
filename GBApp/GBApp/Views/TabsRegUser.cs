using GBApp.Models;
using GBApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace GBApp
{
    class TabsRegUser : TabbedPage
    {
        private User _user;

        public TabsRegUser(User user)
        {
            this._user = user;
            this.Title = "GetBack App - " + _user.Name.ToString(); 
            this.Children.Add(new NavigationPage(new Views.RegUserHome()) { Title = "Home" });
            this.Children.Add(new NavigationPage(new Views.Pesquisa()) { Title = "Pesquisa" } );           
            this.Children.Add(new NavigationPage(new Views.UserProfile()) { Title = "Definições" });
            this.Children.Add(new NavigationPage(new Views.GbAppInfoPage()) { Title = "GbAppInfoPage" });
        }
    }
}
