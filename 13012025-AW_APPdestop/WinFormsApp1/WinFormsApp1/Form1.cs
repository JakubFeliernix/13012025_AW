namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int zmk = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            zmk += 1;
            string zmienna = zmk.ToString();
            czas.Text = zmienna;
        }
        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            zmk = 0;
            string zmienna = zmk.ToString();
            czas.Text = zmienna;

        }
    }
}
