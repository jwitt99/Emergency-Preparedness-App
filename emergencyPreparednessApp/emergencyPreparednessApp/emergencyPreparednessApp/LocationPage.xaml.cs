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
    public partial class LocationPage : ContentPage
    {
        private string popupName = "You sure?";
        private string popupText = "Choosing a location will allow you to get more specific information";
        private string yesButton = "Yes";
        private string noButton = "No";
        public LocationPage()
        {
            InitializeComponent();
        }

        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (App.Lang) {
                case "e":
                    break;
                case "s":
                    label1.Text = "Spanish What region are you from?";
                    notSureButton.Text = "Not sure but in spanish";
                    popupName = "You sure? But in spanish";
                    popupText = "Spanish version of Choosing a location will allow you to get more specific information";
                    yesButton = "Spanish yes";
                    noButton = "Spanish no";
                    changeLang.Text = "Spanish Change Language";
                    break;
                case "f":
                    label1.Text = "French What region are you from?";
                    notSureButton.Text = "Not sure but in french";
                    popupName = "You sure? But in french";
                    popupText = "French version of Choosing a location will allow you to get more specific information";
                    yesButton = "French yes";
                    noButton = "French no";
                    changeLang.Text = "French Change Language";
                    break;
                case "g":
                    label1.Text = "German What region are you from?";
                    notSureButton.Text = "Not sure but in German";
                    popupName = "You sure? But in german";
                    popupText = "German version of Choosing a location will allow you to get more specific information";
                    yesButton = "German yes";
                    noButton = "German no";
                    changeLang.Text = "German Change Language";
                    break;
                default:
                    label1.Text = "Something broke";
                    break;
            }
        }

        private async void NotSureRegionButton_OnClicked(object sender, EventArgs e) {
            bool answer = await DisplayAlert(popupName, popupText, yesButton, noButton);
            if (answer) {
                await Navigation.PushAsync(new MainRiskMapPage());
            } 
        }
        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainRiskMapPage());
        }

    }
}