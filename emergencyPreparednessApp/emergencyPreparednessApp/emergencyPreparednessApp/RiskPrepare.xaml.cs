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
    public partial class RiskPrepare : ContentPage
    {
        public RiskPrepare()
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


        bool isResExpanded = false;
        private async void btnResident_OnClicked(object sender, EventArgs e)
        {
            if (isResExpanded)
            {
                await residentInfo.FadeTo(0);
                residentInfo.IsVisible = !isResExpanded;
            }
            else
            {
                residentInfo.IsVisible = !isResExpanded;
                await residentInfo.FadeTo(1);
            }

            isResExpanded = !isResExpanded;
        }
        bool isVisExpanded = false;


        private async void btnVisitor_OnClicked(object sender, EventArgs e)
        {
            if (isVisExpanded)
            {
                await visitorInfo.FadeTo(0);
                visitorInfo.IsVisible = !isVisExpanded;
            }
            else
            {
                visitorInfo.IsVisible = !isVisExpanded;
                await visitorInfo.FadeTo(1);
            }

            isVisExpanded = !isVisExpanded;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // switch language on universal buttons and labels for all risks
            switch (App.Lang)
            {
                case "e":
                    btnResident.Text = "Resident";
                    btnVisitor.Text = "Visitor";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    contactInfo.Text = "Contact info";
                    break;
                case "s":
                    btnResident.Text = "Spanish btnResident";
                    btnVisitor.Text = "Spanish btnVisitor";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    btnResident.Text = "French btnResident";
                    btnVisitor.Text = "French btnVisitor";
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    btnResident.Text = "German btnResident";
                    btnVisitor.Text = "German btnVisitor";
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

        string labelTxt = "<Label FontSize=\"20\" Margin=\"10,0,0,0\"/>";
        string labelIndentTxt = "<Label FontSize=\"20\" Margin=\"60,0,0,0\"/>";
        string labelIndent2Txt = "<Label FontSize=\"20\" Margin=\"120,0,0,0\"/>";
        private void landslideText()
        {
            //Resident
            switch (App.Lang)
            {
                case "e":
                    Label label = new Label().LoadFromXaml(labelTxt);
                    label.Text = "Evacuate if:";
                    residentInfo.Children.Add(label);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-The CNE announces a Red Alert";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-You live in a high risk area and you hear there is a high possibility of: a tropical storm, earthquake";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Do Not Forget Your Pets! If you have time, make sure they are safe as well";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "Where to evacuate?";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "-If there is a Red Alert or the police force has asked you to evacuate, go to the Monteverde Institute or the Friends School depending on your area";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "-If there has not been an official order of evacuation, stay in the home of a friend or family member who is outside the area of risk";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "If you have not evacuated:";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Pay close attention to what is happening in the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndent2Txt);
                    label10.Text = "TV";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndent2Txt);
                    label11.Text = "Facebook";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndent2Txt);
                    label12.Text = "Radio";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndent2Txt);
                    label13.Text = "WhatsApp";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "-Have your things ready to evacuate, some of the things you should consider include in your bag are:";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelIndent2Txt);
                    label15.Text = "Important documents";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndent2Txt);
                    label16.Text = "Phones and phone chargers";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndent2Txt);
                    label17.Text = "Granola bars and other food";
                    residentInfo.Children.Add(label17);
                    Label label18 = new Label().LoadFromXaml(labelIndent2Txt);
                    label18.Text = "Flash lights";
                    residentInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndent2Txt);
                    label19.Text = "Portable radio";
                    residentInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndent2Txt);
                    label20.Text = "Money";
                    residentInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndent2Txt);
                    label21.Text = "Medicine";
                    residentInfo.Children.Add(label21);
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
            //Visitor
            switch (App.Lang)
            {
                case "e":
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Avoid areas of risk, which you can view on the landslide risk map in the previous page";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are a homestay, pay close attention to your family’s and institution’s instructions";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are in a hotel, pay close attention to what staff members in the hotels you are staying at are saying ";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are staying in an Airbnb, talk to your landowner:";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelTxt);
                    label7.Text = "";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "";
                    residentInfo.Children.Add(label8);
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