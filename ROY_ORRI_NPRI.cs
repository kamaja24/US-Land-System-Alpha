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
    public partial class ROY_ORRI_NPRI : Form
    {
        public ROY_ORRI_NPRI()
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
            string sqlQuery = "INSERT INTO ROY_ORRI_NPRI (Owner_ID, Interest_Type, ORRI_Type, Interest_Formula, Interest, Payout_Code, Substance, Effective_Date, Expirations_Date, Suspense_Code, Tracts, Active, Burdens_All_WI_Partners, ORRI_Reduction_Type, NPRI_Owner_ID, Full_Int, NPRI_Formula, ROY_Interest, ROY_Suspense_Code, WI_Deck, WI_Owner_ID, WI_Interest_Formula, WI_Interest) VALUES (" + "'" + OwnerID_Value.Text + "'" + "," + "'" + InterestType_Value + "'" + "," + "'" + ORRIType_Value + "'" + "," + "'" + InterestFormula_Value + "'" + "," + "'" + Interest_Value + "'" + "," + "'" + PayoutCode_Value + "'" + "," + "'" + Substance_Value + "'" + "," + "'" + EffectiveDate_Value + "'" + "," + "'" + ExpirationDate_Value + "'" + "," + "'" + SuspenseCode_Value + "'" + "," + "'" + Tracts_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + BurdensALLWIPartners_Value + "'" + "," + "'" + ORRIReductionType_Value + "'" + "," + "'" + NPRIOwnerID_Value + "'" + "," + "'" + FullInt_Value + "'" + "," + "'" + NPRIFormula_Value + "'" + "," + "'" + ROYInterest_Value + "'" + "," + "'" + ROYSuspenseCode_Value + "'" + "," + "'" + WIDeck_Value + "'" + "," + "'" + WIOwnerID_Value + "'" + "," + "'" + WIInterestFormula_Value + "'" + "," + "'" + WIInterest_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
