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
    //level 1 just medication
    //level 2 medication and some surgery
    //level 3 All services
    public partial class frmMedicalDepartment : Form
    {
        DataHandler dh = new MedicalDepartment();
        MedicalDepartment md = new MedicalDepartment();
        string conditionName, conditionCode, medicalName;
        string treatmentName, treatmentCost, treatmentType, policyID;
        public frmMedicalDepartment()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display("Medical_Condition");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool treatment = true;
            conditionName = txtConditionName.Text;
            conditionCode = txtMedicalCode.Text;
            medicalName = txtDescription.Text;

            md.Create("Medical_Condition", conditionName, medicalName, conditionCode);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display("Medical_Condition");
            btnAddConditionTreatment.Text = "Add Medical Conditions";
            grpMedicalConditions.Visible = true;
            grpTreatments.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display("Treatments");
            btnAddConditionTreatment.Text = "Add Treatments";
            grpTreatments.Visible = true;
            grpMedicalConditions.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
