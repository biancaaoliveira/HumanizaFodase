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
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
            PopulateNews();
        }

        public void PopulateNews()
        {
            List<Noticias> noticias = new List<Noticias>();
            
            noticias.Add(new Noticias()
            {
                titulo = "Exercícios de Kegel",
                descricao = "A grávida pode fazer exercícios para fortalecer os músculos do assoalho pélvico, como fazer exercícios de Kegel, facilitando o momento de expulsão do feto. Desta forma, a gestante deve contrair e puxar para cima os músculos o máximo que conseguir, mantendo - se assim pelo maior tempo possível e depois relaxar os músculos, baixando as pernas e as costas.",
                imagem = ImageSource.FromFile("exercicios1.png")
            });
            noticias.Add(new Noticias()
            {
                titulo = "Dançar",
                descricao = "Para facilitar o trabalho de parto, a grávida pode dançar ou apenas rebolar, o que pode facilitar o parto, pois o movimento da grávida promove o movimento do bebê na barriga, facilitando o parto.",
                imagem = ImageSource.FromFile("exercicios2.png")
            });
            lvNoticias.ItemsSource = noticias;
        }
    }
}