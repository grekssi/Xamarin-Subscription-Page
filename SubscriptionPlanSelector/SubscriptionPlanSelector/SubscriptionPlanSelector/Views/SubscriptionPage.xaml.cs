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
    public partial class SubscriptionPage : ContentPage
    {
        async void FreeOptionInitializer(object sender, EventArgs args)
        {
            await freeFrame.ScaleTo(1.2, 50);
            await freeFrame.ScaleTo(1, 50);
            
        }

        public SubscriptionPage()
        {
            InitializeComponent();

            this.BindingContext = new SubscriptionPageViewModel();

            Initialize();
        }

        public async void Initialize()
        {
            await proFrame.FadeTo(1, 2000);
            await basicFrame.FadeTo(1, 800);
            await freeFrame.FadeTo(1, 800);
        }

    }
}