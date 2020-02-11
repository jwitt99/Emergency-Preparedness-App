﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emergencyPreparednessApp
{
    public partial class App : Application
    {
        private string lang = "English";
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
