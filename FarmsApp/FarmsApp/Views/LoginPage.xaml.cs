
namespace FarmsApp.Views
{
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
        public ICommand TapForgot => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}