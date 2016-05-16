using GBApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GBApp.Views
{
    public partial class ResultList : ContentPage
    {
        public ResultList()
        {
            ObservableCollection<Company> employees = new ObservableCollection<Company>();
            InitializeComponent();
            ResultListView.ItemsSource = employees;
            employees.Add(new Company { ID = 1, DisplayName = "Pizzaria Pulcinella", Longitude = 41.1784884, Latitude = -8.6921127 });
            employees.Add(new Company { ID = 2, DisplayName = "Pasta Fresca", Longitude = 41.181740, Latitude = -8.689608 });
            employees.Add(new Company { ID = 3, DisplayName = "Presto Pizza", Longitude = 41.176942, Latitude = -8.6890872 });

        }
        public void OnMap(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}
