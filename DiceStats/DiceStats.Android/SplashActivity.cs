using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceStats.Droid
{
    [Activity(Label = "DiceStats", Icon = "@drawable/icon", Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        static readonly string TAG = "X:" + typeof(SplashActivity).Name;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override void OnResume()
        {
            base.OnResume();
            SetContentView(Resource.Drawable.splash);
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        // Simulates background work that happens behind the splash screen
        async void SimulateStartup()
        {
            Console.WriteLine(TAG + " Performing some startup work that takes a bit of time 321 .");
            await Task.Delay(1000); // Simulate a bit of startup work.
            Console.WriteLine(TAG + " Startup work is finished - starting MainActivity 123 .");
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}
