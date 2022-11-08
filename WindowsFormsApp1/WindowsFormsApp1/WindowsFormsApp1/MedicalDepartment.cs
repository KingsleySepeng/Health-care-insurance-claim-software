using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class MedicalDepartment : DataHandler
    {
        private string tablename = "Medical_Condition";
        private string tblTreatments = "Treatments";

        public string TblTreatments { get => tblTreatments; set => tblTreatments = value; }
        public string Tablename { get => tablename; set => tablename = value; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void Create(string tableName, string cName, string mName, string cCode)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Medical_Condition, Medical_Name, Condition_Code)  VALUES ('" + cName + "', '" + mName + "', '" + cCode + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void Create(string tableName, string tName, float tCost, string tPolicy, int tLengt, string tConId, string tProId)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Treatment, Cost_Of_Treatment, Policy_ID, Treatment_Length_in_Days, Condition_ID, ProviderId)  VALUES ('" + tName + "', '" + tCost + "', '" + tPolicy + "', '" + tLengt + "', '" + tConId + "', '" + tProId + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }
        
    }
}
