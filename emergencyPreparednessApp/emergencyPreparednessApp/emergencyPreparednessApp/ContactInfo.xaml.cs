using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emergencyPreparednessApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactInfo : ContentPage
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private async void BackButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();//make it to back to last screen
        }

        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }

        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (App.Lang)
            {
                case "e":
                    titleLabel.Text = "Contact Info";
                    police.Text = "police: xxx-xxx-xxxx";
                    fireFighters.Text = "fireFighters: xxx-xxx-xxxx";
                    redCross.Text = "redCross: xxx-xxx-xxxx";
                    CPI.Text = "CPI: xxx-xxx-xxxx";
                    friendsSchool.Text = "friendsSchool: xxx-xxx-xxxx";
                    break;
                case "s":
                    titleLabel.Text = "Spanish Contact Info";
                    police.Text = "Spanish police: xxx-xxx-xxxx";
                    fireFighters.Text = "Spanish fireFighters: xxx-xxx-xxxx";
                    redCross.Text = "Spanish redCross: xxx-xxx-xxxx";
                    CPI.Text = "Spanish CPI: xxx-xxx-xxxx";
                    friendsSchool.Text = "Spanish friendsSchool: xxx-xxx-xxxx";
                    break;
                case "f":
                    titleLabel.Text = "French Contact Info";
                    police.Text = "French police: xxx-xxx-xxxx";
                    fireFighters.Text = "French fireFighters: xxx-xxx-xxxx";
                    redCross.Text = "French redCross: xxx-xxx-xxxx";
                    CPI.Text = "French CPI: xxx-xxx-xxxx";
                    friendsSchool.Text = "French friendsSchool: xxx-xxx-xxxx";
                    break;
                case "g":
                    titleLabel.Text = "German Contact Info";
                    police.Text = "German police: xxx-xxx-xxxx";
                    fireFighters.Text = "German fireFighters: xxx-xxx-xxxx";
                    redCross.Text = "German redCross: xxx-xxx-xxxx";
                    CPI.Text = "German CPI: xxx-xxx-xxxx";
                    friendsSchool.Text = "German friendsSchool: xxx-xxx-xxxx";
                    break;
                default:
                    break;
            }
        }
    }
}