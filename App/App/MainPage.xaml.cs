using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void ButtonLogin_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Profile());
            //throw new NotImplementedException();
        }
    }
}