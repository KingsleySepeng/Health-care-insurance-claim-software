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
        String MedicalCondition;
        String Treatment;

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
        /*
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
