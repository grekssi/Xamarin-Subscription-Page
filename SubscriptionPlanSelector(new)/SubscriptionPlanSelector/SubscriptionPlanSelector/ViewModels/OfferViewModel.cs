using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using SubscriptionPlanSelector.Models;
using Xamarin.Forms;

namespace SubscriptionPlanSelector.ViewModels
{
    public sealed class OfferViewModel
    {
        private Command<string> _OnOfferTapped { get; set; }

        public List<Offer> Offers { get; set; } = new List<Offer>
        {
            new Offer("ProOffer", "ProText.png", "100", "1000", "1000", "39.99"),
            new Offer("BasicOffer","BasicText.png", "50", "500", "300", "19.99"),
            new Offer("FreeOffer", "FreeText.png", "0", "5", "50", "0.00"),
        };

        public Command<string> OnOfferTapped
        {
            get
            {
                return _OnOfferTapped ?? (_OnOfferTapped = new Command<string>((name) =>
                {
                    Application.Current.MainPage.DisplayAlert("Selected Offer", "Offer Name: " + name, "Ok");
                    
                }));
            }
        }
    }
}
