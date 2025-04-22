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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mining_Production mining_Production = new Mining_Production();
            mining_Production.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Obligations obligations = new Obligations();
            obligations.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment_Record payment_record = new Payment_Record();
            payment_record.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recoupable_Payment recoupable_payment = new Recoupable_Payment();
            recoupable_payment.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            ROY_ORRI_NPRI roy_orri_npri = new ROY_ORRI_NPRI();
            roy_orri_npri.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remarks remarks = new Remarks();
            remarks.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tract__Ownership tract__Ownership = new Tract__Ownership();
            tract__Ownership.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tracts tracts = new Tracts();
            tracts.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wells wells = new Wells();
            wells.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            WI_Decks_Interest wI_Decks_Interest = new WI_Decks_Interest();
            wI_Decks_Interest.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            WI_Decks wI_Decks = new WI_Decks();
            wI_Decks.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leases leases = new Leases();
            leases.Show();
        }
    }
}
