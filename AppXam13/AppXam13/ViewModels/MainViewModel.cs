using System;
using System.Collections.Generic;
using System.Text;

namespace AppXam13.ViewModels
{
    public class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login
        {
            get;
            set;
        }

        public LandsViewModel Lands 
        { 
            get; 
            set; 
        }

        #endregion


        #region Constructors
        public MainViewModel()
        {
            instace = this;
            this.Login = new LoginViewModel();
        }
        #endregion


        /*matiene una unica MainViewModel en la ejecucion del proyecto*/
        #region Singleton
        private static MainViewModel instace;

        public static MainViewModel GetInstace()
        {
            if( instace == null)
            {
                return new MainViewModel();
            }
            return instace;
        }
        #endregion



    }
}
