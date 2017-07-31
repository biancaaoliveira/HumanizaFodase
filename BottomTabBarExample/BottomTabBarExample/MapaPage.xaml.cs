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
    public partial class MapaPage : ContentPage
    {
        public MapaPage()
        {
            InitializeComponent();
        }
        private void GoToURL3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://drive.google.com/open?id=1_6854qpUWheX04TvxyzSbmYgggU&usp=sharing"));
        }
    }
}