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
    public partial class frmProviderManagement : Form
    {
        DataHandler dh = new ProviderManagement();
        ProviderManagement pr = new ProviderManagement();
        bool Pressed;
        public frmProviderManagement()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display("Provider_table");
        }

        private void frmProviderManagement_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Pressed == false)
            {
                Pressed = true;
                grpDetails.Visible = true;
            }
            else
            {
                Pressed = false;
                grpDetails.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Search("Provider_table", txtSearch.Text, dataGridView1.Columns[1].Name);
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display("Provider_table");
            btnReset.Visible = false;
            txtSearch.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string timeLeft = pr.getContractLength("Provider_table", dataGridView1.Columns[0].Name, ID).ToString("%d");
            MessageBox.Show(timeLeft + " days left until contract runs out");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr.Create("Provider_table", txtName.Text, txtTelephone.Text, txtAddress.Text, comboBox1.Text, txtStartDate.Text, txtEndDate.Text);
            dataGridView1.DataSource = dh.Display("Provider_table");
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
