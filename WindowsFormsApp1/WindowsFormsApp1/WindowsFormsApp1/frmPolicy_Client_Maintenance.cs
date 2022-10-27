using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmPolicy_Client_Maintenance : Form
    {
        public frmPolicy_Client_Maintenance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] firstChar = { 'h', 'g', 'k', 'l', 'j' };
            string primaryKey = "j";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                primaryKey += Convert.ToString(random.Next(9));
            }
            MessageBox.Show(primaryKey);

        }

        private void frmPolicy_Client_Maintenance_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Close();
        }
    }
}
