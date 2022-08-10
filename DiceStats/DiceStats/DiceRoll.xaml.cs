﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DiceStats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiceRoll : ContentPage
    {
        public DiceRoll()
        {
            InitializeComponent();
            number.Text = Dane.sumaOczek.ToString();
        }

        async void animationView_OnFinishedAnimation(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}