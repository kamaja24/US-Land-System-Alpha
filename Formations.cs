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
    public partial class Formations : Form
    {
        public Formations()
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
            string sqlQuery = "INSERT INTO Formations (Formation_ID, Description, Type_Of_Rock, Main_Product, Permeability, Porosity, Average_Depth, Average_Thickness, Status, Class, Geologist_Name, Area, Active) VALUES (" + "'" + FormationID_Value.Text + "'" + "," + "'" + Description_Value + "'" + "," + "'" + TypeOfRock_Value + "'" + "," + "'" + MainProduct_Value + "'" + "," + "'" + Permeability_Value + "'" + "," + "'" + Porosity_Value + "'" + "," + "'" + AverageDepth_Value + "'" + "," + "'" + AverageThickness_Value + "'" + "," + "'" + Status_Value + "'" + "," + "'" + Class_Value + "'" + "," + "'" + GeologistName_Value + "'" + "," + "'" + Area_Value + "'" + "," + "'" + Active_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
