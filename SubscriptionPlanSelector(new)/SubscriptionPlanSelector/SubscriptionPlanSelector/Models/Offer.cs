using System;
using System.Collections.Generic;
using System.Data;
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
        public string Name { get; set; }
        public string Price { get; set; }
        

        public Offer(string name, string icon, string scalability, string storage, string speed, string price)
        {
            this.Icon = icon;
            this.Scalability = scalability;
            this.Storage = storage;
            this.Speed = speed;
            this.Name = name;
            this.Price = price;
        }
    }
}
