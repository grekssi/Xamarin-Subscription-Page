using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubscriptionPlanSelector.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SubscriptionPlanSelector.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferPage : ContentPage
    {
        public OfferPage()
        {
            InitializeComponent();
            this.BindingContext = new OfferViewModel();
        }
    }
}