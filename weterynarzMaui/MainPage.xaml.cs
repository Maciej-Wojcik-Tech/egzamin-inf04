using System.Collections.Generic;
namespace weterynarz
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            List<string> animals = new List<string>
            {
                "pies",
                "kot",
                "świnka morska"
            };
            animalList.ItemsSource = animals;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string napis = $"{imie.Text}, {gatunek.Text}, {suwak.Value}, {cel.Text}, {czas.Time}";
            result.Text = napis;
            SemanticScreenReader.Announce(result.Text);
        }

        private void animalList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            string selected = e.SelectedItem.ToString();
            if(selected=="pies")
            {
                suwak.Maximum = 18;
            }
            else if(selected=="kot")
            {
                suwak.Maximum = 20;
            }
            else if(selected=="świnka morska")
            {
                suwak.Maximum = 9;
            }
        }

        private void suwak_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string wartosc = suwak.Value.ToString();
            string tekst = $"Ile ma lat? {
                wartosc}";
            Age.Text = wartosc.ToString();
        }
    }

}
