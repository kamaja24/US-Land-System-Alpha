namespace US_Land_System_Alpha
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPI pPI = new PPI();
            pPI.Show();
        }
    }
}
