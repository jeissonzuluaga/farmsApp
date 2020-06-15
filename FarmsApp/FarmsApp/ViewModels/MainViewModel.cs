

namespace FarmsApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get ;
            set ;
        }

        public HomeViewModel Home
        {
            get;
            set;
        }

        public SignUpViewModel SignUp
        {
            get;
            set;
        }
        internal  BornViewModel Born 
        {
            get;
            
            set; 
        }
        internal InventoryViewModel Inventory 
        {
            get;
            set;        
        }

        internal PurchasesViewModel Purchases
        {
            get;
            set;

        }
        internal SalesViewModel Sales
        {   
            get;
            set;
        }

        internal DeathViewModel Death
        {
            get;
            set;
        }
        internal LostViewModel Losses 
        {
            get;
            set;
        }
        internal DataSheetViewModel DataSheet
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion        
    }

}
