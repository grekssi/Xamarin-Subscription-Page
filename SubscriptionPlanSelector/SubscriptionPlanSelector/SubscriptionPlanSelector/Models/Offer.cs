using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Text;
using Xamarin.Forms;

namespace SubscriptionPlanSelector.Models
{
    public sealed class Offer
    {
        public string Icon { get; set; }
        public string Scalability { get; set; }
        public string Storage { get; set; }
        public string Speed { get; set; }
        

        public Offer(string icon, string scalability, string storage, string speed)
        {
            this.Icon = icon;
            this.Scalability = scalability;
            this.Storage = storage;
            this.Speed = speed;
        }
    }
}
