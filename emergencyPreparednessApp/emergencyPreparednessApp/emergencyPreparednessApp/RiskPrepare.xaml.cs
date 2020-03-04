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
                    intro.Text = "Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared";
                    btnPrepare.Text = "How do you prepare?";
                    btnResident.Text = "Resident";
                    btnVisitor.Text = "Visitor";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    contactInfo.Text = "Contact info";
                    break;
                case "s":
                    intro.Text = "SPanish Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared";
                    btnPrepare.Text = "Spanish How do you prepare?";
                    btnResident.Text = "Spanish btnResident";
                    btnVisitor.Text = "Spanish btnVisitor";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    intro.Text = "French Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared";
                    btnPrepare.Text = "French How do you prepare?";
                    btnResident.Text = "French btnResident";
                    btnVisitor.Text = "French btnVisitor";
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    intro.Text = "German Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared";
                    btnPrepare.Text = "German How do you prepare?";
                    btnResident.Text = "German btnResident";
                    btnVisitor.Text = "German btnVisitor";
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
                    DisplayAlert("something went wrong", "Yes", "yes");
                    break;
            }
        }

        string labelTxt = "<Label FontSize=\"20\" Margin=\"10,0,0,20\"/>";
        string labelIndentTxt = "<Label FontSize=\"20\" Margin=\"60,0,0,20\"/>";
        string labelIndent2Txt = "<Label FontSize=\"20\" Margin=\"120,0,0,20\"/>";
        private void landslideText()
        {
            //Resident
            switch (App.Lang)
            {
                case "e":
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Check if you live in an area of risk ";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "Be familiar with the level  of risk in your area. You can view a landslide risk map in the previous page.";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "TV";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "Facebook";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Radio";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "WhatsApp";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "Have a preparedness kit - here are some of our recommendations for its contents";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Emergency Heat Blankets ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Portable Radio";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Batteries ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "-Flash Light/Candles/Matches ";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndentTxt);
                    label13.Text = "-Multitool ";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "-Solar Panel Phone Charger ";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Make sure you know where the following are: ";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "-Important Documents ";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndentTxt);
                    label17.Text = "-Emergency Contacts ";
                    residentInfo.Children.Add(label17);
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
                    label1.Text = "If you are a homestay, show your family the “How to Prepare” section for residents";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are staying in an Airbnb, talk to your landowner";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it";
                    visitorInfo.Children.Add(label5);
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
            //Resident
            switch (App.Lang)
            {
                case "e":
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "TV";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "Facebook";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Radio";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "WhatsApp";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "Have a preparedness kit - here are some of our recommendations for its contents";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Emergency Heat Blankets ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Portable Radio";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Batteries ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "-Flash Light/Candles/Matches ";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndentTxt);
                    label13.Text = "-Multitool ";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "-Solar Panel Phone Charger ";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Make sure you know where the following are: ";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "-Important Documents ";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndentTxt);
                    label17.Text = "-Emergency Contacts ";
                    residentInfo.Children.Add(label17);
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
                    label1.Text = "If you are a homestay, show your family the “How to Prepare” section for residents";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are staying in an Airbnb, talk to your landowner";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it";
                    visitorInfo.Children.Add(label5);
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
            //Resident 
            switch (App.Lang)
            {
                case "e":
                    intro.Text = "Every second counts during a fire. In order to reduce the risks you could face in case of an emergency, please read our following recommendations:";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Keep doorways clear - allow for quick evacuation ";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "Talk to your family members, particularly children about fire safety and the steps they should follow during these emergencies";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Save the firefighter’s number on your phone for quick access: 2645-7512";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "Practice safe cooking habits";
                    residentInfo.Children.Add(label4);
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
                    label1.Text = "Keep doorways clear - allow for quick evacuation ";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "Talk to your family members, particularly children about fire safety and the steps they should follow during these emergencies";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Save the firefighter’s number on your phone for quick access: 2645-7512";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "Practice safe cooking habits";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "If you are a homestay, show your family the “How to Prepare” section  for residents";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    visitorInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelTxt);
                    label7.Text = "If you are staying in an Airbnb, talk to your landowner";
                    visitorInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelIndentTxt);
                    label8.Text = "Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "If they say no, tell the landowner that there is an emergency plan in place and that they should look into it ";
                    visitorInfo.Children.Add(label9);
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
            //Resident 
            switch (App.Lang)
            {
                case "e":
                    intro.Text = "Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared:";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Check if you live in an area of risk ";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-TV";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Facebook";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-Radio";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "-WhatsApp";
                    residentInfo.Children.Add(label6);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "Have a preparedness kit - here are some of our recommendations for its contents";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Emergency Heat Blankets ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Portable Radio";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Batteries ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "-Flash Light/Candles/Matches ";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndentTxt);
                    label13.Text = "-Multitool ";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "-Solar Panel Phone Charger ";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Have additional storage of: ";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "Food and Water";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndent2Txt);
                    label17.Text = "-Have additional canned food ";
                    residentInfo.Children.Add(label17);
                    Label label18 = new Label().LoadFromXaml(labelIndent2Txt);
                    label18.Text = "-Extra water - Fun Fact: people need to drink around 3.8 liters of water every day.";
                    residentInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "Medicine - if possible have extra medicine ";
                    residentInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndent2Txt);
                    label20.Text = "-Have a First-Aid Kit ";
                    residentInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "If you have pets ";
                    residentInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelIndent2Txt);
                    label22.Text = "-If possible have back-up food and medication if applicable ";
                    residentInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndent2Txt);
                    label23.Text = "-When calculating your water rations, take your pets into account!";
                    residentInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelTxt);
                    label24.Text = "Make sure you know where the following are: ";
                    residentInfo.Children.Add(label24);
                    Label label25 = new Label().LoadFromXaml(labelIndentTxt );
                    label25.Text = "-Important Documents ";
                    residentInfo.Children.Add(label25);
                    Label label26 = new Label().LoadFromXaml(labelIndentTxt);
                    label26.Text = "-Emergency Contacts ";
                    residentInfo.Children.Add(label26);
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
                    label1.Text = "If you are a homestay, show your family the “How to Prepare” section  for residents.";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are staying in an Airbnb, talk to your landowner";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Ask them if they have an emergency plan ";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it   ";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "";
                    residentInfo.Children.Add(label6);

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
            //Resident
            switch (App.Lang)
            {
                case "e":
                    intro.Text = "Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared:";
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "TV";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "Facebook";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Radio";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "WhatsApp";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "Have a preparedness kit - here are some of our recommendations for its contents";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Emergency Heat Blankets ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Portable Radio";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Batteries ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "-Flash Light/Candles/Matches ";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndentTxt);
                    label13.Text = "-Multitool ";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "-Solar Panel Phone Charger ";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Make sure you know where the following are: ";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "-Important Documents ";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndentTxt);
                    label17.Text = "-Emergency Contacts ";
                    residentInfo.Children.Add(label17);
                    Label label30 = new Label().LoadFromXaml(labelTxt);
                    label30.Text = "Have additional storage of: ";
                    residentInfo.Children.Add(label30);
                    Label label31 = new Label().LoadFromXaml(labelIndentTxt);
                    label31.Text = "Food and Water";
                    residentInfo.Children.Add(label31);
                    Label label32 = new Label().LoadFromXaml(labelIndent2Txt);
                    label32.Text = "-Have additional canned food ";
                    residentInfo.Children.Add(label32);
                    Label label18 = new Label().LoadFromXaml(labelIndent2Txt);
                    label18.Text = "-Extra water - Fun Fact: people need to drink around 3.8 liters of water every day.";
                    residentInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "Medicine - if possible have extra medicine ";
                    residentInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndent2Txt);
                    label20.Text = "-Have a First-Aid Kit ";
                    residentInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "If you have pets ";
                    residentInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelIndent2Txt);
                    label22.Text = "-If possible have back-up food and medication if applicable ";
                    residentInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndent2Txt);
                    label23.Text = "-When calculating your water rations, take your pets into account!";
                    residentInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelTxt);
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
                    label1.Text = "If you are a homestay, show your family the “How to Prepare” section for residents";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are staying in an Airbnb, talk to your landowner";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it";
                    visitorInfo.Children.Add(label5);
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
            //Resident
            switch (App.Lang)
            {
                case "e":
                    intro.Text = "Even if there are currently no signs that this disaster might happen, it is important to lower the risks, therefore, please read through our recommendations for how to be prepared:";
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "TV";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "Facebook";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Radio";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "WhatsApp";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "When organizing shelves, put heavier objects at the bottom";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelTxt);
                    label9.Text = "If possible, try to tie or nail heavy objects (TVs, fridges, and shelves) to the wall";
                    residentInfo.Children.Add(label9);
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
                    label1.Text = "If you are a homestay, show your family the “How to Prepare” section for residents";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are staying in a hotel, make sure you pay attention to any information given to you by the staff";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are staying in an Airbnb, talk to your landowner";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it";
                    visitorInfo.Children.Add(label5);
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