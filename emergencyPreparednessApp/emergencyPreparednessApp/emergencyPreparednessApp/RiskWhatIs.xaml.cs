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
                    changeLang.Text = "Change language";
                    changeLoc.Text = "change location";
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

            switch (App.Emergency)
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
                case "tropicalStorm":
                    tropicalStormText();
                    break;
                case "volcano":
                    volcanoText();
                    break;
                case "earthquake":
                    earthquakeText();
                    break;
                default:
                    DisplayAlert("something went wrong with App.Emergency", "Yes", "yes");
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
                    whatIs.Text = "With global temperatures rising, there are more and more opportunities for dry weather and high temperatures to create forest fires. These forest fires lead to the rapid destruction of large areas";
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

        private void tropicalStormText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "Tropical storms are storms that are formed over tropical seas due to different temperatures in the atmosphere. They are extremely powerful and can cause landslides and flash floods due to their high winds and heavy rains.";
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

        private void volcanoText() {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "The closest volcano to Monteverde is the Arenal Volcano. While its eruption would not have direct effects on Monteverde, the volcano’s ashes do have a high probability of reaching the region and they come with several risks. The highest risks are respiratory issues and damage to agriculture";
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

        private void earthquakeText()
        {
            switch (App.Lang)
            {
                case "e":
                    whatIs.Text = "Earthquakes are caused by plates in the Earth’s crust moving. Earthquakes occur multiple times per year in Monteverde, and they can lead to landslides and falling objects";
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