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
        String Status;

        public string Status1 { get => Status; set => Status = value; }

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
        /*
public override void Create()
{
   throw new NotImplementedException();
}

public override void delete()
{
   throw new NotImplementedException();
}

public override void read()
{
   throw new NotImplementedException();
}

public override void update()
{
   throw new NotImplementedException();
}*/

    }
}
