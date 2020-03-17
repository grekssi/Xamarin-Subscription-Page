using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Input;
using SubscriptionPlanSelector.Models;
using Xamarin.Forms;

namespace SubscriptionPlanSelector.ViewModels
{
    class SubscriptionPageViewModel
    {
        private static ushort counter = 0;
        private static ushort propertiesCounter = 0;
        private static short concurrentCounter = 0;

        private static SubscriptionTypeModels[] properties = SetUpProperties.GetModels(); 
        

        public string Type
        {
            get
            {
                CheckCounters();
                concurrentCounter++;
                string prop = properties[counter].Properties[propertiesCounter++].Key;
                return prop;
            }
        }

        public string TypeValue
        {
            get
            {
                CheckCounters();
                string prop = properties[counter].Properties[propertiesCounter].Value
                    .ToString(CultureInfo.InvariantCulture);
                return prop;
            }
        }

        private void CheckCounters()
        {
            if (propertiesCounter == 3) propertiesCounter = 0;
            if (concurrentCounter == 3)
            {
                counter++;
                concurrentCounter = 0;
            }
        }
    }
}
