using AppXam13.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppXam13.Infrastructure
{
    public class InstaceLocator
    {

        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        } 
        #endregion

    }
}
