using BottomTabBarExample.Classes;
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
            if (!string.IsNullOrEmpty(_senha.Text) && !string.IsNullOrEmpty(Senhaconfirma.Text))
            {
                if (_senha.Text == Senhaconfirma.Text && _senha.Text.Length > 5)
                {
                    Gravidas g = new Gravidas(_nome.Text, _email.Text, _senha.Text);
                    LoginPage.gravidas.Add(g);
                    LoginPage.UsuarioAtual = g;
                    Navigation.InsertPageBefore(new MainPage(), this);
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "Senhas diferentes ou pequenas", "fechar");

                }
            }
            else
            {
                await DisplayAlert("Aviso", "Preencha todos os campos!", "fechar");
            }
        }
    }
    
}