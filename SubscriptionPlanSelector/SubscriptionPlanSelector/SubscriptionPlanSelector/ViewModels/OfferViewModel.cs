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
        private Command<int> _OnOfferTapped { get; set; }

        public List<Offer> Offers { get; set; } = new List<Offer>
        {
            new Offer("ProOffer", "ProText.png", "100", "1000", "1000"),
            new Offer("BasicOffer","BasicText.png", "50", "500", "300"),
            new Offer("FreeOffer", "FreeText.png", "0", "5", "50"),
        };

        public Command<int> OnOfferTapped
        {
            get
            {
                return _OnOfferTapped ?? (_OnOfferTapped = new Command<int>((id) =>
                {
                    Application.Current.MainPage.DisplayAlert("Selected Peron", "Person id : " + id.ToString(), "Ok");
                }));
            }
        }
    }
}
