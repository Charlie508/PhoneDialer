using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace phonebook
{
    public partial class App : Application
    {
        public static string LocalDatabase = string.Empty;
        public App(string DBLocation )
        {
            InitializeComponent();
            LocalDatabase= DBLocation;
            MainPage = new NavigationPage(new MainPage());
        }

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
