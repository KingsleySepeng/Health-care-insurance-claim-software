using System;
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
        String ClientID;
        String MedicalCondition;
        String Treatment;

        public string ClientID1 { get => ClientID; set => ClientID = value; }
        public string MedicalCondition1 { get => MedicalCondition; set => MedicalCondition = value; }
        public string Treatment1 { get => Treatment; set => Treatment = value; }


        public void Search() { }
        public DateTime StartCall()
        {
            MessageBox.Show("Call recording started...");
            return DateTime.Now;
        }

        public void EndCall(DateTime startTime)
        {
            MessageBox.Show("Call ended.\nTotal call length: "+DateTime.Now.Subtract(startTime).ToString("hh\\:mm\\:ss"));
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }
    }
}
