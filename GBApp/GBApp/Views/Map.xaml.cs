using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GBApp.Views
{
    public partial class Map : ContentPage
    {
        public Map()
        {
            InitializeComponent();
            var position = new Position(37.79762, -122.40181);
            MyMap.MoveToRegion(new MapSpan(position, 0.01, 0.01));
            
            MyMap.Pins.Add(new Pin
            {
                Label = "GBApp",
                Position = position
            });
        }
    }
}
