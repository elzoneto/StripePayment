using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StripePayment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new StripePaymentGatwayPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
