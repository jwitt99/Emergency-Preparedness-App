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
    public partial class NaturalDisaster : ContentPage
    {
        public NaturalDisaster()
        {
            InitializeComponent();
        }
        private async void RiskButton_OnClicked(object sender, EventArgs e)
        {
            App.Risk = ((Button)sender).StyleId;
            await Navigation.PushAsync(new Risk());
        }
        private async void ContactInfoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactInfo());
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
                    landslide.Text = "Landslide";
                    flood.Text = "Flood";
                    fire.Text = "Fire";
                    fallenObject.Text = "Fallen Object";
                    contactInfo.Text = "Contact info";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    break;
                case "s":
                    landslide.Text = "Spanish landslide";
                    flood.Text = "Spanish flood";
                    fire.Text = "Spanish fire";
                    fallenObject.Text = "Spanish fallenObject";
                    contactInfo.Text = "Spanish contact info";
                    changeLang.Text = "Spanish Language";
                    changeLoc.Text = "Spanish Location";
                    break;
                case "f":
                    landslide.Text = "French landslide";
                    flood.Text = "French flood";
                    fire.Text = "French fire";
                    fallenObject.Text = "French fallenObject";
                    contactInfo.Text = "French contact info";
                    changeLang.Text = "French Change Language";
                    changeLoc.Text = "French Change Location";
                    break;
                case "g":
                    landslide.Text = "German landslide";
                    flood.Text = "German flood";
                    fire.Text = "German fire";
                    fallenObject.Text = "German fallenObject";
                    contactInfo.Text = "German contact info";
                    changeLang.Text = "German Change Language";
                    changeLoc.Text = "German Change Location";
                    break;
                default:
                    break;
            }

            switch (App.NaturalDisaster) {
                case "earthquake":
                    switch (App.Lang)
                    {
                        case "e":
                            titleLabel.Text = "Earthquake";
                            break;
                        case "s":
                            titleLabel.Text = "Spanish earthquake";
                            break;
                        case "f":
                            titleLabel.Text = "French earthquake";
                            break;
                        case "g":
                            titleLabel.Text = "Spanish earthquake";
                            break;
                        default:
                            break;
                    }
                    fire.IsVisible = false;
                    flood.IsVisible = false;
                    break;
                case "tropicalStorm":
                    switch (App.Lang)
                    {
                        case "e":
                            titleLabel.Text = "Tropical storm";
                            break;
                        case "s":
                            titleLabel.Text = "Spanish tropical storm";
                            break;
                        case "f":
                            titleLabel.Text = "French tropical storm";
                            break;
                        case "g":
                            titleLabel.Text = "Spanish tropical storm";
                            break;
                        default:
                            break;
                    }
                    fire.IsVisible = false;
                    fallenObject.IsVisible = false;
                    break;
                case "volcano":
                    switch (App.Lang)
                    {
                        case "e":
                            titleLabel.Text = "Volcano";
                            break;
                        case "s":
                            titleLabel.Text = "Spanish volcano";
                            break;
                        case "f":
                            titleLabel.Text = "French volcano";
                            break;
                        case "g":
                            titleLabel.Text = "Spanish volcano";
                            break;
                        default:
                            break;
                    }
                    break;


            }
        }

    }
}