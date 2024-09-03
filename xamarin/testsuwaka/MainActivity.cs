using Android.Views;
using Android.Widget;

namespace testsuwaka
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += OnButtonClick;
        }
        private void OnButtonClick(object sender, EventArgs e)
        {
            TextView textView1 = FindViewById<TextView>(Resource.Id.textView1);
            textView1.Text = "Nowy tekst!";
        }

    }
}