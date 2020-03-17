using System;
using System.Collections.Generic;
using System.Text;
using SubscriptionPlanSelector.Models;

namespace SubscriptionPlanSelector.ViewModels
{
    public sealed class OfferViewModel
    {
        public List<Offer> Offers { get; set; } = new List<Offer>
        {
            new Offer("ProText.png", "100", "1000", "1000"),
            new Offer("BasicText.png", "50", "500", "300"),
            new Offer("FreeText.png", "0", "5", "50"),
        };
    }
}
