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
            doulas.Add(new Doulas() { nome = "Ana Katz", email = "anakatzschuler@gmail.com", cursos = "Doula pelo GAMA", telefone= "(81) 9964-8212" });
            doulas.Add(new Doulas() { nome = "", email = "gabriel@mail.com", status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com",status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com",  status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com", status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com", status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com",  status = "Ativo" });
            doulas.Add(new Doulas() { nome = "Gabriel", email = "gabriel@mail.com", status = "Ativo" });

            lvDoulas.ItemsSource = doulas;
        }

        public void PopulateProfissionais()
        {
            List<Medicos> profissionais = new List<Medicos>();
            profissionais.Add(new Medicos() { nome = "Gabriel", email = "gabriel@gmail.com", status = "Loucão", telefone ="81 98785648" });
            lvProfissionais.ItemsSource = profissionais;


        }
    }
}