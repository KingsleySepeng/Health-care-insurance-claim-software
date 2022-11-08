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
        string clientID, PolicyID, claimStatus;
        bool claimed = false;
        public frmCallCenter()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display("Claim");
            cmbCondition.DataSource = dh.returnConditionNames();
        }

        private void frmCallCenter_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime endTime = callcenter.EndCall(startTime);
            callcenter.Create(callcenter.CallTable, startTime, endTime);
            
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display(callcenter.TableName);
            btnReset.Visible = false;
            txtSearch.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dataGridView1.DataSource = dh.Search(callcenter.TableName, txtSearch.Text, dataGridView1.Columns[2].Name);
                btnReset.Visible = true;
            }
            else
            {
                MessageBox.Show("Warning", "Cannot leave search bar empty!!", MessageBoxButtons.OK);
                txtSearch.Focus();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                claimed = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTreatments.DataSource = callcenter.getTreatments(cmbCondition.Text);
            cmbTreatments.Enabled = true;
        }

        private void cmbTreatments_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbProviders.DataSource = callcenter.getProviders(cmbTreatments.Text);
            cmbProviders.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            btnCreateClaim.Enabled = true; 
            clientID = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            PolicyID = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (claimed)
            {
                claimStatus = callcenter.CheckClaim(PolicyID, cmbCondition.Text);
                MessageBox.Show("Claim "+claimStatus+".", "Information", MessageBoxButtons.OKCancel);
            }
            else
            {
                claimStatus = "Fill form";
                MessageBox.Show("A claim form will be sent to the client\'s email", "Information", MessageBoxButtons.OKCancel);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                claimed=false;
            }
        }
    }
}