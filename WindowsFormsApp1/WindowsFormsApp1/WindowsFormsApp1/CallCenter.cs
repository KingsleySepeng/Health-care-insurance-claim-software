using System;
using System.Collections.Generic;
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

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override void delete()
        {
            throw new NotImplementedException();
        }

        public void Login() { }

        public override void read()
        {
            throw new NotImplementedException();
        }

        public void Search() { }
        public DateTime StartCall()
        {
            return DateTime.Now;
        }

        public void EndCall(DateTime startTime)
        {
            MessageBox.Show(DateTime.Now.Subtract(startTime).ToString());
        }

        public override void update()
        {
            throw new NotImplementedException();
        }
      

    }
}
