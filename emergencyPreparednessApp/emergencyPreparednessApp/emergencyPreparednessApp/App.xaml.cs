using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emergencyPreparednessApp
{
    public partial class App : Application
    {
        public static string Lang = "e";
        public static string Loc = "santaElena";
        public static string Emergency = "landslide";
        public App()
        {
            
            InitializeComponent();

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
