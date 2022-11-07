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
    public partial class frmCallCenter : Form
    {
        CallCenter callcenter = new CallCenter();
        DateTime startTime;
        DataHandler dh = new CallCenter();
        public frmCallCenter()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display("Claim");
        }

        private void frmCallCenter_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            callcenter.EndCall(startTime);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            startTime = callcenter.StartCall();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}