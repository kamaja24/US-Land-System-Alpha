﻿using System;
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
    public partial class Tract__Ownership : Form
    {
        public Tract__Ownership()
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
            string sqlQuery = "INSERT INTO Tract_Ownership (Owner_ID, Lease_ID, Formula, Mineral_Interest, Surface_Interest, Subsistence_Interest, Effective_Date, Expiration_Date, Suspense_Code, Tenure, NO_Executive_Rights, Tenant, Active) VALUES (" + "'" + OwnerID_Value.Text + "'" + "," + "'" + LeaseID_Value + "'" + "," + "'" + Formula_Value + "'" + "," + "'" + Mineral_Interest + "'" + "," + "'" + Surface_Interest + "'" + "," + "'" + SubsistenceInterest_Value + "'" + "," + "'" + EffectiveDate_Value + "'" + "," + "'" + ExpirationDate_Value + "'" + "," + "'" + SuspenseCode_Value + "'" + "," + "'" + Tenure_Value + "'" + "," + "'" + NOExecutiveRights_Value + "'" + "," + "'" + Tenant_Value + "'" + "," + "'" + Active_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
