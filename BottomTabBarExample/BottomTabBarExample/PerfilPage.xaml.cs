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
    public partial class PerfilPage : ContentPage
    {
       
        public static int count = 0;
        public PerfilPage()
        {
            InitializeComponent();
            BindingContext = LoginPage.UsuarioAtual;

        }


        private async void sair_clicked(object sender, EventArgs e)
        {
            count++;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();

        }

    }
}
