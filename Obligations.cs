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
    public partial class Obligations : Form
    {
        public Obligations()
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
            string sqlQuery = "INSERT INTO Obligations (Payee_ID, Responsible_Party_ID, Net_Amount_Due, OK_To_Pay, Include_Notes_On_Checks, Is_This_A_Recurring_Payment, Pay_Regardless_Lease_OKtoPay_Status, Pay_Regardless_Of_Suspense, Is_This_A_Recoupable_Payment, Multiply_By_PPI, Suspense_Code, Pay_Lessor_Direct, Bank_ID, Bank_Account_Number, Additional_Bank_Fees, Obligation_Date, Obligation_Type, Description_Of_Obligation) VALUES (" + "'" + PayeeID_Value.Text + "'" + "," + "'" + ResponsiblePartyID_Value + "'" + "," + "'" + NetAmountDue_Value + "'" + "," + "'" + OKToPay_Value + "'" + "," + "'" + IncludeNotesOnChecks_Value + "'" + "," + "'" + IsThisARecurringPayment_Value + "'" + "," + "'" + PayRegardlessOfLeaseOKToPayStatus_Value + "'" + "," + "'" + PayRegardlessOfSuspense_Value + "'" + "," + "'" + IsThisARecoupablePaymentType_Value + "'" + "," + "'" + MultiplyByPPI_Value + "'" + "," + "'" + SuspenseCode_Value + "'" + "," + "'" + PayLessorDirect_Value + "'" + "," + "'" + BankID_Value + "'" + "," + "'" + BankAccountNumber_Value + "'" + "," + "'" + AdditionalBankFees_Value + "'" + "," + "'" + ObligationDate_Value + "'" + "," + "'" + ObligationType_Value + "'" + "," + "'" + DescriptionOfObligation_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
