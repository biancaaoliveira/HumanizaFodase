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
    public partial class ProfiPage : ContentPage
    {
        public ProfiPage()
        {
            InitializeComponent();

            PopulateDoulas();
            PopulateProfissionais();
        }

        private void Doulas_Clicked(object sender, EventArgs e)
        {
            lvDoulas.IsVisible = true;
            lvProfissionais.IsVisible = false;
        }

        private void Profissionais_Clicked(object sender, EventArgs e)
        {
            lvDoulas.IsVisible = false;
            lvProfissionais.IsVisible = true;
        }

        public void PopulateDoulas()
        {
            List<Doulas> doulas = new List<Doulas>();
            //doulas.Add(new Doulas() { nome = "", email = "", cursos = { "", "", "" }, senha = "", status = "" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com", senha = "123", status = "Ativo" });

            lvDoulas.ItemsSource = doulas;
        }

        public void PopulateProfissionais()
        {
            List<Doulas> profissionais = new List<Doulas>();

            lvProfissionais.ItemsSource = new List<int> { 1, 2, 4, 5 };
        }
    }
}