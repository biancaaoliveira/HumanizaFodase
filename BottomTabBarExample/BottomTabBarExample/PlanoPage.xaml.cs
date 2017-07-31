using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BottomTabBarExample.Classes;


namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanoPage : ContentPage
    {
        public PlanoPage()
        {
            InitializeComponent();
            //PopulateNews();
        }
        //public void PopulateNews()
        //{
        //    List<Noticias> plano_de_parto = new List<Noticias>();
        //    plano_de_parto.Add(new Noticias()
        //    {
        //        titulo = "Plano de Parto",
        //        descricao = "O plano de Parto é uma carta ou uma lista onde a gestante descreve tudo que gostaria ou não gostaria que acontecesse nas etapas do parto, desde o trabalho de parto até os cuidados com o bebê após o nascimento. Atentamos que é importante um diálogo prévio com a equipe que irá realizar o seu parto acerca das suas preferências. Ao clicar em 'fazer plano de parto' você terá acesso à alguns itens para ajudar a fazer o seu plano de parto e poderá enviar por email para quem desejar.",
        //        imagem = ImageSource.FromFile("plano_de_parto.png")
        //    });
        //    lvPlano.ItemsSource = plano_de_parto;           
        //}
        private async void Plano1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Plano1());
        }
    }
}