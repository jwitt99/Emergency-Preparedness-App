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
        static bool isFirst = true; // true : goes to mainriskmap selection screen || false: goes back to menu that called it 
        public LocationPage()
        {
            InitializeComponent();
        }

        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void ContactInfoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactInfo());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (App.Lang) {
                case "e":
                    label1.Text = "What region are you from?";
                    notSureButton.Text = "Not Sure";
                    popupName = "You sure?";
                    popupText = "Choosing a location will allow you to get more specific information";
                    yesButton = "yes";
                    noButton = "no";
                    changeLang.Text = "Change Language";
                    contactInfo.Text = "contact info";
                    break;
                case "s":
                    label1.Text = "¿De qué región eres?";
                    notSureButton.Text = "No estoy seguro";
                    popupName = "You sure? But in spanish";
                    popupText = "Spanish version of Choosing a location will allow you to get more specific information";
                    yesButton = "Spanish yes";
                    noButton = "Spanish no";
                    changeLang.Text = "Cambiar idioma";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    label1.Text = "French What region are you from?";
                    notSureButton.Text = "Not sure but in french";
                    popupName = "You sure? But in french";
                    popupText = "French version of Choosing a location will allow you to get more specific information";
                    yesButton = "French yes";
                    noButton = "French no";
                    changeLang.Text = "French Change Language";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    label1.Text = "German What region are you from?";
                    notSureButton.Text = "Not sure but in German";
                    popupName = "You sure? But in german";
                    popupText = "German version of Choosing a location will allow you to get more specific information";
                    yesButton = "German yes";
                    noButton = "German no";
                    changeLang.Text = "German Change Language";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    label1.Text = "Something broke";
                    break;
            }
        }

        private async void NotSureRegionButton_OnClicked(object sender, EventArgs e) {
            bool answer = await DisplayAlert(popupName, popupText, yesButton, noButton);
            if (answer) {
                if (isFirst)
                {
                    isFirst = false;
                    await Navigation.PushAsync(new MainRiskMapPage());
                }
                else
                {
                    await Navigation.PopAsync();
                }
            } 
        }
        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            if (isFirst)
            {
                isFirst = false;
                await Navigation.PushAsync(new MainRiskMapPage());
            }
            else
            {
                await Navigation.PopAsync();
            }
        }

    }
}