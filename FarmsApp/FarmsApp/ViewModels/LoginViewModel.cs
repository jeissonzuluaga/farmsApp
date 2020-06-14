
namespace FarmsApp.ViewModels
{
    using Views;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using System.ComponentModel;

    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string usuario;
        private string password;
        private bool isEnabled;
        #endregion


        #region Properties
        public string Usuario
        {
            get { return this.usuario; }
            set { SetValue(ref this.usuario, value); }
        }
        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion


        #region Constructors
        public LoginViewModel()
        {
            //Aquí se le pueden dar valores iniciales a controles como un switch, un Entry o un Button
            this.Usuario = string.Empty;
            this.Password = string.Empty;
            this.IsEnabled = true;
        }
        #endregion


        #region Commands
        public ICommand EnterCommand
        {
            get
            {
                return new RelayCommand(Enter);
            }
        }
        private async void Enter()
        {
            if (string.IsNullOrEmpty(this.Usuario))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Usuario no aceptado.",
                    "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Contraseña no aceptada.",
                    "Aceptar");
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                "Notificación",
                "Ingreso Exitoso.",
                "Bienvenido(a)");

            this.Usuario = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Home = new HomeViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new HomePage());

        }

        public ICommand SignUpCommand
        {
            get
            {
                return new RelayCommand(SignUpL);
            }
        }
        private async void SignUpL()
        {
            await Application.Current.MainPage.DisplayAlert(
                "Notificación",
                "Registro de Usuario.",
                "Registro");

            MainViewModel.GetInstance().SignUp = new SignUpViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());

        }
        #endregion
    }
}
