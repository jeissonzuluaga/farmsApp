

namespace FarmsApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class MainViewModel
    {
        #region ViewModels

        private static MainViewModel instance;
        internal HomeViewModel Home;

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
