using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Xamarin.Forms;

namespace DiceStats
{
    public partial class MainPage : ContentPage
    {
        public static class Oczka
        {
            public static int[] oczka = new int[11];
        };
        void DrawChart()
        {
            List<ChartEntry> DataList = new List<ChartEntry>();
            for (int i = 0; i <= 10; i++)
                DataList.Add(new ChartEntry(Oczka.oczka[i])
                {
                    Label = (i+2).ToString(),
                    ValueLabel = Oczka.oczka[i].ToString(),
                    Color = SKColor.Parse("#2c3e50")
                });
            chartViewBar.Chart = new BarChart { Entries = DataList, ValueLabelOrientation = Orientation.Horizontal, LabelOrientation = Orientation.Horizontal, LabelTextSize = 40 };
            chartViewPie.Chart = new PieChart { Entries = DataList, HoleRadius = 0.3f, LabelTextSize = 30 };
        }
        public MainPage()
        {
            InitializeComponent();
            var OczkaDefault = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Oczka.oczka = OczkaDefault;
            DrawChart();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var rand = new Random();
            int dice1 = rand.Next(1, 7);
            int dice2 = rand.Next(1, 7);
            Dice.Text = (dice1 + dice2).ToString();
            Oczka.oczka[(dice1+dice2-2)] = Oczka.oczka[(dice1 + dice2 - 2)] + 1;
            DrawChart();
        }
    }
}
