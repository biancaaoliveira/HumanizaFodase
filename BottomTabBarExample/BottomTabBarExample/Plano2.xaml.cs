using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plano2 : ContentPage
    {

        public static List<string> ls2;

        public Plano2()
        {
            InitializeComponent();
            ls2 = new List<string>();
        }
        private async void Plano3_Clicked(object sender, EventArgs e)
        {
            string txt;
            ls2.Clear();
            if (chk1.Checked)
            {
                txt = chk1.Text;
                ls2.Add(txt);
            }
            if (chk2.Checked)
            {
                txt = chk2.Text;
                ls2.Add(txt);
            }
            if (chk3.Checked)
            {
                txt = chk3.Text;
                ls2.Add(txt);
            }
            if (chk4.Checked)
            {
                txt = chk4.Text;
                ls2.Add(txt);
            }
            if (chk5.Checked)
            {
                txt = chk5.Text;
                ls2.Add(txt);
            }
            if (chk6.Checked)
            {
                txt = chk6.Text;
                ls2.Add(txt);
            }
            if (chk7.Checked)
            {
                txt = chk7.Text;
                ls2.Add(txt);
            }
            if (chk8.Checked)
            {
                txt = chk8.Text;
                ls2.Add(txt);
            }
           
            await Navigation.PushAsync(new Plano3());
        }
    }
}