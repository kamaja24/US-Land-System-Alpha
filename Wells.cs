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
    public partial class Wells : Form
    {
        public Wells()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
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
            string sqlQuery = "INSERT INTO Wells (Well_ID_Number, Alternate_ID_Number, Well_Name, API, Active, OK_To_Pay, Split_Stream, Well_Type, Well_Status, Acquisition_Code, Payout_Code, Prospect_ID, Acreage_Type, Total_Depth, Permit_Number, Tank_Battery, Producing_From, Meter1, Meter2, Meter3, Meter4, Permit_Effective, Permit_Expire, Date_Acquired, Date_Sold, Spud_Date, Completion, Date_On,Line, First_Sales_Date, Last_Shut_In, Plugged_Date, Other_Date, Other_Date2, Rig_released, Last_Frac_Date, Date_Tested, Date_TD, Payout1, Payout2, Payout3, Payout4, Purchaser, Responsible_Party, Current_Operator, Acquired_From, Sold_To, Area_Name, Pool_Name, XCoordinate, YCoordinate, ZCoordinate, Well_Legal_Description, Location_Notes, Field1, Field2, Field3, Field4) VALUES (" + "'" + WellIDNumber_Value.Text + "'" + "," + "'" + AlternateIDNumber_Value + "'" + "," + "'" + WellName_Value + "'" + "," + "'" + API_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + OKToPay_Value + "'" + "," + "'" + SplitStream_Value + "'" + "," + "'" + WellType_Value + "'" + "," + "'" + WellStatus_Value + "'" + "," + "'" + AcquisitionCode_Value + "'" + "," + "'" + PayoutCode_Value + "'" + "," + "'" + ProspectID_Value + "'" + "," + "'" + AcreageType_Value + "'" + "," + "'" + TotalDepth_Value + "'" + "," + "'" + PermitNumber_Value + "'" + "," + "'" + TankBattery_Value + "'" + "," + "'" + ProducingFrom_Value + "'" + "," + "'" + Meter1_Value + "'" + "," + "'" + Meter2_Value + "'" + "," + "'" + Meter3_Value + "'" + "," + "'" + Meter4_Value + "'" + "," + "'" + PermitEffective_Value + "'" + "," + "'" + PermitExpire_Value + "'" + "," + "'" + DateAcquired_Value + "'" + "," + "'" + DateSold_Value + "'" + "," + "'" + SpudDate_Value + "'" + "," + "'" + Completion_Value + "'" + "," + "'" + DateOnLine_Value + "'" + "," + "'" + FirstSalesDate_Value + "'" + "," + "'" + LastShutIn_Value + "'" + "," + "'" + PluggedDate_Value + "'" + "," + "'" + OtherDate_Value + "'" + "," + "'" + OtherDate2_Value + "'" + "," + "'" + RigReleased_Value + "'" + "," + "'" + LastFracDate_Value + "'" + "," + "'" + DateTested_Value + "'" + "," + "'" + DateTD_Value + "'" + "," + "'" + Payout1_Value + "'" + "," + "'" + Payout2_Value + "'" + "," + "'" + Payout3_Value + "'" + "," + "'" + Payout4_Value + "'" + "," + "'" + Purchaser_Value + "'" + "," + "'" + ResponsibleParty_Value + "'" + "," + "'" + CurrentOperator_Value + "'" + "," + "'" + AcquiredFrom_Value + "'" + "," + "'" + SoldTo_Value + "'" + "," + "'" + AreaName_Value + "'" + "," + "'" + PoolName_Value + "'" + "," + "'" + XCoordinate_Value + "'" + "," + "'" + YCoordinate_Value + "'" + "," + "'" + ZCoordinate_Value + "'" + "," + "'" + WellLegalDescription_Value + "'" + "," + "'" + LocationNotes_Value + "'" + "," + "'" + Field1_Value + "'" + "," + "'" + Field2_Value + "'" + "," + "'" + Field3_Value + "'" + "," + "'" + Field4_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
