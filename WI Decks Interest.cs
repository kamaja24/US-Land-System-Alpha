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
    public partial class WI_Decks_Interest : Form
    {
        public WI_Decks_Interest()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            string sqlQuery = "INSERT INTO WI_Deck_Interest (Owner_ID, Interest_Formula, Interest, Effective, Expiration_Date, Suspense_Code, Interest_Type, Send_Reports, Active) VALUES (" + "'" + OwnerID_Value.Text + "'" + "," + "'" + InterestFormula_Value + "'" + "," + "'" + Interest_Value + "'" + "," + "'" + Effective_Value + "'" + "," + "'" + SuspenseCode_Value + "'" + "," + "'" + InterestType_Value + "'" + "," + "'" + SendReports_Value + "'" + "," + "'" + Active_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
