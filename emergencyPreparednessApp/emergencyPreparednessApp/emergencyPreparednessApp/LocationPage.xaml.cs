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
        public LocationPage()
        {
            InitializeComponent();
        }

        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            change.Text = ((Button)sender).Text;
            await Navigation.PushAsync(new MainRiskMapPage());
        }

    }
}