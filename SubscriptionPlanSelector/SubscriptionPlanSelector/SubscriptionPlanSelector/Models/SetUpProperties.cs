using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlanSelector.Models
{
    class SetUpProperties
    {
        public static SubscriptionTypeModels[]  GetModels()
        {
            return new[]
            {
                new SubscriptionTypeModels("Pro",
                    new[]
                    {
                        new KeyValuePair<string, double>("Scalability", 100),
                        new KeyValuePair<string, double>("Storage", 1000),
                        new KeyValuePair<string, double>("Speed", 1000),
                    }),
                new SubscriptionTypeModels("Basic",
                    new[]
                    {
                        new KeyValuePair<string, double>("Scalability", 50),
                        new KeyValuePair<string, double>("Storage", 500),
                        new KeyValuePair<string, double>("Speed", 100),
                    }),
                
                new SubscriptionTypeModels("Free",
                    new[]
                    {
                        new KeyValuePair<string, double>("Scalability", 0),
                        new KeyValuePair<string, double>("Storage", 5),
                        new KeyValuePair<string, double>("Speed", 10),
                    }),
            };
        }
    }
}
