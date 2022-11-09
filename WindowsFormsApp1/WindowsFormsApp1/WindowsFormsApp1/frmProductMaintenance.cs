using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class frmProductMaintenance : Form
    {
        DataHandler dh = new ProductMaintenance();
        ProductMaintenance pr = new ProductMaintenance();
        float totalCost;
        bool Pressed = false;
        string columnName, tID, newValue;
        public frmProductMaintenance()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display("tblPolicy");
            btnReset.Visible = false;
            txtCost.Text = totalCost.ToString();
        }

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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

            if(Pressed == false)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display("tblPolicy");
            btnReset.Visible = false;
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {
            lblDateHint.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            if (txtSearch.Text != "")
            {
                dataGridView1.DataSource = dh.Search("tblPolicy", txtSearch.Text, dataGridView1.Columns[0].Name);
                btnReset.Visible = true;
            }
            else
            {
                MessageBox.Show("Warning", "Cannot leave search bar empty!!", MessageBoxButtons.OK);
                txtSearch.Focus();
            }
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr.Update(pr.tableName, tID, columnName, newValue);
        }

        private void cmbPolicyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPolicyType.SelectedIndex == 2)
            {
                totalCost = pr.BasicPolicyPrice;
            }
            else if(cmbPolicyType.SelectedIndex == 1)
            {
                totalCost = pr.MiddlePolicyPrice;
            }
            else if (cmbPolicyType.SelectedIndex == 0)
            {
                totalCost = pr.PremiumPolicyPrice;
            }
            txtCost.Text = totalCost.ToString();
            cmbCareLevel.Enabled = true;   
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int indx = dataGridView1.CurrentCell.ColumnIndex;
            columnName = dataGridView1.Columns[indx].Name;
            newValue = dataGridView1.CurrentCell.Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr.deletePo(txtSearch.Text);
        }

        private void cmbCareLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalCost = (float)pr.calcPolicyPrice(totalCost, cmbCareLevel.Text);
            txtCost.Text = totalCost.ToString();
        }

        private void txtSubmit_Click(object sender, EventArgs e)
        {
            string startDate, endDate;
            float price = Convert.ToSingle(txtCost.Text);
            startDate = txtStartDate.Text;
            endDate = txtEndDate.Text;
            pr.Create("tblPolicy", pr.CreateID(DateTime.Now.Year.ToString(), cmbPolicyType.Text.Substring(0, 1), cmbCareLevel.Text), price, startDate, endDate, txtPolicyName.Text, cmbPolicyType.Text);
            dataGridView1.DataSource = dh.Display("tblPolicy");
            txtCost.Clear();
            txtEndDate.Clear();
            txtStartDate.Clear();
            txtPolicyName.Clear();
            cmbCareLevel.Text = "";
            cmbPolicyType.Text = "";
        }
    }
}
