using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginFrm : Form
    {
        DataHandler dh = new Login();
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text;
            string Password = txtPassword.Text;

            if((Password == "") || (Password.Length != 6))
            {
                MessageBox.Show("Warning", "Invalid passwrd input", MessageBoxButtons.OK);
                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                string depCode = Password.Substring(4, 2);
                if (dh.login(Username, Password))
                {
                    if (depCode == "pm")
                    {
                        frmProductMaintenance pm = new frmProductMaintenance();
                        pm.Show();

                    }
                    else if (depCode == "cc")
                    {
                        frmCallCenter cc = new frmCallCenter();
                        cc.Show();
                    }
                    else if (depCode == "pc")
                    {
                        frmPolicy_Client_Maintenance pc = new frmPolicy_Client_Maintenance();
                        pc.Show();
                    }
                    else if (depCode == "md")
                    {
                        frmMedicalDepartment md = new frmMedicalDepartment();
                        md.Show();
                    }
                    else if (depCode == "pr")
                    {
                        frmProviderManagement pr = new frmProviderManagement();
                        pr.Show();
                    }

                    this.Hide();

                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
