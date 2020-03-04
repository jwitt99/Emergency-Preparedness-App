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
    public partial class Risk : ContentPage
    {
        public Risk()
        {
            InitializeComponent();
        }
        private async void btnWhatIs_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RiskWhatIs());
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

        private async void btnWhatDo_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RiskWhatDo());
        }

        private async void btnPrepare_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RiskPrepare());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (App.Loc)
            {
                case "monteVerde":
                    img.Source = "monteVerde";
                    break;
                case "cerroPlano":
                    img.Source = "cerroPlano";
                    break;
                case "santaElena":
                    img.Source = "santaElena";
                    break;
                case "sanLuis":
                    img.Source = "sanLuis";
                    break;
                default:
                    break;
            }

            // switch language on universal buttons and labels for all risks
            switch (App.Lang)
            {
                case "e":
                    btnWhatDo.Text = "What do you do?";
                    btnPrepare.Text = "How do you prepare?";
                    changeLang.Text = "changeLang";
                    changeLoc.Text = "changeLoc";
                    contactInfo.Text = "contact info";
                    break;
                case "s":
                    btnWhatDo.Text = "Spanish What do you do?";
                    btnPrepare.Text = "Spanish How do you prepare?";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    btnWhatDo.Text = "Que faites-vous en cas d’urgence?";
                    btnPrepare.Text = "Comment preparez-vous?";
                    changeLang.Text = "Changez de langue";
                    changeLoc.Text = "Changez de lieu";
                    contactInfo.Text = "Coordonnées";
                    break;
                case "g":
                    btnWhatDo.Text = "German What do you do?";
                    btnPrepare.Text = "German How do you prepare?";
                    changeLang.Text = "German changeLang";
                    changeLoc.Text = "German changeLoc";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    break;
            }

            switch (App.Emergency) {
                case "landslide":
                    landslideText();
                    break;
                case "flood":
                    floodText();
                    break;
                case "fire":
                    fireText();
                    break;
                default:
                    DisplayAlert("something went wrong", "Yes", "yes");
                    break;
            }
        }

        private void landslideText() {
            switch (App.Lang)
            {
                case "e":
                    titleLabel.Text = "Landslide";
                    break;
                case "s":
                    titleLabel.Text = "spanish landslide";
                    break;
                case "f":
                    titleLabel.Text = "Glissement de terre";
                    break;
                case "g":
                    titleLabel.Text = "german landslide";
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
                    titleLabel.Text = "Flood";
                    break;
                case "s":
                    titleLabel.Text = "spanish flood";
                    break;
                case "f":
                    titleLabel.Text = "Inondation";
                    break;
                case "g":
                    titleLabel.Text = "german flood";
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
                    titleLabel.Text = "Fire Object";
                    break;
                case "s":
                    titleLabel.Text = "spanish Fire";
                    break;
                case "f":
                    titleLabel.Text = "Feu";
                    break;
                case "g":
                    titleLabel.Text = "german Fire";
                    break;
                default:
                    break;
            }
        }
    }
}