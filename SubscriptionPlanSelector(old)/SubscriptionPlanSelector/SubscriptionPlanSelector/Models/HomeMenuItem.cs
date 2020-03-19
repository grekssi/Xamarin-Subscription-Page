using System;
using System.Collections.Generic;
using System.Text;

namespace SubscriptionPlanSelector.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Subscribe
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
