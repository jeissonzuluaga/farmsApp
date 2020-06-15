
namespace FarmsApp.Views
{
    using FarmsApp.Infraestructure;
    using FarmsApp.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Essentials;
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //public ICommand TapForgot => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public LoginPage()
        {
            InitializeComponent();
            //BindingContext = this;
            
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            string Correo = CorreoInput.Text;
            string Contraseña = PassInput.Text;
            var fbLogin = DependencyService.Get<FirebaseAuthConn>();
            await fbLogin.DoLoginWithUP(Correo, Contraseña);
            await DisplayAlert("LOGIN", "Has ingresado", "Bienvenido(a)");

            if (string.IsNullOrEmpty(this.CorreoInput.Text))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Correo no aceptado.",
                    "Aceptar");
                return;
            }
            if (string.IsNullOrEmpty(this.PassInput.Text))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Ingrese Password.",
                    "Aceptar");
                return;
            }
            if (fbLogin.Equals(Correo) && fbLogin.Equals(Contraseña))
            {
                await DisplayAlert("0", "0", "0");

            }
            MainViewModel.GetInstance().Home = new HomeViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new HomePage());

        }
        private async void Register_Clicked(object sender, EventArgs e)
        {
            string Correo = CorreoInput.Text;
            string Contraseña = PassInput.Text;

            var fbLogin = DependencyService.Get<FirebaseAuthConn>();
            await fbLogin.DoRegisterWithUP(Correo, Contraseña);
            await DisplayAlert("Registro", "Exitoso" + Correo, "OK");
        }
    }
}