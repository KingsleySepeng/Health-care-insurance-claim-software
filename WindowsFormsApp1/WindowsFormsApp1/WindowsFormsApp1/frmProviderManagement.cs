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
        bool Pressed = false;
        string newValue, columnName, tID;
        public frmProviderManagement()
        {
            InitializeComponent();
            dataGridView1.DataSource = dh.Display(pr.TableName);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int indx = dataGridView1.CurrentCell.ColumnIndex;
            columnName = dataGridView1.Columns[indx].Name;
            newValue = dataGridView1.CurrentCell.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pr.Update(pr.TableName, tID, columnName, newValue);
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
            if (Pressed)
            {
                Pressed = false;
                grpDetails.Visible = false;
            }
            else
            {
                Pressed = true;
                grpDetails.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Search(pr.TableName, txtSearch.Text, dataGridView1.Columns[1].Name);
            txtSearch.Clear();
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dh.Display(pr.TableName);
            btnReset.Visible = false;
            txtSearch.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            string timeLeft = pr.getContractLength(pr.TableName, dataGridView1.Columns[0].Name, ID).ToString("%d");
            MessageBox.Show(timeLeft + " days left until contract runs out");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pr.deletePM(txtSearch.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pr.Create(pr.TableName, txtName.Text, txtTelephone.Text, txtAddress.Text, comboBox1.Text, txtStartDate.Text, txtEndDate.Text);
            dataGridView1.DataSource = dh.Display(pr.TableName);
            txtAddress.Clear();
            txtEndDate.Clear();
            txtName.Clear();
            txtStartDate.Clear();
            txtTelephone.Clear();
            comboBox1.Text = "";
        }

        private void txtStartDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
