﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;
using XLabs.Forms.Controls;
using BottomTabBarExample.Classes;



namespace BottomTabBarExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plano1 : ContentPage
    {

        public static List<string> ls1;

        public Plano1()
        {
                                 
            
                InitializeComponent();
                ls1 = new List<string>();
                  

        }
        
        private async void Plano2_Clicked(object sender, EventArgs e)
        {
            string txt;
            ls1.Clear();
            if (chk1.Checked)
            {
                txt = chk1.Text;
                ls1.Add(txt);
            }
            if (chk2.Checked)
            {
                txt = chk2.Text;
                ls1.Add(txt);
            }
            if (chk3.Checked)
            {
                txt = chk3.Text;
                ls1.Add(txt);
            }
            if (chk4.Checked)
            {
                txt = chk4.Text;
                ls1.Add(txt);
            }
            if (chk5.Checked)
            {
                txt = chk5.Text;
                ls1.Add(txt);
            }
            if (chk6.Checked)
            {
                txt = chk6.Text;
                ls1.Add(txt);
            }
            if (chk7.Checked)
            {
                txt = chk7.Text;
                ls1.Add(txt);
            }
            if (chk8.Checked)
            {
                txt = chk8.Text;
                ls1.Add(txt);
            }
            if (chk9.Checked)
            {
                txt = chk9.Text;
                ls1.Add(txt);
            }
            
            await Navigation.PushAsync(new Plano2());
        }
        
    };
}
