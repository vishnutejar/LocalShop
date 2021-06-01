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

namespace LocalShop.Droid
{
    [Activity(Label = "SplashScreenActivity", Theme = "@style/splashscreen", MainLauncher =true)]
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //SetContentView(Resource.Layout.layout_splashscreen_activity);
            // Create your application here

            Task.Delay(2000);
            StartActivity(new Intent(this,typeof(MainActivity)));
        }
    }
}