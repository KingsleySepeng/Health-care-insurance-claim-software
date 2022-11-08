using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class CallCenter:DataHandler
    {
        private string tableName = "Claim";
        private string callTable = "Call_Record";


        public string TableName { get => tableName; set => tableName = value; }
        public string CallTable { get => callTable; set => callTable = value; }

        public void Search() { }
        public DateTime StartCall()
        {
            MessageBox.Show("Call recording started...");
            return DateTime.Now;
        }

        public DateTime EndCall(DateTime startTime)
        {
            MessageBox.Show("Call ended.\nTotal call length: "+DateTime.Now.Subtract(startTime).ToString("hh\\:mm\\:ss"));
            return DateTime.Now;
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void Create(string tableName, string hID, string tID, string pID, string Medical_Condition, string prID, string claimStatus, string claimDate)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (PolicyHolder_ID Treatment_ID, Policy_ID, Medical_Condition, ProviderID, Claim_Status, Claim_Date)  VALUES ('" + hID + "', '" + tID + "', '" + pID + "', '" + Medical_Condition + "', '" + prID + "', '" + claimStatus + "', '" + claimDate + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void Create(string tableName, DateTime startTime, DateTime endTime)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Call_Start, Call_End)  VALUES ('" + startTime + "', '" + endTime + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void Update(string tableName, string tID, string columnName, string newValue)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "UPDATE " + tableName + " SET " + columnName + " = '" + newValue + "' WHERE Claim_ID = '" + tID + "'";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public string CheckClaim(string checkValue, string mCondition)
        {
            List<string> medicalCons = new List<string>();
            string query = "select Medical_Condition.Medical_Condition from Medical_Condition inner join tblPolicy on Medical_Condition.Policy_Id = tblPolicy.Policy_Id where tblPolicy.Policy_Id = '" +checkValue+ "'";
            string claimStatus = "pending"; bool approved = false;

            using(SqlConnection connection =  new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = connection;

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    medicalCons.Add(dr[0].ToString());
                }
                connection.Close();
            }
            if (medicalCons.Count != 0)
            {
                foreach  (string conditions in medicalCons)
                {
                    if(mCondition == conditions)
                    {
                        claimStatus = "Approved";
                    }
                }
            }
            else
            {
                claimStatus = "Denied";
            }

            return claimStatus;
        }

        public List<string> getTreatments(string mCondition)
        {
            List<string> treatments = new List<string>();
            string query = "select Treatments.Treatment_Name from Treatments inner join Medical_Condition on Medical_Condition.Condition_ID = Treatments.Condition_ID where Medical_Condition.Medical_Condition = '" +mCondition+ "'";

            using (SqlConnection connection = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = connection;

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    treatments.Add(dr[0].ToString());
                }
                connection.Close();
            }
            return treatments;
        }

        public List<string> getProviders(string tName)
        {
            List<string> providers = new List<string>();
            string query = "select Provider_table.ProviderId from Provider_table inner join Treatments on Provider_table.ProviderId = Treatments.ProviderId where Treatments.Treatment_Name = '" +tName+ "'";

            using (SqlConnection connection = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Connection = connection;

                connection.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    providers.Add(dr[0].ToString());
                }
                connection.Close();
            }
            providers.Distinct();
            return providers;
        }
    }
}
