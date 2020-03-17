using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlanSelector.Models
{
    public sealed class SubscriptionTypeModels
    {
        public string Name { get; set; }
        public KeyValuePair<string, double>[] Properties { get; set; } 

        public SubscriptionTypeModels(string name, KeyValuePair<string, double>[] properties)
        {
            Name = Name;
            Properties = properties;
        }
    }
}
