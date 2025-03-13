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
    public partial class Mining_Production_Payable : Form
    {
        public Mining_Production_Payable()
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
            string sqlQuery = "INSERT INTO Mining_Production_Payable (YearMonth, Due_Month, Payable_In, OK_To_Pay, Account_Period, Lease_ID, Tract_ID, Subtract_ID, Mine_ID, Mining_Method, Shipping_From, Payee_ID, Department_Bank_ID, Bank_Account_Number, Suspense_Number, Tonnage, Price_Per_Ton, Royalty_Rate, Mineral_Interest, Gross_Amount_Due, Severance, Other_Tax, Recoup_Rate, Marketing_Costs, Recoup_Amount) VALUES (" + "'" + YearMonth_Value.Text + "'" + "," + "'" + DueMonth_Value + "'" + "," + "'" + PayableIn_Value + "'" + "," + "'" + OKToPay_Value + "'" + "," + "'" + AccountPeriod_Value + "'" + "," + "'" + LeaseID_Value + "'" + "," + "'" + TractID_Value + "'" + "," + "'" + SubtractID_Value + "'" + "," + "'" + MineID_Value + "'" + "," + "'" + MiningMethod_Value + "'" + "," + "'" + ShippingFrom_Value + "'" + "," + "'" + PayeeID_Value + "'" + "," + "'" + DepartmentBankID_Value + "'" + "," + "'" + BankAccountNumber_Value + "'" + "," + "'" + SuspenseNumber_Value + "'" + "," + "'" + Tonnage_Value + "'" + "," + "'" + PricePerTon_Value + "'" + "," + "'" + RoyaltyRate_Value + "'" + "," + "'" + MineralInterest_Value + "'" + "," + "'" + GrossAmountDue_Value + "'" + "," + "'" + SeveranceTax_Value + "'" + "," + "'" + OtherTax_Value + "'" + "," + "'" + RecoupRate_Value + "'" + "," + "'" + MarketingCosts_Value + "'" + "," + "'" + RecoupAmount_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
