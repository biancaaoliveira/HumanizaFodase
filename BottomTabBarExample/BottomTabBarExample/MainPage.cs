using BottomBar.XamarinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomTabBarExample
{
    public class MainPage : BottomBarPage
    {
        public MainPage()
        {
           
            Title = "HUMANIZA";

            Children.Add(new NewsPage());

            Children.Add(new MapaPage());

            Children.Add(new ProfiPage());

            Children.Add(new PlanoPage());

            Children.Add(new DenunciaPage());



            NavigationPage.SetHasNavigationBar(this, true);

            
            ToolbarItem tb1 = new ToolbarItem();
            tb1.Icon = "avatar_adicione3.png";
            tb1.Clicked += Convidar_Clicked;
            tb1.Priority = 0;
            

            ToolbarItem tb2 = new ToolbarItem();
            tb2.Icon = "meu_perfil3.png";
            tb2.Clicked += Perfil_Clicked;
            tb1.Priority = 1;


            ToolbarItems.Add(tb1);
            ToolbarItems.Add(tb2);
        }

        private async void Convidar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConvidarPage());
        }
        private async void Perfil_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());
        }
    }
}
