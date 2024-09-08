namespace VetWinforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.BackColor = ColorTranslator.FromHtml("#90EE90");
            //dateTimePicker1.Value = DateTime.Today.AddHours(16);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                switch (listBox1.SelectedItem.ToString())
                {
                    case "pies":
                        trackBar1.Maximum = 18;
                        break; ;
                    case "kot":
                        trackBar1.Maximum = 20;
                        break;
                    case "œwinka morska":
                        trackBar1.Maximum = 10;
                        break;
                    default:
                        trackBar1.Maximum = 0;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik.Text = textBox1.Text + ", " + listBox1.SelectedIndex.ToString() + ", " + trackBar1.Value + ", " + textBox2.Text + ", " + dateTimePicker1.Value;

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string wiek = "Ile ma lat? ";
            label2.Text = wiek + trackBar1.Value;
        }
    }
}
