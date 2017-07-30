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
    public partial class Plano4 : ContentPage
    {
        public static List<string> ls4;

        public Plano4()
        {
            InitializeComponent();
            ls4 = new List<string>();
        }

        private async void Plano5_Clicked(object sender, EventArgs e)
        {
            string txt;
            ls4.Clear();
            if (chk1.Checked)
            {
                txt = chk1.Text;
                ls4.Add(txt);
            }
            if (chk2.Checked)
            {
                txt = chk2.Text;
                ls4.Add(txt);
            }
            if (chk3.Checked)
            {
                txt = chk3.Text;
                ls4.Add(txt);
            }
            if (chk4.Checked)
            {
                txt = chk4.Text;
                ls4.Add(txt);
            }
            if (chk5.Checked)
            {
                txt = chk5.Text;
                ls4.Add(txt);
            }
            if (chk6.Checked)
            {
                txt = chk6.Text;
                ls4.Add(txt);
            }
           
            await Navigation.PushAsync(new Plano5());
        }

    }
}