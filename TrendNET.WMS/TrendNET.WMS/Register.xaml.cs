using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrendNET.WMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegistration(object sender, EventArgs e)
        {
            DisplayAlert("Prijava", "Uspesna prijava", "Odjava");        
        }

        
    }
}