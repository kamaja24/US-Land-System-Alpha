using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace US_Land_System_Alpha
{
    public partial class WI_Decks : Form
    {
        public WI_Decks()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=GROOPER1\\GROOPERSQL4;Initial Catalog=USLandSystem1;User ID=SQLAdmin;Password=intOGS(22);TrustServerCertificate=True";
            string sqlQuery = "INSERT INTO WI_Decks (Deck_ID, Deck_Name, Active, Payout_Code, Product, Effective_Date, Expiration_Date, Suspense_Code, Use_In_Acreage_Calculations, Use_In_DOI,Calculations, Use_In_Print_Obligation_Calculations, Lease_ID, All_Tracts) VALUES (" + "'" + DeckID_Value.Text + "'" + "," + "'" + DeckName_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + Payout_Code + "'" + "," + "'" + Product_Value + "'" + "," + "'" + EffectiveDate_Value + "'" + "," + "'" + ExpirationDate_Value + "'" + "," + "'" + SuspenseCode_Value + "'" + "," + "'" + UseInAcreageCalculations_Value + "'" + "," + "'" + UseInDOICalculations_Value + "'" + "," + "'" + UseInPrintObligationCalculations_Value + "'" + "," + "'" + LeaseID_Value + "'" + "," + "'" + AllTracts_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
