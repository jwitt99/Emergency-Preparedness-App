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
    public partial class RiskWhatIs : ContentPage
    {
        public RiskWhatIs()
        {
            InitializeComponent();
        }

        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }
        private async void ContactInfoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactInfo());
        }

        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // switch language on universal buttons and labels for all risks
            switch (App.Lang)
            {
                case "e":
                    changeLang.Text = "changeLang";
                    changeLoc.Text = "changeLoc";
                    contactInfo.Text = "contact info";
                    break;
                case "s":
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    changeLang.Text = "German changeLang";
                    changeLoc.Text = "German changeLoc";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    break;
            }

            switch (App.Risk)
            {
                case "landslide":
                    landslideText();
                    break;
                case "flood":
                    floodText();
                    break;
                case "fire":
                    fireText();
                    break;
                case "fallenObject":
                    fallenObjectText();
                    break;
                default:
                    DisplayAlert("something went wrong", "Yes", "yes");
                    break;
            }
        }

        private void landslideText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "Landslides are a collection of fast-moving mud and debris flowing rapidly through an area. It starts off as a bunch of loose soil that becomes disturbed by wind or rain, and gravity starts to make it go faster. It can quickly gain a lot of force and will start picking up large branches, loose pavement, trees, and buildings. ";
                    break;
                case "s":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                default:
                    break;
            }
        }
        private void floodText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "Flash floods are caused by a lot of water building up in an area that has loose soil. When enough water builds up in the area, the soil comes loose and all the water floods the lower areas at once.";
                    break;
                case "s":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                default:
                    break;
            }
        }

        private void fireText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "English Fire";
                    break;
                case "s":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                default:
                    break;
            }

        }

        private void fallenObjectText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "English fallen object";
                    break;
                case "s":
                    break;
                case "f":
                    break;
                case "g":
                    break;
                default:
                    break;
            }
        }
    }
}