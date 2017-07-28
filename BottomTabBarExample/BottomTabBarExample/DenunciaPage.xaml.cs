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
    public partial class DenunciaPage : ContentPage
    {
        public DenunciaPage()
        {
            InitializeComponent();
        }

        private void GoToURL1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://defensoria.pe.def.br/defensoria/?x=home"));
        }

        private void GoToURL2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.mpf.mp.br/para-o-cidadao/sac"));
        }

        private void GoToURL3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:180"));
        }

        private void GoToURL4(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:136"));
        }
    }
}