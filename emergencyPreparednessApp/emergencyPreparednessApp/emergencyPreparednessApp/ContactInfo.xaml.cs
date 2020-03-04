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
                    backButton.Text = "Back";
                    titleLabel.Text = "Contact Info";
                    emergency.Text = "Emergency: 911";
                    police.Text = "Police: 2645-7074";
                    fireFighters.Text = "Fire Fighters: 2645-7512";
                    redCross.Text = "Red Cross: 2645-6128";
                    waterService.Text = "Water Service: 2645-5502";
                    toxicologist.Text = "Center of Toxicology: 2233-1028";
                    CPI.Text = "CPI: 2645-5441";
                    friendsSchool.Text = "Friends School: 2645-5530";
                    break;
                case "s":
                    titleLabel.Text = "Spanish Contact Info";
                    emergency.Text = "Spanish Emergency: 911";
                    police.Text = "Spanish Police: 2645-7074";
                    fireFighters.Text = "Spanish Fire Fighters: 2645-7512";
                    redCross.Text = "Spanish Red Cross: 2645-6128";
                    waterService.Text = "Spanish Water Service: 2645-5502";
                    toxicologist.Text = "Spanish Center of Toxicology: 2233-1028";
                    CPI.Text = "Spanish CPI: 2645-5441";
                    friendsSchool.Text = "Spanish Friends School: 2645-5530";
                    break;
                case "f":
                    titleLabel.Text = "Les coordonnées";
                    emergency.Text = "L’Urgence: 911";
                    police.Text = "La police: 2645-7074";
                    fireFighters.Text = "Les sapeurs pompiers: 2645-7512";
                    redCross.Text = "La croix rouge: 2645-6128";
                    waterService.Text = "Le service d’eau: 2645-5502";
                    toxicologist.Text = "Le centre de toxicologie: 2233-1028";
                    CPI.Text = "CPI: 2645-5441";
                    friendsSchool.Text = "L’école d’amis: 2645-5530";
                    break;
                case "g":
                    titleLabel.Text = "German Contact Info";
                    emergency.Text = "German Emergency: 911";
                    police.Text = "German Police: 2645-7074";
                    fireFighters.Text = "German Fire Fighters: 2645-7512";
                    redCross.Text = "German Red Cross: 2645-6128";
                    waterService.Text = "German Water Service: 2645-5502";
                    toxicologist.Text = "German Center of Toxicology: 2233-1028";
                    CPI.Text = "German CPI: 2645-5441";
                    friendsSchool.Text = "German Friends School: 2645-5530";
                    break;
                default:
                    break;
            }
        }
    }
}