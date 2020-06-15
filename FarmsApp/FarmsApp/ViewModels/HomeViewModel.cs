
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
    using Services;

    public class HomeViewModel : BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion

        #region Constructors
        public HomeViewModel()
        {
            // De esta forma se instancia el servicio en el constructor
            this.apiService = new ApiService();
            this.LoadHome();
        }

        #endregion

        #region Methods
        private async void LoadHome()
        {
            var connection = await this.apiService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    connection.Message,
                    "Accept");

                // Esta línea permite devolver al usuario a la página anterior (similar a un Esc pero por código)
                await Application.Current.MainPage.Navigation.PopAsync();
                return;
            }
        }

        #endregion

        #region Commands
        public ICommand BornCommand 
        {
            get 
            {
                return new RelayCommand(Born);
            }
        }

        private async void Born()
        {
            MainViewModel.GetInstance().Born = new BornViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new BornPage());
        }

        public ICommand InventoryCommand
        {
            get
            {
                return new RelayCommand(Inventory);
            }
        }

        private async void Inventory()
        {
            MainViewModel.GetInstance().Inventory = new InventoryViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new InventoryPage());
        }

        public ICommand PurchasesCommand
        {
            get
            {
                return new RelayCommand(Purchases);
            }
        }

        private async void Purchases()
        {
            MainViewModel.GetInstance().Purchases = new PurchasesViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new PurchasesPage());
        }

        public ICommand SalesCommand
        {
            get
            {
                return new RelayCommand(Sales);
            }
        }

        private async void Sales()
        {
            MainViewModel.GetInstance().Sales = new SalesViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new SalesPage());
        }

        public ICommand DeathCommand
        {
            get
            {
                return new RelayCommand(Death);
            }
        }

        private async void Death()
        {
            MainViewModel.GetInstance().Death = new DeathViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new DeathPage());
        }

        public ICommand LossesCommand
        {
            get
            {
                return new RelayCommand(Losses);
            }
        }

        private async void Losses()
        {
            MainViewModel.GetInstance().Losses = new LossesViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LossesPage());
        }

        public ICommand DataSheetCommand
        {
            get
            {
                return new RelayCommand(DataSheet);
            }
        }

        private async void DataSheet()
        {
            MainViewModel.GetInstance().DataSheet = new DataSheetViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new DatasheetPage());
        }
        #endregion
    }
}
