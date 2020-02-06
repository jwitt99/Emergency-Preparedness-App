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
        public MainPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            //        count++;
            //       ((Button)sender).Text = $"You clicked {count} times.";
            change.Text = ((Button)sender).StyleId;
        }

        private async void SuppliesButton_OnClicked(object sender, EventArgs e)
        {
            change.Text = ((Button)sender).StyleId;
            await Navigation.PushAsync(new SuppliesPage());
        }
    }
}
