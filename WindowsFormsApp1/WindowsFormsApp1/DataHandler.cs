using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public abstract class DataHandler
    {
        public abstract void Create();
        public abstract void read();
        public abstract void update();
        public abstract void delete();

    }
}
