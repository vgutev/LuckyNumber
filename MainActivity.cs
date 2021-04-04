using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        SeekBar seekbar;
        TextView resultTextView;
        Button rollButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            seekbar = FindViewById<SeekBar>(Resource.Id.seekBar1);
            resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);
            rollButton = FindViewById<Button>(Resource.Id.rollButton);
            rollButton.Click += RollButton_Click;
            //resultTextView.Text = "9";
            SupportActionBar.Title = "Lucky Number";
        }

        private void RollButton_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int luckyNumber = random.Next(1,seekbar.Progress+1);
            resultTextView.Text = luckyNumber.ToString();
        }
    }
}