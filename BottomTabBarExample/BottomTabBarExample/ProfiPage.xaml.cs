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
            btnDoulas.BackgroundColor = Color.FromHex("#B09FB7");


        }

        private void Doulas_Clicked(object sender, EventArgs e)
        {
            lvDoulas.IsVisible = true;
            lvProfissionais.IsVisible = false;
            btnDoulas.BackgroundColor = Color.FromHex("#B09FB7");
            btnProfissionais.BackgroundColor = Color.FromHex("#d5b7ee");

            //doulasbtn.BackgroundColor = Color.FromHex("#1976D2");
            //profibtn.BackgroundColor = Color.FromHex("#d5b7ee");
        }

        private void Profissionais_Clicked(object sender, EventArgs e)
        {
            lvDoulas.IsVisible = false;
            lvProfissionais.IsVisible = true;
            btnDoulas.BackgroundColor = Color.FromHex("#d5b7ee");
            btnProfissionais.BackgroundColor = Color.FromHex("#B09FB7");
        }

        public void PopulateDoulas()
        {
            List<Doulas> doulas = new List<Doulas>();
            //doulas.Add(new Doulas() { nome = "", email = "", cursos = { "", "", "" }, senha = "", status = "" });
            doulas.Add(new Doulas() { nome = "Ana Katz", email = "anakatzschuler@gmail.com", cursos = "Doula pelo GAMA", telefone= "(81) 9964-8212" });
            doulas.Add(new Doulas() { nome = "Camila Moraes", email = "cmilamoraesandrade@gmail.com", cursos = "Grupo de Apoio à Maternidade Ativa- GAMA", telefone = "(81) 9964-8212" });
            doulas.Add(new Doulas() { nome = "Cláudia Bezerra", email = "claudiabmrocha@gmail.com", cursos = "GAMA", telefone = "081-98978888" });
            doulas.Add(new Doulas() { nome = "Julia Amorim", email = "opartoemeu@gmail.com", cursos = "GAMA", telefone = "81 88631239" });
            doulas.Add(new Doulas() { nome = "Ludmila Ancelmo", email = "ludmilacaval@gmail.com", cursos = "GAMA", telefone = "81 98136776" });
            doulas.Add(new Doulas() { nome = "	Rebeca Sinelly", email = "rebecasinelly@gmail.com", cursos = "GAMA", telefone = "81 99662-7361" });


            lvDoulas.ItemsSource = doulas;
        }

        public void PopulateProfissionais()
        {
            List<Medicos> profissionais = new List<Medicos>();
            profissionais.Add(new Medicos() { nome = "Luíza Leal", email = "luizabortolozzo@gmail.com", cmr = "47864786",  status = "Enfermeira Obstetra", telefone = "81 98785648" });
            profissionais.Add(new Medicos() { nome = "Maria Rosa Araújo", email = "anaflaviaaguiar@gmail.com", status = "Enfermeira Obstetra", telefone = "81 98785787" });
            profissionais.Add(new Medicos() { nome = "Ana Flavia Ribeiro", email = "anaflaviaaguiar@gmail.com", status = "Enfermeira Obstetra", telefone = "81 98785648" });
            profissionais.Add(new Medicos() { nome = "Ana Flavia Ribeiro", email = "anaflaviaaguiar@gmail.com", status = "Enfermeira Obstetra", telefone = "81 98785648" });
            profissionais.Add(new Medicos() { nome = "Ana Flavia Ribeiro", email = "anaflaviaaguiar@gmail.com", status = "Enfermeira Obstetra", telefone = "81 98785648" });
            profissionais.Add(new Medicos() { nome = "Ana Flavia Ribeiro", email = "anaflaviaaguiar@gmail.com", status = "Enfermeira Obstetra", telefone = "81 98785648" });

            lvProfissionais.ItemsSource = profissionais;


        }

    }
}