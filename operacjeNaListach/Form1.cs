namespace operacjeNaListach
{
    public partial class Form1 : Form
    {
        private dane d;
        private List<dane> lista=new List<dane>();
        private int idBiezacy = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void czyscDana()
        {
            d.nazwisko = "";
            d.imie = "";
            d.klasa = "";

        }
        private void dodaj()
        {
            czyscDana();
            d.nazwisko = textBox1.Text;
            d.imie = textBox2.Text;
            d.klasa= textBox3.Text;
            lista.Add(d);

        }

    }
}
