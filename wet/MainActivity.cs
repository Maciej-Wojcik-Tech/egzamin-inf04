using Android.App;
using Android.OS;
using Android.Widget;

namespace wet
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        string clickedItem = "";
        protected override void OnCreate(Bundle savedInstanceState)  // Usuni�cie nullable
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            // Znalezienie ListView w uk�adzie
            ListView listview = FindViewById<ListView>(Resource.Id.listView1);
            SeekBar seekbar = FindViewById<SeekBar>(Resource.Id.seekBar1);
EditText imie =FindViewById<EditText>(Resource.Id.editText1);
            EditText goal = FindViewById<EditText>(Resource.Id.editText2);
            EditText timevisit = FindViewById<EditText>(Resource.Id.editText3);
            TextView textview=FindViewById<TextView>(Resource.Id.textView4);
Button button =FindViewById<Button>(Resource.Id.button1);

            button.Click += (sender, e) =>
            {
                string imieText = imie.Text;
                string visit = timevisit.Text;
                string goalText = goal.Text;
                int seekbarValue = seekbar.Progress;
                textview.Text += $"{imieText}, {visit}, {goalText}, {seekbarValue}, {clickedItem} \n";
            };
            // Lista zwierz�t
            List<string> animals= new List<string>
            {
                "Pies",
                "Kot",
                "�winka morska"
            };

            // Ustawienie adaptera dla ListView
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, animals);
            listview.Adapter = adapter;

            // Obs�uga klikni�cia na element listy
            listview.ItemClick += (s, e) =>
            {
                // Pobranie klikni�tego elementu
                string clickedItem = animals[e.Position];  // Zmienna powinna si� nazywa� `animals`, a nie `items`
                switch(clickedItem)
                {
                    case "Kot":
                        seekbar.Max = 20;
                        break;
                    case "Pies":
                        seekbar.Max = 19;
                        break;
                }
                // Wy�wietlenie informacji o klikni�ciu
                Toast.MakeText(this, "Klikni�to: " + clickedItem, ToastLength.Short).Show();
            };  // Dodany �rednik

        }
    }
}
