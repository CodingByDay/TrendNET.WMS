using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendNET.WMS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Here we define a GreetPage on click method :)
            MainPage = new GreetPage();
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
