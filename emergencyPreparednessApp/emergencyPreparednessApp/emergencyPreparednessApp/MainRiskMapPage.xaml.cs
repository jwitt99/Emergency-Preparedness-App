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
            App.Emergency = ((Button)sender).StyleId;
            await Navigation.PushAsync(new NaturalDisaster());
        }
        private async void RiskButton_OnClicked(object sender, EventArgs e)
        {
            App.Emergency = ((Button)sender).StyleId;
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
            switch (App.Loc) {
                case "monteVerde":
                    img.Source = "monteVerde";
                    break;
                case "cerroPlano":
                    img.Source = "cerroPlano";
                    break;
                case "santaElena":
                    img.Source = "santaElena";
                    break;
                case "sanLuis":
                    img.Source = "sanLuis";
                    break;
                default:
                    break;
            }

            switch (App.Lang)
            {
                case "e":
                    risks.Text = "Risks";
                    landslide.Text = "landslide";
                    flood.Text = "flood";
                    fire.Text = "fire";
                    naturalDisasters.Text = "Natural Disasters";
                    tropicalStorm.Text = "Tropical Storm";
                    earthquake.Text = "Earthquake";
                    volcanicActivity.Text = "Secondary Effects from Volcanic Activity";
                    changeLang.Text = "Change Language";
                    changeLoc.Text = "Change Location";
                    contactInfo.Text = "Contact info";
                    break;
                case "s":
                    risks.Text = "Spanish risks";
                    landslide.Text = "Spanish landslide";
                    flood.Text = "Spanish flood";
                    fire.Text = "Spanish fire";
                    naturalDisasters.Text = "Spanish naturalDisasters";
                    tropicalStorm.Text = "Spanish tropicalStorm";
                    earthquake.Text = "Spanish earthquake";
                    volcanicActivity.Text = "Spanish Secondary Effects from Volcanic Activity";
                    changeLang.Text = "Spanish changeLang";
                    changeLoc.Text = "Spanish changeLoc";
                    contactInfo.Text = "Spanish contact info";
                    break;
                case "f":
                    risks.Text = "Risques";
                    landslide.Text = "Glissement de terre";
                    flood.Text = "Inondation";
                    fire.Text = "Feu";
                    naturalDisasters.Text = "Catastrophes Naturelles";
                    tropicalStorm.Text = "Tempête tropical";
                    earthquake.Text = "Tremblement de terre";
                    volcanicActivity.Text = "Effets secondaire d’activité volcanique";
                    changeLang.Text = "Changez de langue";
                    changeLoc.Text = "Changez de lieu";
                    contactInfo.Text = "Coordonnées";
                    break;
                case "g":
                    risks.Text = "German risks";
                    landslide.Text = "German landslide";
                    flood.Text = "German flood";
                    fire.Text = "German fire";
                    naturalDisasters.Text = "German naturalDisasters";
                    tropicalStorm.Text = "German tropicalStorm";
                    earthquake.Text = "German earthquake";
                    volcanicActivity.Text = "German Secondary Effects from Volcanic Activity";
                    changeLang.Text = "German changeLang";
                    changeLoc.Text = "German changeLoc";
                    contactInfo.Text = "German contact info";
                    break;
                default:
                    risks.Text = "Something broke";
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