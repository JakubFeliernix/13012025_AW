namespace Zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void dodawanie_Click(object sender, EventArgs e)
        {
            Wynik.Text = ((float.Parse(textBox1.Text) + float.Parse(textBox2.Text)).ToString());
            MessageBox.Show(Wynik.Text,"OKNO POWIADOMIEÑ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            Wynik.Text = ((float.Parse(textBox1.Text) - float.Parse(textBox2.Text)).ToString());
            MessageBox.Show(Wynik.Text, "OKNO POWIADOMIEÑ",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Wynik.Text = ((float.Parse(textBox1.Text) * float.Parse(textBox2.Text)).ToString());
            MessageBox.Show(Wynik.Text, "OKNO POWIADOMIEÑ",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
