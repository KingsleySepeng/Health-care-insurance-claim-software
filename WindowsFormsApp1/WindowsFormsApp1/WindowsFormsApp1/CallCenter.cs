using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class CallCenter:DataHandler
    {
        DateTime StartCall;
        DateTime EndCall;
        String ClientID;
        String MedicalCondition;
        String Treatment;

        public DateTime StartCall1 { get => StartCall; set => StartCall = value; }
        public DateTime EndCall1 { get => EndCall; set => EndCall = value; }
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
        public void StartEndCall() { }

        public override void update()
        {
            throw new NotImplementedException();
        }
      

    }
}
