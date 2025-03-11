namespace US_Land_System_Alpha
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void PPIButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PPI pPI = new PPI();
            pPI.Show();
        }

        private void BankButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bank bank = new Bank();
            bank.Show();
        }

        private void CodesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Codes codes = new Codes();
            codes.Show();
        }

        private void ContactsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Contacts contacts = new Contacts();
            contacts.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            District district = new District();
            district.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOI_Interest doi_interest = new DOI_Interest();
            doi_interest.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DOI doi = new DOI();
            doi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formations formations = new Formations();
            formations.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Land_Identifier land_identifier = new Land_Identifier();
            land_identifier.Show();
        }

        private void leasesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leases leases = new Leases();
            leases.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mining_Production_Payable mining_production_payable = new Mining_Production_Payable();
            mining_production_payable.Show();
        }
    }
}
