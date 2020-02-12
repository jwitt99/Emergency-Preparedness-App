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
        public LocationPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            change.Text = App.Lang;
        }

        private async void NotSureRegionButton_OnClicked(object sender, EventArgs e) {
            bool answer = await DisplayAlert(popupName, popupText, "Yes", "No");
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