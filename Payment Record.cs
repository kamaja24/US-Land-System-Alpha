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
    public partial class Payment_Record : Form
    {
        public Payment_Record()
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
            string sqlQuery = "INSERT INTO District (Property_ID, Property_Type, Check_Number, Payee_ID, Payment_Type, Check_Date, Payor_ID, Transaction_Type, Check_Status, Total_Amount, Federal_Tax_Withheld, Direct_Deposit, Check_NumberDD, Routing_Number, Certified_Mail_Date) VALUES (" + "'" + PropertyID_Value.Text + "'" + "," + "'" + PropertyType_Value + "'" + "," + "'" + CheckNumber_Value + "'" + "," + "'" + PayeeID_Value + "'" + "," + "'" + PaymentType_Value + "'" + "," + "'" + CheckDate_Value + "'" + "," + "'" + PayorID_Value + "'" + "," + "'" + TransactionType_Value + "'" + "," + "'" + CheckStatus_Value + "'" + "," + "'" + TotalAmount_Value + "'" + "," + "'" + FederalTaxWithheld_Value + "'" + "," + "'" + DirectDeposit_Value + "'" + "," + "'" + CheckNumberDD_Value + "'" + "," + "'" + RoutingNumber_Value + "'" + "," + "'" + CertifiedMailDate_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
