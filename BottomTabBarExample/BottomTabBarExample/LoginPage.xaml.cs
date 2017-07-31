using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BottomTabBarExample.Classes;
using System.Collections.Generic;

namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public static Gravidas UsuarioAtual;
        public static List<Gravidas> gravidas;

        public LoginPage()
        {

            InitializeComponent();

            if(PerfilPage.count == 0)
            {
                gravidas = new List<Gravidas>();
                gravidas.Add(new Gravidas("Usuário Teste", "teste@email.com", "123"));
                UsuarioAtual = new Gravidas();
            }
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            foreach(Gravidas g in gravidas)
            {
                if((_Email.Text == g.email && _Senha.Text == g.senha))
                {
                    UsuarioAtual.nome = g.nome;
                    UsuarioAtual.email = g.email;
                    UsuarioAtual.senha = g.senha;
                    Navigation.InsertPageBefore(new MainPage(), this);
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Aviso", "email ou senha inválidos", "fechar");

                }
            }
            

        }
        private async void cadastrar_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());

        }
    }
}