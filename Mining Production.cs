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
    public partial class Mining_Production : Form
    {
        public Mining_Production()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
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
            string sqlQuery = "INSERT INTO Mining_Production (Voucher_Number, YearMonth, Accounting_Period, Sold_To, Tract_ID, Subtract_ID, Mine_ID, Mining_Method, Shipping_From, Raw_Tons_Mined, Clean_Tons_Mined, Tons_Sold, Tons_Wheeled, GainsLoses, Gross_Sales_Price, Producers_Price_Index, Gross_Mining_Costs, Acres_Mined, AcresFeet_Mined, Product, Unit_Of_Measure) VALUES (" + "'" + VoucherNumber_Value.Text + "'" + "," + "'" + YearMonth_Value + "'" + "," + "'" + AccountingPeriod_Value + "'" + "," + "'" + SoldTo_Value + "'" + "," + "'" + TractID_Value + "'" + "," + "'" + SubtractID_Value + "'" + "," + "'" + MineID_Value + "'" + "," + "'" + MiningMethod_Value + "'" + "," + "'" + ShippingFrom_Value + "'" + "," + "'" + RawTonsMined_Value + "'" + "," + "'" + CleanTonsMined_Value + "'" + "," + "'" + TonsSold_Value + "'" + "," + "'" + TonsWheeled_Value + "'" + "," + "'" + GainsLoses_Value + "'" + "," + "'" + GrossSalesPrice_Value + "'" + "," + "'" + ProducersPriceIndex_Value + "'" + "," + "'" + GrossMiningCosts_Value + "'" + "," + "'" + AcresMined_Value + "'" + "," + "'" + AcresFeetMined_Value + "'" + "," + "'" + Product_Value + "'" + "," + "'" + UnitOfMeasure_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
