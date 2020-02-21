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

        bool isWhatExpanded = false;
        private async void btnWhatClicked(object sender, EventArgs e)
        {
            if (isWhatExpanded)
            {
                await MoreDetails.FadeTo(0);
                MoreDetails.IsVisible = !isWhatExpanded;
            }
            else
            {
                MoreDetails.IsVisible = !isWhatExpanded;
                await MoreDetails.FadeTo(1);
            }

            isWhatExpanded = !isWhatExpanded;
        }

        bool isPrepExpanded = false;
        private async void btnPrepareClicked(object sender, EventArgs e)
        {
            if (isPrepExpanded)
            {
                await MoreDetails2.FadeTo(0);
                MoreDetails2.IsVisible = !isPrepExpanded;
            }
            else
            {
                MoreDetails2.IsVisible = !isPrepExpanded;
                await MoreDetails2.FadeTo(1);
            }

            isPrepExpanded = !isPrepExpanded;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // switch language on universal buttons and labels for all risks
            switch (App.Lang)
            {
                case "e":
                    btnWhat.Text = "What do you do?";
                    btnPrepare.Text = "How do you prepare?";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "s":
                    btnWhat.Text = "Spanish What do you do?";
                    btnPrepare.Text = "Spanish How do you prepare?";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    btnWhat.Text = "French What do you do?";
                    btnPrepare.Text = "French How do you prepare?";
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    btnWhat.Text = "German What do you do?";
                    btnPrepare.Text = "German How do you prepare?";
                    changeLang.Text = "German changeLang";
                    changeLoc.Text = "German changeLoc";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    break;
            }

            switch (App.Risk) {
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

        private void landslideText() {
            switch (App.Lang)
            {
                case "e":
                    titleLabel.Text = "Landslide";
                    what1.Text = "Info 1";
                    what2.Text = "Info 2";
                    prep1.Text = "Prep info 1";
                    prep2.Text = "Prep info 2";
                    break;
                case "s":
                    titleLabel.Text = "spanish landslide";
                    what1.Text = "Spanish what1";
                    what2.Text = "Spanish what2";
                    prep1.Text = "Spanish prep1";
                    prep2.Text = "Spanish prep2";
                    break;
                case "f":
                    titleLabel.Text = "french landslide";
                    what1.Text = "French what1";
                    what2.Text = "French what2";
                    prep1.Text = "French prep1";
                    prep2.Text = "French prep2";
                    break;
                case "g":
                    titleLabel.Text = "german landslide";
                    what1.Text = "German what1";
                    what2.Text = "German what2";
                    prep1.Text = "German prep1";
                    prep2.Text = "German prep2";
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
                    what1.Text = "Info 1";
                    what2.Text = "Info 2";
                    prep1.Text = "Prep info 1";
                    prep2.Text = "Prep info 2";
                    break;
                case "s":
                    titleLabel.Text = "spanish flood";
                    what1.Text = "Spanish what1";
                    what2.Text = "Spanish what2";
                    prep1.Text = "Spanish prep1";
                    prep2.Text = "Spanish prep2";
                    break;
                case "f":
                    titleLabel.Text = "french flood";
                    what1.Text = "French what1";
                    what2.Text = "French what2";
                    prep1.Text = "French prep1";
                    prep2.Text = "French prep2";
                    break;
                case "g":
                    titleLabel.Text = "german flood";
                    what1.Text = "German what1";
                    what2.Text = "German what2";
                    prep1.Text = "German prep1";
                    prep2.Text = "German prep2";
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
                    what1.Text = "Info 1";
                    what2.Text = "Info 2";
                    prep1.Text = "Prep info 1";
                    prep2.Text = "Prep info 2";
                    break;
                case "s":
                    titleLabel.Text = "spanish Fire";
                    what1.Text = "Spanish what1";
                    what2.Text = "Spanish what2";
                    prep1.Text = "Spanish prep1";
                    prep2.Text = "Spanish prep2";
                    break;
                case "f":
                    titleLabel.Text = "french Fire";
                    what1.Text = "French what1";
                    what2.Text = "French what2";
                    prep1.Text = "French prep1";
                    prep2.Text = "French prep2";
                    break;
                case "g":
                    titleLabel.Text = "german Fire";
                    what1.Text = "German what1";
                    what2.Text = "German what2";
                    prep1.Text = "German prep1";
                    prep2.Text = "German prep2";
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
                    titleLabel.Text = "Fallen Object";
                    what1.Text = "Info 1";
                    what2.Text = "Info 2";
                    prep1.Text = "Prep info 1";
                    prep2.Text = "Prep info 2";
                    break;
                case "s":
                    titleLabel.Text = "spanish fallen object";
                    what1.Text = "Spanish what1";
                    what2.Text = "Spanish what2";
                    prep1.Text = "Spanish prep1";
                    prep2.Text = "Spanish prep2";
                    break;
                case "f":
                    titleLabel.Text = "french fallen object";
                    what1.Text = "French what1";
                    what2.Text = "French what2";
                    prep1.Text = "French prep1";
                    prep2.Text = "French prep2";
                    break;
                case "g":
                    titleLabel.Text = "german fallen object";
                    what1.Text = "German what1";
                    what2.Text = "German what2";
                    prep1.Text = "German prep1";
                    prep2.Text = "German prep2";
                    break;
                default:
                    break;
            }
        }
    }
}