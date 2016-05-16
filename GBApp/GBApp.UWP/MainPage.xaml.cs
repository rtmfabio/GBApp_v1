using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace GBApp.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("LOmPY44FSv9k8LqwVMgn~2ALxOiC9ORe7GDe3oglWGQ~AqRrwn6eJqORDNnhS7JS-JvbQKpv_ZMOcmm1_tZeygAzXevvb2nPI_9JT257DLIv");
            LoadApplication(new GBApp.App());
        }
    }
}
