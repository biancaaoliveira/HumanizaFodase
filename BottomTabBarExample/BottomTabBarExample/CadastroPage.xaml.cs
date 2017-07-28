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
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();
        }
        private async void cadastro_clicked(object sender, EventArgs e)
        {
            if (Senha.Text == Senhaconfirma.Text && Senha.Text.Length > 5)
            {
                Navigation.InsertPageBefore(new LoginPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Informação", "Senhas diferentes ou pequenas", "fechar");

            }
        }
    }
    
}