using FarmsApp.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FarmsApp.ViewModels
{
    class LoginViewModel
    {
        public ICommand HomeCommand
        {
            get
            {
                return new RelayCommand(Home);
            }
        }
        private async void Home()
        {
            //A través de este método se pueden validar datos de ingreso o validar que el usuario realice
            //una acción obligatoria. Por ejm:
            //if (string .IsNullOrEmpty(this.Email))
            //{
            //    await Application.Current.MainPage.DisplayAlert(
            //        "Título del mensaje - ERROR",
            //        ";Mensaje - Debe digitar un correo electrónico",
            //        "Como se va a llamar el botón - Aceptar");
            //    return;
            //}

            MainViewModel.GetInstance().Home = new HomeViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }
    }
    
    
}
