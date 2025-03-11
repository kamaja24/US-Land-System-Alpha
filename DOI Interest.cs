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
    public partial class DOI_Interest : Form
    {
        public DOI_Interest()
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
            string sqlQuery = "INSERT INTO DOI_Interest (Owner_ID, Interest_Type, Interest, Suspense, Effective_Date, Expiration_Date, Sign_Date, Other_Date, Pay_regardless, No_Pay, Pay_WPT, Pay_Severance_Tax, Active, Pay_Marketing_Costs, Pay_Other_Tax1, Pay_Other_Tax2, Interest_Formula) VALUES (" + "'" + OwnerID_Value.Text + "'" + "," + "'" + InterestType_Value + "'" + "," + "'" + Interest_Value + "'" + "," + "'" + Suspense_Value + "'" + "," + "'" + EffectiveDate_Value + "'" + "," + "'" + ExpirationDate_Value + "'" + "," + "'" + SignDate_Value + "'" + "," + "'" + OtherDate_Value + "'" + "," + "'" + PayRegardless_Value + "'" + "," + "'" + NoPay_Value + "'" + "," + "'" + PayWPT_Value + "'" + "," + "'" + PaySeveranceTax_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + PayMarketingCosts_Value + "'" + "," + "'" + PayOtherTax1_Value + "'" + "," + "'" + PayOtherTax2_Value + "'" + "," + "'" + InterestFormula_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
