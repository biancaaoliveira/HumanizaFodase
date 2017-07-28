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
    public partial class PlanoPage : ContentPage
    {
        public PlanoPage()
        {
            InitializeComponent();

            //var navigationPage = new NavigationPage(new Plano1());
            //navigationPage.Icon = "schedule.png";
            //navigationPage.Title = "Schedule";

            //Children.Add(new TodayPageCS());
            //Children.Add(navigationPage);\\\\
        }
    }
}