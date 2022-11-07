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
        DataHandler dh = new ClientPolicyMaintenance();
        ClientPolicyMaintenance cp = new ClientPolicyMaintenance();
        bool Pressed = false, familyPlan = false;
        string ID, DepName, DepSname, DepRelation, Age;
        float initialCost, totalCost;
        public frmPolicy_Client_Maintenance()
        {
            InitializeComponent();
            int i = 1;
            dataGridView1.DataSource = dh.Display("Policy_Holders");
            btnReset.Visible = false;
            ID = cp.createID();
            cmbPolicy.DataSource = dh.returnPolicies();
            cmbPolicy.Text = "-- Select --";
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

        private void frmPolicy_Client_Maintenance_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                dataGridView1.DataSource = dh.Search("Policy_holders", txtSearch.Text, dataGridView1.Columns[0].Name);
                btnReset.Visible = true;
            }
            else
            {
                MessageBox.Show("Warning", "Cannot leave search bar empty!!", MessageBoxButtons.OK);
                txtSearch.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display("Policy_Holders");
            btnReset.Visible = false;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cp.Create("Sub_Holders", DepName, DepSname, DepRelation, Age, ID);
            txtDepName.Clear();
            txtDepRelation.Clear();
            txtDepSurname.Clear();
            button2.Visible = true;
        }

        private void txtAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtAge.SelectedIndex == 0)
            {
                totalCost += initialCost / 2;
            }
            else
            {
                totalCost += initialCost;
            }
            txtMontlyFee.Text = totalCost.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            initialCost = cp.calcMonthlyFee(cmbPolicy.Text);
            totalCost = initialCost;
            txtMontlyFee.Text = totalCost.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (familyPlan)
            {
                cp.Create("Policy_Holders", ID, txtName.Text, txtSurname.Text, txtNumber.Text, txtAddress.Text, cmbPolicy.Text, Convert.ToSingle(txtMontlyFee.Text), familyPlan.ToString());
                dataGridView1.DataSource = dh.Display("Policy_Holders");
                txtAddress.Clear();
                txtName.Clear();
                txtNumber.Clear();
                txtSurname.Clear();
            }
            else
            {
                cp.Create("Policy_Holders", ID, txtName.Text, txtSurname.Text, txtNumber.Text, txtAddress.Text, cmbPolicy.Text, Convert.ToSingle(txtMontlyFee.Text), familyPlan.ToString());
                dataGridView1.DataSource = dh.Display("Policy_Holders");
                txtAddress.Clear();
                txtName.Clear();
                txtNumber.Clear();
                txtSurname.Clear();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbFamilyPlan.SelectedIndex == 0)
            {
                grpDetails.Visible = false;
                grpDependents.Visible = true;
                familyPlan = true;
            }
            else
            {
                familyPlan = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            grpDetails.Visible = true;
            grpDependents.Visible = false;
            DepName = txtDepName.Text;
            DepSname = txtDepSurname.Text;
            DepRelation = txtDepRelation.Text;
            Age = txtAge.Text;
        }
    }
}
