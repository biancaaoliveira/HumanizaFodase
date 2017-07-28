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
    public partial class ProfiPage : ContentPage
    {
        public ProfiPage()
        {
            InitializeComponent();
        }

        private void Doulas_Clicked(object sender, EventArgs e)
        {
            lvUsuarios.ItemsSource = new List<string> { "Um", "Dois" };
        }

        private void Profissionais_Clicked(object sender, EventArgs e)
        {
            lvUsuarios.ItemsSource = new List<int> { 1, 2, 4, 5 };
        }
    }
}