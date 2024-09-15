namespace domekMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
private void like_Clicked(object sender, EventArgs e)
        {
            count++;
            ilosc.Text = $"ilość polubień {count}";

            SemanticScreenReader.Announce(ilosc.Text);
        }

        private void dislike_Clicked(object sender, EventArgs e)
        {
            if(count>0)
            {

                count--;

                SemanticScreenReader.Announce(ilosc.Text);
                ilosc.Text = $"ilość polubień {count}";
            }
        }

        private void save_Clicked(object sender, EventArgs e)
        {

        }
    }

}
