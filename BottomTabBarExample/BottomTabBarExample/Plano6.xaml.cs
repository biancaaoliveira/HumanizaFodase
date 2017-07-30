using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;
using BottomTabBarExample.Classes;

namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plano6 : ContentPage
    {
        string texto_inicial = "Estou ciente de que o parto pode tomar diferentes rumos. Abaixo estão minhas preferências em relação ao parto e nascimento do meu filho(a), caso tudo transcorra bem. Sempre que os planos não puderem ser seguidos, gostaria de ser previamente avisada e consultada a respeito das alternativas.";
        List<TextosPlanoDeParto> textoplanoparto = new List<TextosPlanoDeParto>();

        public Plano6()
        {
            InitializeComponent();
            PopulateTextos();

        }

        public string ConcatenarTextos(List<string> ls)
        {
            if (ls.Count != 0)
            {
                string texto1 = ls[0];
                for (int i = 1; i < ls.Count; i++)
                {
                    texto1 = texto1 + " " + ls[i];
                }
                return texto1;
            }
            else
                return " ";
        }

        public void PopulateTextos()
        {
           
            textoplanoparto.Add(new TextosPlanoDeParto()
            {
                titulo = "Trabalho de Parto",
                textos = ConcatenarTextos(Plano1.ls1)

            });
            textoplanoparto.Add(new TextosPlanoDeParto()
            {
                titulo = "Durante o Parto",
                textos = ConcatenarTextos(Plano2.ls2)
            });
            textoplanoparto.Add(new TextosPlanoDeParto()
            {
                titulo = "Após o Parto",
                textos = ConcatenarTextos(Plano3.ls3)
            });
            textoplanoparto.Add(new TextosPlanoDeParto()
            {
                titulo = "Cuidados com o Bebê",
                textos = ConcatenarTextos(Plano4.ls4)
            });
            textoplanoparto.Add(new TextosPlanoDeParto()
            {
                titulo = "Caso de Cesária",
                textos = ConcatenarTextos(Plano5.ls5)
            });
            lvTextos.ItemsSource = textoplanoparto;
        }

    
        public string ArrumarTextos()
        {
            string TextoEmail = "SEU PLANO DE PARTO" + "\n" + "\n" + texto_inicial;
            foreach(TextosPlanoDeParto t in textoplanoparto)
            {
                TextoEmail = TextoEmail + "\n" + "\n" + t.titulo + ":" +  "\n" + t.textos;
            }
            return TextoEmail;
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                emailMessenger.SendEmail("", "Plano de Parto", ArrumarTextos());

            }
            else
            {
                DisplayAlert("Alerta", "Para enviar o Plano de Parto por email é necessário um aplicativo de email!", "OK");
            }

        }
    }
}