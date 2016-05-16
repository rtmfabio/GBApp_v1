using GBApp.Models;
using GBApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GBApp.Views
{
    public partial class Login : ContentPage
    {
        private Boolean loginSuccess = true;
        private User user = User.Instance();
        private LoginViewModel viewmodel = new LoginViewModel();

        public Login()
        {
            InitializeComponent();
            BindingContext = viewmodel;
            user.Id = "1234";
            user.Name ="Fabio Mendonca";
        }
        public void OnLogin(object sender, EventArgs e)
        {
            
            //Tem que validar se é utilizador 
            if (loginSuccess)
            {
                Navigation.PushModalAsync(new TabsRegUser(user));
            }
            else
            {
                DisplayAlert("Alerta", "Utilizador Inválido", "OK");
            }
            
        }

        public void OnRegister(object sender, EventArgs e)
        {
            //Chama RegisterNewUser Page
            Navigation.PushModalAsync(new RegisterNewUser());
        }
        public void OnGuest(object sender, EventArgs e)
        {
            //Chama TabsGuest Page
            Navigation.PushModalAsync(new TabsGuest());
        }
    }
}
