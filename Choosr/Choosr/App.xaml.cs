using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Choosr.Views;
using Choosr.Models;
using System.ComponentModel;

namespace Choosr
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        // public static User currUser { get; set; }

        public User _currUser = new User();
        public User currUser
        {
            get => _currUser;
            set
            {
                if (_currUser != value)
                {
                    _currUser = value;
                    MessagingCenter.Send<App>(this, "Hi");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
