using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    internal class ClientPolicyMaintenance:DataHandler
    {/*
        public ClientPolicyMaintenance(){ }

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
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void Create(string tableName, string Id, string hName, string hSurname, string hTelephone, string hAddress, string hPolicyType, float monthlyFee, string FamilyPlan)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (PolicyHolder_ID, Name, Surname, Telephone, Address, Policy_Id, Monthly_Premium, Family_Plan)  VALUES ('" + Id + "', '" + hName + "', '" + hSurname + "', '" + hTelephone + "', '" + hAddress + "', '" + hPolicyType + "', '" + monthlyFee + "', '" + FamilyPlan + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void Create(string tableName, string shName, string shSurname, string shRelation, string Age, string hID)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Name, Surname, Relation_to_Main_Holder, Dependent_Age, PolicyHolder_ID)  VALUES ('" + shName + "', '" + shSurname + "', '" + shRelation + "', '" + Age + "', '" + hID + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public string createID()
        {
            Random random = new Random();
            string[] firstChar = { "h", "G", "K", "L", "J" };
            string id = firstChar[random.Next(4)];
            for (int i = 1; i <= 8; i++)
            {
                id += Convert.ToString(random.Next(9));
            }

            return id;
        }

        public float calcMonthlyFee(string Policy)
        {
            float fee = 0;
            using (SqlConnection sqlCon =  new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Policy_Prices from tblPolicy WHERE Policy_Id = '" + Policy + "'";
                cmd.Connection = sqlCon;

                sqlCon.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    fee = Convert.ToSingle(dr[0]);
                }
                sqlCon.Close();
            }

            return fee;
        }


    }
}
