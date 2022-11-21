using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;


namespace DiceStats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiceRoll : ContentPage
    {
        bool PageCloseAnimation = false;
        public DiceRoll()
        {
            InitializeComponent();
            VibrationEffect();
            number.Text = Dane.sumaOczek.ToString();
            
        }
        void VibrationEffect()
        {
            if (Dane.vibration == true)
            {
                try
                {
                    Vibration.Vibrate();
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }
        async void animationView_OnFinishedAnimation(object sender, EventArgs e)
        {
            Dane.start = false;
            Dane.button = true;
            Dane.now = DateTime.Now;
            await Navigation.PopModalAsync(PageCloseAnimation);
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}