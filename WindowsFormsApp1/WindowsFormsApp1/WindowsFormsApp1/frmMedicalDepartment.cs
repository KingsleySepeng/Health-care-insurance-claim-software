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
    public partial class frmMedicalDepartment : Form
    {
        DataHandler dh = new MedicalDepartment();
        MedicalDepartment md = new MedicalDepartment();
        string columnName;
        bool treatment = false;
        public frmMedicalDepartment()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display(md.Tablename);
            cmbPolicy.DataSource = dh.returnPolicies();
            cmbProvider.DataSource = dh.returnProvider();
            cmbConditions.DataSource = dh.returnConditions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginFrm login = new LoginFrm();
            login.Show();
            this.Hide();
        }

        private void frmMedicalDepartment_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (treatment)
            {
                dataGridView1.DataSource = dh.Display(md.TblTreatments);
            }
            else
            {
                dataGridView1.DataSource = dh.Display(md.Tablename);
            }
            btnReset.Visible = false;
            txtSearch.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            columnName = dataGridView1.Columns[0].Name;
            btnReset.Visible = true;
            if (treatment)
            {
                dataGridView1.DataSource = dh.Search(md.TblTreatments, txtSearch.Text, columnName);
            }
            else
            {
                dataGridView1.DataSource = dh.Search(md.Tablename, txtSearch.Text, columnName);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            md.Create(md.Tablename, txtConditionName.Text, txtDescription.Text, txtMedicalCode.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treatment == false)
            {
                md.Create(md.Tablename, txtConditionName.Text, txtDescription.Text, txtMedicalCode.Text);
                dataGridView1.DataSource = dh.Display(md.Tablename);
                txtConditionName.Clear();
                txtDescription.Clear();
                txtMedicalCode.Clear();
                
            }
            else
            {
                md.Create(md.TblTreatments, txtTreatmentName.Text, Convert.ToSingle(txtCost.Text), cmbPolicy.Text, Convert.ToInt32(txtNumDays.Text), cmbConditions.Text, cmbProvider.Text);
                dataGridView1.DataSource = dh.Display(md.TblTreatments);
                txtNumDays.Clear();
                txtTreatmentName.Clear();
                txtCost.Clear();
                cmbProvider.Text = "";
                cmbDescription.Text = "";
                cmbConditions.Text = "";
                cmbPolicy.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treatment)
            {
                treatment = false;
                dataGridView1.DataSource = dh.Display(md.Tablename);
                btnSwitch.Text = "View Medical Conditions";
                btnAddConditionTreatment.Text = "Add Medical Condition";
                grpMedicalConditions.Visible = true;
                grpTreatments.Visible = false;
            }
            else
            {
                treatment = true;
                dataGridView1.DataSource = dh.Display(md.TblTreatments);
                btnSwitch.Text = "View Treatments";
                btnAddConditionTreatment.Text = "Add Treatments";
                grpMedicalConditions.Visible = false;
                grpTreatments.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display(md.TblTreatments);
            btnAddConditionTreatment.Text = "Add Treatments";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
