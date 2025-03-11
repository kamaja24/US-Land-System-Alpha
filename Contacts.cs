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
    public partial class Contacts : Form
    {
        public Contacts()
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
            string sqlQuery = "INSERT INTO Contacts (Owner_ID, Full_Name, Address, Tax_ID, Alternate_ID, Tax_ID_Type, Mobile, Work_Phone, Home, Email, Web_Page, No_Pay_Code, Tenure_Code, General_Class, Default_Bank_ID, Bank_Account_Number, Active, Send_1099, Severance_Tax_Exempt, Expense_Exempt, Other_Exempt, Federal_Tax_Withhold, In_House_Owner, Contact_Type, Contact_Date, Notes, Reminder) VALUES (" + "'" + OwnerID_Value + "'" + "," + "'" + FullName_Value.Text + "'" + "," + "'" + Address_Value + "'" + "," + "'" + TaxID_Value + "'" + "," + "'" + AlternateID_Value + "'" + "," + "'" + TaxIDType_Value + "'" + "," + "'" + Mobile_Value + "'" + "," + "'" + Work_Value + "'" + "," + "'" + Home_Value + "'" + "," + "'" + Email_Value + "'" + "," + "'" + WebPage_Value + "'" + "," + "'" + NoPayCode_Value + "'" + "," + "'" + TenureCode_Value + "'" + "," + "'" + GeneralClass_Value + "'" + "," + "'" + DefaultBankID_Value + "'" + "," + "'" + BankAccountNumber_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + Send1099_Value + "'" + "," + "'" + SeveranceTaxExempt_Value + "'" + "," + "'" + ExpenseExempt_Value + "'" + "," + "'" + OtherExempt_Value + "'" + "," + "'" + FederalTaxWithold_Value + "'" + "," + "'" + InHouseOwner_Value + "'" + "," + "'" + ContactType_Value + "'" + "," + "'" + ContactDate_Value + "'" + "," + "'" + Notes_Value + "'" + "," + "'" + Reminder_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
