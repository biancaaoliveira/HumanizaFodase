using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plano3 : ContentPage
    {
        public static List<string> ls3;

        public Plano3()
        {
            InitializeComponent();
            ls3 = new List<string>();
        }

        private async void Plano4_Clicked(object sender, EventArgs e)
        {

            string txt;
            ls3.Clear();
            if (chk1.Checked)
            {
                txt = chk1.Text;
                ls3.Add(txt);
            }
            if (chk2.Checked)
            {
                txt = chk2.Text;
                ls3.Add(txt);
            }
            if (chk3.Checked)
            {
                txt = chk3.Text;
                ls3.Add(txt);
            }
            if (chk4.Checked)
            {
                txt = chk4.Text;
                ls3.Add(txt);
            }
           

            await Navigation.PushAsync(new Plano4());
        }
    }
}