using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   public abstract class DataHandler
    {
        

        public DataHandler() { }

        string conn = "Data Source=VISIONARY-VJAE\\SQLEXPRESS02;Initial Catalog=Ukupholisa_Healthcare_DB_v4.5;Integrated Security=True";

        public string Conn { get => conn; set => conn = value; }

        public DataTable Display(string tableName)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from " + tableName, sqlCon);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                return dt;
            }
        }

        public bool login(string userName, string Password)
        {
            bool valid = false;
            try
            {
                string query = "Select * from Credentials where Username = '" + userName + "' AND Password = '" + Password + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(query, Conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    valid = true;
                }
                else
                {
                    MessageBox.Show("Incorrect user detials!!!");
                }


            }
            catch
            {
                MessageBox.Show("Invalid Username or Password");

            }
            finally
            {

            }

            return valid;

        }

        public DataTable Search(string tableName, string searchValue, string searchColumn)
        {
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * from " + tableName +" WHERE  "+searchColumn+" LIKE '"+searchValue+"%'", sqlCon);
                DataTable dt = new DataTable();
                sqlData.Fill(dt);
                return dt;
            }
        }

        public DataTable searchPolicyHolder(int holder_id)
        {
            using (SqlConnection connect = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("spCCSearch", connect);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ID", holder_id);
                connect.Open();
                DataTable dt = new DataTable();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    dt.Load(dr);
                    return dt;
                }
            }
        }

        public void CreateMD(string cname, string mname, string mcode)
        {
            using (SqlConnection connect = new SqlConnection(Conn))
            {
                SqlCommand cmd = new SqlCommand("CraeteMD", connect);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Medical_Condition", mname);
                cmd.Parameters.AddWithValue("@Medical_Name", mcode);
                cmd.Parameters.AddWithValue("@Condition_Code", cname);
                connect.Open();
                cmd.ExecuteNonQuery();


            }

        }

        public List<string> returnPolicies()
        {
            List<string> policies = new List<string>();
            int counter = 0;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Policy_ID from tblPolicy";
                cmd.Connection = sqlCon;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    policies.Add(dr[0].ToString());
                }
            }

            return policies;
        }

        public List<string> returnProvider()
        {
            List<string> providers = new List<string>();
            int counter = 0;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ProviderId from Provider_table";
                cmd.Connection = sqlCon;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    providers.Add(dr[0].ToString());
                }
            }

            return providers;
        }

        public List<string> returnConditions()
        {
            List<string> conditions = new List<string>();
            int counter = 0;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Condition_ID from Medical_Condition";
                cmd.Connection = sqlCon;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    conditions.Add(dr[0].ToString());
                }
            }

            return conditions;
        }

        public List<string> returnConditionNames()
        {
            List<string> conditions = new List<string>();
            int counter = 0;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Medical_Condition from Medical_Condition";
                cmd.Connection = sqlCon;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    conditions.Add(dr[0].ToString());
                }
            }

            return conditions;
        }

        public List<string> returnTreatments()
        {
            List<string> treatments = new List<string>();
            int counter = 0;
            using (SqlConnection sqlCon = new SqlConnection(Conn))
            {
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT Treatment_Name from Treatments";
                cmd.Connection = sqlCon;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    treatments.Add(dr[0].ToString());
                }
            }

            return treatments;
        }

        public abstract void Create();





    }
}
