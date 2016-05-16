using GBApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace GBApp
{
    class TabsGuest : TabbedPage
    {
        public TabsGuest()
        {
            this.Title = "GetBack App - Guest Access";
           
            this.Children.Add(new NavigationPage(new Views.Pesquisa()) { Title = "Pesquisa" } );           
            this.Children.Add(new NavigationPage(new Views.GbAppInfoPage()) { Title = "GbAppInfoPage" });
        }
    }
}
