using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emergencyPreparednessApp
{
    public partial class App : Application
    {
        public static string Lang = "e";
        public static string Risk = "landslide";
        public static string NaturalDisaster = "earthquake";
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
