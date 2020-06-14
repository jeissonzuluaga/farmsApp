

namespace FarmsApp.Infraestructure
{
    using FarmsApp.ViewModels;
    using System;
    using System.Collections.Generic;
    using System.Text;

    class InstanceLocator
    {
        #region Propierties
        public MainViewModel Main{
            get ;
            set ;
        }

        #endregion

        #region Constructor
        public InstanceLocator()
        {
            this.Main = new MainViewModel(); 
        }


        #endregion

    }
}
