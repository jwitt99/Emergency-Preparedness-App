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
    public partial class MainRiskMapPage : ContentPage
    {
        public MainRiskMapPage()
        {
            InitializeComponent();
        }

        private async void NatDisButton_OnClicked(object sender, EventArgs e)
        {
            App.NaturalDisaster = ((Button)sender).StyleId;
            await Navigation.PushAsync(new NaturalDisaster());
        }
        private async void RiskButton_OnClicked(object sender, EventArgs e)
        {
            App.Risk = ((Button)sender).StyleId;
            await Navigation.PushAsync(new Risk());
        }

        private async void ContactInfoButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactInfo());
        }
        private async void RegionButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LocationPage());
        }

        private async void LanguageButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            switch (App.Lang)
            {
                case "e":
                    label1.Text = "Risks";
                    landslide.Text = "landslide";
                    flood.Text = "flood";
                    fire.Text = "fire";
                    label2.Text = "Natural Disasters";
                    tropicalStorm.Text = "Tropical Storm";
                    earthquake.Text = "Earthquake";
                    volcanicActivity.Text = "Secondary Effects from Volcanic Activity";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    contactInfo.Text = "Contact info";
                    break;
                case "s":
                    label1.Text = "Spanish label1";
                    landslide.Text = "Spanish landslide";
                    flood.Text = "Spanish flood";
                    fire.Text = "Spanish fire";
                    label2.Text = "Spanish label2";
                    tropicalStorm.Text = "Spanish tropicalStorm";
                    earthquake.Text = "Spanish earthquake";
                    volcanicActivity.Text = "Spanish Secondary Effects from Volcanic Activity";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    label1.Text = "French label1";
                    landslide.Text = "French landslide";
                    flood.Text = "French flood";
                    fire.Text = "French fire";
                    label2.Text = "French label2";
                    tropicalStorm.Text = "French tropicalStorm";
                    earthquake.Text = "French earthquake";
                    volcanicActivity.Text = "French Secondary Effects from Volcanic Activity";
                    changeLang.Text = "French changeLang";
                    changeLoc.Text = "French changeLoc";
                    contactInfo.Text = "French contact info";
                    break;
                case "g":
                    label1.Text = "German label1";
                    landslide.Text = "German landslide";
                    flood.Text = "German flood";
                    fire.Text = "German fire";
                    label2.Text = "German label2";
                    tropicalStorm.Text = "German tropicalStorm";
                    earthquake.Text = "German earthquake";
                    volcanicActivity.Text = "German Secondary Effects from Volcanic Activity";
                    changeLang.Text = "German changeLang";
                    changeLoc.Text = "German changeLoc";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    label1.Text = "Something broke";
                    break;
            }
        }

        public class ZoomImage : Image
        {
            private const double MIN_SCALE = 1;
            private const double MAX_SCALE = 4;
            private const double OVERSHOOT = 0.15;
            private double StartScale;
            private double LastX, LastY;

            public ZoomImage()
            {
                var pinch = new PinchGestureRecognizer();
                pinch.PinchUpdated += OnPinchUpdated;
                GestureRecognizers.Add(pinch);

                var pan = new PanGestureRecognizer();
                pan.PanUpdated += OnPanUpdated;
                GestureRecognizers.Add(pan);

                var tap = new TapGestureRecognizer { NumberOfTapsRequired = 2 };
                tap.Tapped += OnTapped;
                GestureRecognizers.Add(tap);

                Scale = MIN_SCALE;
                TranslationX = TranslationY = 0;
                AnchorX = AnchorY = 0;
            }

            protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
            {
                Scale = MIN_SCALE;
                TranslationX = TranslationY = 0;
                AnchorX = AnchorY = 0;
                return base.OnMeasure(widthConstraint, heightConstraint);
            }

            private void OnTapped(object sender, EventArgs e)
            {
                if (Scale > MIN_SCALE)
                {
                    this.ScaleTo(MIN_SCALE, 250, Easing.CubicInOut);
                    this.TranslateTo(0, 0, 250, Easing.CubicInOut);
                }
                else
                {
                    AnchorX = AnchorY = 0.5; //TODO tapped position
                    this.ScaleTo(MAX_SCALE, 250, Easing.CubicInOut);
                }
            }

            private void OnPanUpdated(object sender, PanUpdatedEventArgs e)
            {
                if (Scale > MIN_SCALE)
                    switch (e.StatusType)
                    {
                        case GestureStatus.Started:
                            LastX = TranslationX;
                            LastY = TranslationY;
                            break;
                        case GestureStatus.Running:
                            TranslationX = Clamp(LastX + e.TotalX * Scale, -Width / 2, Width / 2);
                            TranslationY = Clamp(LastY + e.TotalY * Scale, -Height / 2, Height / 2);
                            break;
                    }
            }

            private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
            {
                switch (e.Status)
                {
                    case GestureStatus.Started:
                        StartScale = Scale;
                        AnchorX = e.ScaleOrigin.X;
                        AnchorY = e.ScaleOrigin.Y;
                        break;
                    case GestureStatus.Running:
                        double current = Scale + (e.Scale - 1) * StartScale;
                        Scale = Clamp(current, MIN_SCALE * (1 - OVERSHOOT), MAX_SCALE * (1 + OVERSHOOT));
                        break;
                    case GestureStatus.Completed:
                        if (Scale > MAX_SCALE)
                            this.ScaleTo(MAX_SCALE, 250, Easing.SpringOut);
                        else if (Scale < MIN_SCALE)
                            this.ScaleTo(MIN_SCALE, 250, Easing.SpringOut);
                        break;
                }
            }

            private T Clamp<T>(T value, T minimum, T maximum) where T : IComparable
            {
                if (value.CompareTo(minimum) < 0)
                    return minimum;
                else if (value.CompareTo(maximum) > 0)
                    return maximum;
                else
                    return value;
            }
        }
    }
}