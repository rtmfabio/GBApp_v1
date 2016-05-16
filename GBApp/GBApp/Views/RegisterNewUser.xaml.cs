using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace GBApp.Views
{
    public partial class RegisterNewUser : ContentPage
    {
        public RegisterNewUser()
        {
            InitializeComponent();
           
        }

        public void RegisterUser(object sender, EventArgs e)
        {
            //Valida se existe utilizador
         
            var newUser = true;

            if (!newUser)
            {
                DisplayAlert("Alerta", "Email", "OK");
            }
            else
            {
                DisplayAlert("Alerta", "Registo efetuado", "OK");
                Navigation.PopModalAsync();
                
            }
            
        }
    }
}
