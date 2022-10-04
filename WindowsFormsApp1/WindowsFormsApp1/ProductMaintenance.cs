using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ProductMaintenance:DataHandler
    {
        float MoneySpent;
        float MoneyEarned;
        int NumberClients;
        float profit;

        public float MoneySpent1 { get => MoneySpent; set => MoneySpent = value; }
        public float MoneyEarned1 { get => MoneyEarned; set => MoneyEarned = value; }
        public int NumberClients1 { get => NumberClients; set => NumberClients = value; }
        public float Profit { get => profit; set => profit = value; }

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
        }
  
    }
}
