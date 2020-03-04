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
    public partial class RiskWhatDo : ContentPage
    {
        public RiskWhatDo()
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
                    btnWhatDo.Text = "What do you do?";
                    btnResident.Text = "Resident";
                    btnVisitor.Text = "Visitor";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    contactInfo.Text = "Contact info";
                    break;
                case "s":
                    btnWhatDo.Text = "Spanish What do you do?";
                    btnResident.Text = "Spanish btnResident";
                    btnVisitor.Text = "Spanish btnVisitor";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    btnWhatDo.Text = "French What do you do?";
                    btnResident.Text = "French btnResident";
                    btnVisitor.Text = "French btnVisitor";
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    btnWhatDo.Text = "German What do you do?";
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
                    intro.Text = "If there is a tropical storm/heavy rain or an earthquake occurs, please follow these instructions:";

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
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are a homestay, pay close attention to your family’s and institution’s instructions";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are in a hotel, pay close attention to what staff members in the hotels you are staying at are saying ";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are staying in an Airbnb, talk to your landowner:";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it ";
                    visitorInfo.Children.Add(label6);
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
                //Resident
                case "e":
                    intro.Text = "If you live close to a river and there have been heavy rains (or normal rain that lasts for more than six hours) please follow these instructions:";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Stay informed with the status of storms and other natural disasters, as well as the change in levels of risk through the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-TV";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-Facebook";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Radio";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-WhatsApp";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "Have your things ready to evacuate, some of the things you should consider including in your bag are: ";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "-Important documents ";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelIndentTxt);
                    label8.Text = "-Phones and phone chargers ";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndentTxt);
                    label9.Text = "-Granola bars and other food ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Flash lights ";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Portable radio ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "Money ";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelTxt);
                    label13.Text = "Turn off the electricity of your home ";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelTxt);
                    label14.Text = "Disconnect all appliances ";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Evacuation:";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "-If there is an official evacuation order, go to the Monteverde Institute or the Friends School depending on your area ";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelIndentTxt);
                    label17.Text = "-If there has not been an official order of evacuation, stay in the home of a friend or family member who is outside the area of risk";
                    residentInfo.Children.Add(label17);
                    Label label18 = new Label().LoadFromXaml(labelTxt);
                    label18.Text = "REMEMBER";
                    residentInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "If you have to cross water, make sure it is not moving and shallow, use a stick to check the depth and be careful not to slip";
                    residentInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndentTxt);
                    label20.Text = "Avoid fallen power lines, especially the water touching them, to prevent electrocution";
                    residentInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "If you get swept away:";
                    residentInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelIndent2Txt);
                    label22.Text = "-Always go over obstacles and never go under";
                    residentInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndent2Txt);
                    label23.Text = "-Floating backwards (facing upstream) slightly on your back will help you push debris flowing downstream towards you";
                    residentInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelIndent2Txt);
                    label24.Text = "-Point your feet downstream once you get a good grip on something and yell for help";
                    residentInfo.Children.Add(label24);
                    Label label25 = new Label().LoadFromXaml(labelTxt);
                    label25.Text = "After the emergency ";
                    residentInfo.Children.Add(label25);
                    Label label26 = new Label().LoadFromXaml(labelIndentTxt);
                    label26.Text = "-Do not return to your home until the police says it is safe ";
                    residentInfo.Children.Add(label26);
                    Label label27 = new Label().LoadFromXaml(labelIndentTxt);
                    label27.Text = "-If you smell gas or hear a hissing noise, evacuate immediately and call the firefighters";
                    residentInfo.Children.Add(label27);
                    Label label28 = new Label().LoadFromXaml(labelIndentTxt);
                    label28.Text = "-Throw away any type of food that might have gotten in contact with water ";
                    residentInfo.Children.Add(label28);
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
                    label1.Text = "If you are a homestay, pay close attention to your family’s and institution’s instructions.";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you live in a hotel, pay close attention to what staff members in the hotels you are staying at are saying";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you live in an Airbnb that is close to a river, call your landowner and ask them if there is an emergency plan in place";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "If they say no, tell the landowner that there is an emergency plan in place and that they should look into it";
                    Label label18 = new Label().LoadFromXaml(labelTxt);
                    label18.Text = "REMEMBER";
                    visitorInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "If you have to cross water, make sure it is not moving and shallow, use a stick to check the depth and be careful not to slip";
                    visitorInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndentTxt);
                    label20.Text = "Avoid fallen power lines, especially the water touching them, to prevent electrocution";
                    visitorInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "If you get swept away:";
                    visitorInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelIndent2Txt);
                    label22.Text = "-Always go over obstacles and never go under";
                    visitorInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndent2Txt);
                    label23.Text = "-Floating backwards (facing upstream) slightly on your back will help you push debris flowing downstream towards you";
                    visitorInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelIndent2Txt);
                    label24.Text = "-Point your feet downstream once you get a good grip on something and yell for help";
                    visitorInfo.Children.Add(label24);
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
                    intro.Text = "If you see black smoke or detect an intense burning smell, you should immediately take action";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "If the fire is small:";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-If it is an electric fire (caused by cables or some other sort of electricity) you can use baking soda to attempt to put it out.";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-Never use water, there is a high possibility if being electrocuted";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-If it is a fire caused while cooking, turn everything off and try to put a metal lid on the pan being used";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndent2Txt);
                    label5.Text = "You can also use a thick, inflamable blanket to try to put out the fire";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "If the fire is big:";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "-NEVER GET IN THE SHOWER";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelIndent2Txt);
                    label8.Text = "During fires, the plumbing melts and prohibits water from flowing ";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndent2Txt);
                    label9.Text = "Evacuation should always be your priority ";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Evacuate immediately with your family to an area far away from trees and other combustible structuctures ";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Once you have evacuated, call the firefighters: 2645-7512";
                    residentInfo.Children.Add(label11);
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
                    intro.Text = "If you see black smoke or detect an intense burning smell, you should immediately take action";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "If the fire is small:";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-If it is an electric fire (caused by cables or some other sort of electricity) you can use baking soda to attempt to put it out.";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-Never use water, there is a high possibility if being electrocuted";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-If it is a fire caused while cooking, turn everything off and try to put a metal lid on the pan being used";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndent2Txt);
                    label5.Text = "You can also use a thick, inflamable blanket to try to put out the fire";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "If the fire is big:";
                    visitorInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "-NEVER GET IN THE SHOWER";
                    visitorInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelIndent2Txt);
                    label8.Text = "During fires, the plumbing melts and prohibits water from flowing ";
                    visitorInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelIndent2Txt);
                    label9.Text = "Evacuation should always be your priority ";
                    visitorInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "-Evacuate immediately with your family to an area far away from trees and other combustible structuctures ";
                    visitorInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "-Once you have evacuated, if possible let your hosts know, if not call the firefighters: 2645-7512";
                    visitorInfo.Children.Add(label11);
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
                    intro.Text = "If you hear there might be the possibility of a tropical storm in your area, please follow these steps: ";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Evacuate if";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-The CNE announces a Red Alert ";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-You live in a high risk area and you hear there is a high possibility of: a tropical storm. You are in a high risk area if your house is very close to a river or you are inside a landslide risk area (you can view the landslide risk map under Risks -> Landslides)";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "-Do Not Forget Your Pets! If you have time, make sure they are safe as well ";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "Where to evacuate?";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "If there is a Red Alert or the police force has asked you to evacuate, go to the Monteverde Institute or the Friends School depending on your area ";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "If there has not been an official order of evacuation, stay in the home of a friend or family member who is outside the area of risk";
                    residentInfo.Children.Add(label7);
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
                    Label label14 = new Label().LoadFromXaml(labelIndent2Txt);
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
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If you are a homestay, pay close attention to your family’s and institution’s instructions";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are in a hotel, pay close attention to what staff members in the hotels you are staying at are saying ";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are staying in an Airbnb, talk to your landowner:";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it ";
                    visitorInfo.Children.Add(label6);
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
        private void volcanoText()
        {
            //Resident
            switch (App.Lang)
            {
                case "e":
                    intro.Text = "If you hear that a volcano in Costa Rica has erupted, follow these instructions: ";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "Pay close attention to what is happening in the news and social media. Some of the best methods for staying informed are: ";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelIndentTxt);
                    label2.Text = "-TV";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelIndentTxt);
                    label3.Text = "-Facebook";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelIndentTxt);
                    label4.Text = "Radio";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "WhatsApp";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelTxt);
                    label6.Text = "If you hear there is a chance ashes will reach Monteverde, do the following: ";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelTxt);
                    label7.Text = "Close all doors and windows in your home.";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "Turn off heaters, air conditioners, and driers. ";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelTxt);
                    label9.Text = "Avoid driving - the ashes can hurt your car’s motor";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "If possible protect cars by covering them up or parking them inside. ";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelTxt);
                    label11.Text = "If you have pets or cattle: ";
                    residentInfo.Children.Add(label11);
                    Label label12 = new Label().LoadFromXaml(labelIndentTxt);
                    label12.Text = "-Make sure they are all inside your home, barn, or some other type of shelter";
                    residentInfo.Children.Add(label12);
                    Label label13 = new Label().LoadFromXaml(labelIndentTxt);
                    label13.Text = "-The ashes will cover the sun and thus have a high chance of damaging grass and agriculture. Therefore, it is heavily recommended that you have a reserve of food for your cattle";
                    residentInfo.Children.Add(label13);
                    Label label14 = new Label().LoadFromXaml(labelIndentTxt);
                    label14.Text = "Examine your water reserve and make sure it is as filled up as possible.";
                    residentInfo.Children.Add(label14);
                    Label label15 = new Label().LoadFromXaml(labelTxt);
                    label15.Text = "Evacuate if the CNE announces a Red Alert ";
                    residentInfo.Children.Add(label15);
                    Label label16 = new Label().LoadFromXaml(labelIndentTxt);
                    label16.Text = "Do Not Forget Your Pets! If you have time, make sure they are safe as well. ";
                    residentInfo.Children.Add(label16);
                    Label label17 = new Label().LoadFromXaml(labelTxt);
                    label17.Text = "If there is a Red Alert or the police force has asked you to evacuate, go to the Monteverde Institute or the Friends School depending on your area ";
                    residentInfo.Children.Add(label17);
                    Label label18 = new Label().LoadFromXaml(labelTxt);
                    label18.Text = "If you venture outside:";
                    residentInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "-Wear a filtering mask (N-95), or hold a wet rag to your mouth";
                    residentInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndentTxt);
                    label20.Text = "-Use protection glasses, or just weat any sort of glasses";
                    residentInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "-Wear long sleeved shirts, sweaters, and pants";
                    residentInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelTxt);
                    label22.Text = "In order to clean up, here are some tips:";
                    residentInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndentTxt);
                    label23.Text = "-You can clean ashes by damping a cloth in water and sliding the ashes into a trash bag";
                    residentInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelIndentTxt);
                    label24.Text = "Make sure to wear protection while doing this so ash doesn't damage your eyes or lungs";
                    residentInfo.Children.Add(label24);
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
                    label1.Text = "Close all doors and windows in your home";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "If possible turn off heaters, air conditioners, and driers";
                    visitorInfo.Children.Add(label2);
                    Label label100 = new Label().LoadFromXaml(labelTxt);
                    label100.Text = "If you are a homestay, pay close attention to your family’s and institution’s instructions";
                    visitorInfo.Children.Add(label100);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are in a hotel, pay close attention to what staff members in the hotels you are staying at are saying ";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are staying in an Airbnb, talk to your landowner:";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelIndentTxt);
                    label5.Text = "-Ask them if they have an emergency plan ";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "-If they say no, tell the landowner that there is an emergency plan in place and that they should look into it ";
                    visitorInfo.Children.Add(label6);
                    Label label18 = new Label().LoadFromXaml(labelTxt);
                    label18.Text = "If you venture outside:";
                    visitorInfo.Children.Add(label18);
                    Label label19 = new Label().LoadFromXaml(labelIndentTxt);
                    label19.Text = "-Wear a filtering mask (N-95) - if you don't have a mask, a wet rag held to the mouth will do";
                    visitorInfo.Children.Add(label19);
                    Label label20 = new Label().LoadFromXaml(labelIndentTxt);
                    label20.Text = "-Use protection glasses, or just weat any sort of glasses";
                    visitorInfo.Children.Add(label20);
                    Label label21 = new Label().LoadFromXaml(labelIndentTxt);
                    label21.Text = "-Wear Long sleeved shirts, sweaters, and pants";
                    visitorInfo.Children.Add(label21);
                    Label label22 = new Label().LoadFromXaml(labelTxt);
                    label22.Text = "In order to clean up, here are some tips:";
                    visitorInfo.Children.Add(label22);
                    Label label23 = new Label().LoadFromXaml(labelIndentTxt);
                    label23.Text = "-You can clean ashes by damping a cloth in water and sliding the ashes into a trash bag";
                    visitorInfo.Children.Add(label23);
                    Label label24 = new Label().LoadFromXaml(labelIndentTxt);
                    label24.Text = "Make sure to wear protection while doing this so ash doesn't damage your eyes or lungs";
                    visitorInfo.Children.Add(label24);
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
                    intro.Text = "If you experience an earthquake, please follow these instructions: ";
                    Label label1 = new Label().LoadFromXaml(labelTxt);
                    label1.Text = "If possible stay inside - the structures in Monteverde are designed with earthquakes in mind, and there is a higher risk in the outside due to falling trees and debris";
                    residentInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "Cover your head and neck with your arms and try to move to a table or other kind of furniture that can protect you from falling objects - try to stay away from shelves and chandeliers.";
                    residentInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are unable to find a table, get close to a wall with no windows or shelves.";
                    residentInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are in bed, cover your head and neck with your pillow.";
                    residentInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "If you are outside: ";
                    residentInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Cover your head and neck with your arms and move to an area that is as open as possible.";
                    residentInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "There is a high probability for trees, rocks, and other debris in the mountains to become loose during earthquakes so make sure you watch out for that";
                    residentInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "If you are in a car-  stay inside and try to move to an open area.";
                    residentInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelTxt);
                    label9.Text = "After the earthquake:";
                    residentInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "Evacuate your building if it was heavily damaged during the earthquake ";
                    residentInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "Watch out for secondary waves, which can happen soon after an earthquake ";
                    residentInfo.Children.Add(label11);
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
                    label1.Text = "If possible stay inside - the structures in Monteverde are designed with earthquakes in mind, and there is a higher risk in the outside due to falling trees and debris";
                    visitorInfo.Children.Add(label1);
                    Label label2 = new Label().LoadFromXaml(labelTxt);
                    label2.Text = "Cover your head and neck with your arms and try to move to a table or other kind of furniture that can protect you from falling objects - try to stay away from shelves and chandeliers.";
                    visitorInfo.Children.Add(label2);
                    Label label3 = new Label().LoadFromXaml(labelTxt);
                    label3.Text = "If you are unable to find a table, get close to a wall with no windows or shelves.";
                    visitorInfo.Children.Add(label3);
                    Label label4 = new Label().LoadFromXaml(labelTxt);
                    label4.Text = "If you are in bed, cover your head and neck with your pillow.";
                    visitorInfo.Children.Add(label4);
                    Label label5 = new Label().LoadFromXaml(labelTxt);
                    label5.Text = "If you are outside: ";
                    visitorInfo.Children.Add(label5);
                    Label label6 = new Label().LoadFromXaml(labelIndentTxt);
                    label6.Text = "Cover your head and neck with your arms and move to an area that is as open as possible.";
                    visitorInfo.Children.Add(label6);
                    Label label7 = new Label().LoadFromXaml(labelIndentTxt);
                    label7.Text = "There is a high probability for trees, rocks, and other debris in the mountains to become loose during earthquakes so make sure you watch out for that";
                    visitorInfo.Children.Add(label7);
                    Label label8 = new Label().LoadFromXaml(labelTxt);
                    label8.Text = "If you are in a car-  stay inside and try to move to an open area.";
                    visitorInfo.Children.Add(label8);
                    Label label9 = new Label().LoadFromXaml(labelTxt);
                    label9.Text = "After the earthquake:";
                    visitorInfo.Children.Add(label9);
                    Label label10 = new Label().LoadFromXaml(labelIndentTxt);
                    label10.Text = "Evacuate your building if it was heavily damaged during the earthquake ";
                    visitorInfo.Children.Add(label10);
                    Label label11 = new Label().LoadFromXaml(labelIndentTxt);
                    label11.Text = "Watch out for secondary waves, which can happen soon after an earthquake ";
                    visitorInfo.Children.Add(label11);
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