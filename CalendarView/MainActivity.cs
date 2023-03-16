using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System.Globalization;

namespace CalendarView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView txtDisplay;
        Android.Widget.CalendarView calendarView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

           calendarView = FindViewById<Android.Widget.CalendarView>(Resource.Id.calendarView1);
             txtDisplay = FindViewById<TextView>(Resource.Id.txtDisplay);
            txtDisplay.Text = "Date :";
            calendarView.DateChange += CalendarView_DateChange;
        }

        private void CalendarView_DateChange(object sender, Android.Widget.CalendarView.DateChangeEventArgs e)
        {
            int day = e.DayOfMonth;
            int month = e.Month;
            int year = e.Year;
         txtDisplay.Text ="Date :"+day+"/"+month+"/"+year;
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}