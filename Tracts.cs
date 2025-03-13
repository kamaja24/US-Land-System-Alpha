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
    public partial class Tracts : Form
    {
        public Tracts()
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
            string sqlQuery = "INSERT INTO Tracts (Tract_ID, Tract_Status, Active, Tract_Name, Full_Description, Total_Acreage, State_ID, County_ID, Field1, Field2, Field3, Field4) VALUES (" + "'" + TractID_Value.Text + "'" + "," + "'" + TractStatus_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + Tract_Name + "'" + "," + "'" + FullDescription_Value + "'" + "," + "'" + TotalAcreage_Value + "'" + "," + "'" + StateID_Value + "'" + "," + "'" + CountyID_Value + "'" + "," + "'" + Field1_Value + "'" + "," + "'" + Field2_Value + "'" + "," + "'" + Field3_Value + "'" + "," + "'" + Field4_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
