using AppXam13.Views;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppXam13.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Events
        //public event PropertyChangedEventHandler PropertyChanged; // Se usa para refrescar campos : InotifyPropertyChanged
        #endregion

        #region Attributes
        //Propiedades que se quieren refrescar en tiempo de ejecucion
        private string email;
        private bool isRunning;
        private bool isEnabled;
        #endregion


        #region Properties

        // Asiganaciones para refrecar campos -- se creo BaseViewModel para esto
        /*
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (this.email != value)
                {
                    this.email = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(this.Email)));
                }
            }
        }
        */
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email,value); }
        }
        
        public bool IsRemembered
        {
            get;
            set;
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
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
            this.IsRemembered = true;
            this.IsEnabled = true;

            this.Email = "admin";
        }
        #endregion

        // Botones
        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);// metodo de la libreria MvvmLightLibsStd10
            }
        }



        private async void Login()
        {

            //forma mejorada - this.Email == ""
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Your must enter an email",
                    "Accept");
                return;
            }

            this.IsRunning = true; //si esta corriendo
            this.IsEnabled = false; // desactive el boton

            if (this.Email != "admin")
            {
                /*cuando hace la consulta animacion del activity y desactiva el boton*/
                this.IsRunning = false; 
                this.IsEnabled = true; 

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email incorrect",
                    "Accept");
                this.Email = string.Empty;
                return;
            }


            this.IsRunning = false;
            this.IsEnabled = true;
            /*datos son correctos*/
            this.Email = string.Empty;

            /*garantiza que la pantalla a cambiar se establesca como MainViewModel*/
            MainViewModel.GetInstace().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage()); // cambio de patanlla

        }
        #endregion

    }
}
