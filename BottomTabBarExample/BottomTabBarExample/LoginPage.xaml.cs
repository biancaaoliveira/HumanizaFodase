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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {

            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Email.Text == "teste@email.com" && Senha.Text == "123")
            {
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Informação", "email ou senha inválidos", "fechar");

            }

        }
        private async void cadastrar_clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CadastroPage());

        }
    }
}