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
    internal class ProductMaintenance:DataHandler
    {
        float basicPolicyPrice = 1200;
        float middlePolicyPrice = 2500;
        float premiumPolicyPrice = 6000;
        public string tableName = "tblPolicy";

        public float MiddlePolicyPrice { get => middlePolicyPrice; set => middlePolicyPrice = value; }
        public float BasicPolicyPrice { get => basicPolicyPrice; set => basicPolicyPrice = value; }
        public float PremiumPolicyPrice { get => premiumPolicyPrice; set => premiumPolicyPrice = value; }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void Create(string tableName, string ID, float PolicyPrice, string PolicyStartTime, string PolicyEndTime, string PolicyName, string PolicyType)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "INSERT INTO " + tableName + " (Policy_Id, Policy_Title, Contract_Type, Policy_Prices, Start_Date, End_Date)  VALUES ('" + ID + "', '" + PolicyName + "', '" + PolicyType + "', '" + PolicyPrice + "', '" + PolicyStartTime + "', '" + PolicyEndTime + "')";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public string CreateID(string date, string contractType, string importance)
        {
            string ID = contractType + importance;
            Random random = new Random();
            for(int i = 0; i< 6; i++)
            {
                ID += random.Next(9).ToString();
            }

            return ID;
        }

        public double calcPolicyPrice(float totalCost, string careLevel)
        {
            double finalCost = totalCost;
            if(careLevel == null)
            {

            }
            else
            {
                if(careLevel == "D")
                {
                    finalCost *= 1.05;
                }
                else if(careLevel == "C")
                {
                    finalCost *= 1.12;
                }
                else if (careLevel == "B")
                {
                    finalCost *= 1.25;
                }
                else if (careLevel == "A")
                {
                    finalCost *= 1.3;
                }
            }
            return finalCost;
        }

        public void Update(string tableName, string tID, string columnName, string newValue)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                SqlCommand sqlComm = new SqlCommand();
                sqlComm.CommandType = CommandType.Text;
                sqlComm.CommandText = "UPDATE " + tableName + " SET " + columnName + " = '" + newValue + "' WHERE Policy_Id = '" + tID + "'";
                sqlComm.Connection = sqlCon;

                sqlCon.Open();
                sqlComm.ExecuteNonQuery();
                sqlCon.Close();
            }
        }

        public void deletePo(string id)
        {
            SqlConnection sqlCon = new SqlConnection(Conn);
            {
                SqlCommand cmd = new SqlCommand("spDeletePo", sqlCon);
                cmd.Parameters.AddWithValue("@PolicyHolder_ID", id);
                sqlCon.Open();
                cmd.ExecuteNonQuery();
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
