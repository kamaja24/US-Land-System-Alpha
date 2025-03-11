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
    public partial class Leases : Form
    {
        public Leases()
        {
            InitializeComponent();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
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
            string sqlQuery = "INSERT INTO Leases (Lease_ID, Lease_Date, Effective_Date, Primary_Term, Extended, Active, Original_Expiration_Date, Lessor_ID, Lessor_Name, Alternate_Lease_Name, Lessee_ID, Legal_Description, Paid_Up, Producing, Utilized, Renewal_Lease, Top_Lease, Validated, Pending, OK_To_Pay, Acquired_Date, Next_Rental_Due, Check_On, Divested, Surrendered, Other_Date, Field_Broker, County, State, Date, Volume, Book, Page, Entry_Number, Acqusition_Code, Lease_Type, Lease_Status, Instrument_Code, Payout_Code, Operator_Lease_Number, MMS_Lease_Number, Original_Lease_Number, Federal_Lease_Flag, FederalState_Lease_Number, ProjectGroup_Name, Bonus_Per_Acre, Total_Bonus_Amount, Total_Bonus_Paid, Bonus_Deferred, Consideration_Amount, Seismic_Permit_Expiration_Days, Seismic_Permit_Expiration_Date, Seismic_Permit_Extension_Date, Was_The_Seismic_Permit_Extended, Seismic_Option_Expiration_Days, Seismic_Option_Extension_Days, Option_Per_Acre, Extension_Per_Acre, Prepaid_Per_Acre, Conversion_Bonus_Per_Acre, Option_Period, Option_Expire_Date, Seismic_Option_Notes, Field1, Field2, Field3, Field4, Field5, Field6) VALUES (" + "'" + LeaseID_Value.Text + "'" + "," + "'" + LeaseDate_Value + "'" + "," + "'" + EffectiveDate_Value + "'" + "," + "'" + PrimaryTerm_Value + "'" + "," + "'" + Extended_Value + "'" + "," + "'" + Active_Value + "'" + "," + "'" + OriginalExpirationDate_Value + "'" + "," + "'" + LessorID_Value + "'" + "," + "'" + LessorName_Value + "'" + "," + "'" + AlternateLeaseName_Value + "'" + "," + "'" + LesseeID_Value + "'" + "," + "'" + LegalDescription_Value + "'" + "," + "'" + PaidUp_Value + "'" + "," + "'" + Producing_Value + "'" + "," + "'" + Utilized_Value + "'" + "," + "'" + RenewalLease_Value + "'" + "," + "'" + TopLease_Value + "'" + "," + "'" + Validated_Value + "'" + "," + "'" + Pending_Value + "'" + "," + "'" + OKToPay_Value + "'" + "," + "'" + AcquiredDate_Value + "'" + "," + "'" + NextRentalDue_Value + "'" + "," + "'" + CheckOn_Value + "'" + "," + "'" + Divested_Value + "'" + "," + "'" + Surrendered_Value + "'" + "," + "'" + OtherDate_Value + "'" + "," + "'" + FieldBroker_Value + "'" + "," + "'" + County_Value + "'" + "," + "'" + State_Value + "'" + "," + "'" + Date_Value + "'" + "," + "'" + Volume_Value + "'" + "," + "'" + Book_Value + "'" + "," + "'" + Page_Value + "'" + "," + "'" + EntryNumber_Value + "'" + "," + "'" + AcquisitionCode_Value + "'" + "," + "'" + LeaseType_Value + "'" + "," + "'" + LeaseStatus_Value + "'" + "," + "'" + InstrumentCode_Value + "'" + "," + "'" + PayoutCode_Value + "'" + "," + "'" + OperatorLeaseNumber_Value + "'" + "," + "'" + MMSLeaseNumber_Value + "'" + "," + "'" + OriginalLeaseNumber_Value + "'" + "," + "'" + FederalLeaseFlag_Value + "'" + "," + "'" + FederalStateLeaseNumber_Value + "'" + "," + "'" + ProjectGroupName_Value + "'" + "," + "'" + BonusPerAcre_Value + "'" + "," + "'" + TotalBonusAmount_Value + "'" + "," + "'" + TotalBonusPaid_Value + "'" + "," + "'" + BonusDeferred_Value + "'" + "," + "'" + ConsiderationAmount_Value + "'" + "," + "'" + SeismicPermitExpirationDays_Value + "'" + "," + "'" + SeismicPermitExpirationDate_Value + "'" + "," + "'" + SeismicPermitExtensionDate_Value + "'" + "," + "'" + WasTheSeismicPermitExtended_Value + "'" + "," + "'" + SeismicOptionExpirationDays_Value + "'" + "," + "'" + SeismicOptionExtensionDays_Value + "'" + "," + "'" + OptionPerAcre_Value + "'" + "," + "'" + ExtensionPerAcre_Value + "'" + "," + "'" + PrepaidPerAcre_Value + "'" + "," + "'" + ConversionBonusPerAcre_Value + "'" + "," + "'" + OptionPerAcre_Value + "'" + "," + "'" + OptionPeriod_Value + "'" + "," + "'" + OptionExpireDate_Value + "'" + "," + "'" + SeismicOptionNotes_Value + "'" + "," + "'" + Field1_Value + "'" + "," + "'" + Field2_Value + "'" + "," + "'" + Field3_Value + "'" + "," + "'" + Field4_Value + "'" + "," + "'" + Field5_Value + "'" + "," + "'" + Field6_Value + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }
    }
}
