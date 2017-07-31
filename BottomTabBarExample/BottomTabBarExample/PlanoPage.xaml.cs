using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BottomTabBarExample.Classes;


namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanoPage : ContentPage
    {
        public PlanoPage()
        {
            InitializeComponent();
            
        }
       
        private async void Plano1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Plano1());
        }
    }
}