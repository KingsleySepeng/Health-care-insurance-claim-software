using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class ProviderManagement:DataHandler
    {
        private string tableName = "Provider_table";

        public string TableName { get => tableName; set => tableName = value; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void Create(string tableName, string pName, string pTelephone, string Address, string TreatmentType, string startDate, string endDate)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Provider_Name, Telephone, Address, Contract_Start_Date, Contract_End_Date, Treatment_Type)  VALUES ('" + pName + "', '" + pTelephone + "', '" + Address + "', '" + startDate + "', '" + endDate + "', '" + TreatmentType + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public TimeSpan getContractLength(string tableName, string searchColumn, int searchValue)
        {
            DateTime currentDate = DateTime.Now, endDate = DateTime.Now;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Contract_End_Date from " + tableName + " WHERE  " + searchColumn + " = " + searchValue + "";
                cmd.Connection = sqlCon;
                sqlCon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) { endDate = (DateTime)dr[0]; }
            }
            return currentDate.Subtract(endDate);
        }

        public void Update(string tableName, string tID, string columnName, string newValue)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "UPDATE " + tableName + " SET " + columnName + " = '" + newValue + "' WHERE ProviderId = '" + tID + "'";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void deletePM(string id)
        {
            SqlConnection sqlCon = new SqlConnection(Conn);
            {
                SqlCommand cmd = new SqlCommand("spDeletePM", sqlCon);
                cmd.Parameters.AddWithValue("@PolicyHolder_ID", id);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
