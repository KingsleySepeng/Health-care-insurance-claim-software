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
    public partial class LoginFrm : Form
    {
        Login login = new Login();
        frmCallCenter callCenter = new frmCallCenter();
        frmMedicalDepartment medicalDepartment = new frmMedicalDepartment();
        frmPolicy_Client_Maintenance policyClient = new frmPolicy_Client_Maintenance();
        frmProductMaintenance productMaintenance = new frmProductMaintenance();
        frmProviderManagement providerManagement = new frmProviderManagement();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = textBox2.Text;
            string Password = textBox3.Text;
            string departmentCode = Password.Substring(Password.Length - 2, 2);

            if (login.CheckUserDetails(Username, Password))
            {
                if (departmentCode == "cc")
                {
                    callCenter.Show();
                }
                else if (departmentCode == "md")
                {
                    medicalDepartment.Show();
                }
                else if (departmentCode == "pr")
                {
                    providerManagement.Show();
                }
                else if (departmentCode == "pm")
                {
                    productMaintenance.Show();
                }
                else if (departmentCode == "pc")
                {
                    policyClient.Show();
                }
                this.Hide();
            }
            
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
