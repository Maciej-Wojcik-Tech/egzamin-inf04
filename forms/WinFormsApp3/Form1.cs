namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imieTekst = imie.Text;
            string nazwiskoTekst = nazwisko.Text;
            int iloscZnakow = int.Parse(ilosc.Text);
            string haslo = "";
            string maleLitery = "abcdefghijklmnopqrstuvwxyz";
            string wielkielitery = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cyfryy = "1234567890";
            string znakiSpecjalne = "!@#$%^&*_+-=";
            string tablica = maleLitery;
            if(litery.Checked)
                    {
                    tablica += wielkielitery;
                }
                if(cyfry.Checked)
                        {
                        tablica += cyfryy;
                    }
                    if(znaki.Checked)
                    {
                        tablica += znakiSpecjalne;
                    }
                    Random random = new Random();
                    for(int i=0;i<iloscZnakow;i++)
                    {
                int index = random.Next(tablica.Length);
                            char znak = tablica[index];
                        haslo += znak;
                    }
                    MessageBox.Show("twoje has³o to: " + haslo);
        }
    }
}