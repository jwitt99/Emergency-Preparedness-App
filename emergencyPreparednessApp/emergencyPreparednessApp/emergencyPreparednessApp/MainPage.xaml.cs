using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace emergencyPreparednessApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        static bool isFirst = true; // true : goes to region selection screen || false: goes back to menu that called it 
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void ContactInfoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactInfo());
        }
        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            App.Lang = ((Button)sender).StyleId;
            if (isFirst)
            {
                isFirst = false;
                await Navigation.PushAsync(new LocationPage());
            }
            else {
                await Navigation.PopAsync();
            }
        }
    }
}
