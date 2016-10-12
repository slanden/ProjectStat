using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Content;

namespace ProjectStat
{
    [Activity(Label = "@string/appName", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);

            // Get our UI controls from the loaded layout:
            Button newButton = FindViewById<Button>(Resource.Id.newButton);
            Button openButton = FindViewById<Button>(Resource.Id.openButton);

            newButton.Click += (sender, e) =>
             {
                 var intent = new Intent(this, typeof(NewProjectActivity));
                 StartActivity(intent);
             };
        }
    }
}

