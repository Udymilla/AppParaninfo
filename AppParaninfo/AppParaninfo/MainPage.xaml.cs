using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppParaninfo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SIM());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = DisplayAlert("OPÇÃO INDISPOVIVEL", " Somos obrigados a fazer suas provas, então você tambem não tem escolha <3 ", "ok?");
        }
    }
}
