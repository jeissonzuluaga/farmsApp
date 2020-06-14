
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


    public class HomeViewModel : BaseViewModel
    {
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
        #endregion
        #region CommandInventory
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
        #endregion
        #region CommandPurchases
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
        #endregion
        #region CommandSales
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
        #endregion#region CommandSales
        #region CommandDeath
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
        #endregion
        #region CommandLosses
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
        #endregion
        #region CommandDataSheet
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
