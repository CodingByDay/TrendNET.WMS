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
            // So the main page here will be a Register method () ;)
            MainPage = new Register(); // Commmmmeeeeeeennnnttttttt
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
