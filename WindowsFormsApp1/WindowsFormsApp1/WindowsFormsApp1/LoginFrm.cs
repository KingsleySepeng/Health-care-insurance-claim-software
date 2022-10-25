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
            string Password, Username, depString;
            string[] Usernames = {"Sarah Moer", "Trevor De Klerk", "John Doe", "Sipho Skhosana", "Mbali Gumede"};
            string[] Passwords = { "3456pm", "8903pc", "7854pr", "1234md", "3254cc" };
            bool userDetails = false;

            Username = textBox2.Text;
            Password = textBox3.Text;

            depString = Password.Substring(Password.Length - 2, 2);
            MessageBox.Show(depString);
            for (int i = 0; i <= 6; i++)
            {
                if ((Username == Usernames[i]) & (Password == Passwords[i]))
                {
                    userDetails = true;
                    if (depString == "cc")
                    {
                        callCenter.Show();
                        this.Hide();
                    }
                    else if (depString == "md")
                    {
                        medicalDepartment.Show();
                        this.Hide();
                    }
                    else if (depString == "pr")
                    {
                        providerManagement.Show();
                        this.Hide();
                    }
                    else if (depString == "pm")
                    {
                        productMaintenance.Show();
                        this.Hide();
                    }
                    else if (depString == "pc")
                    {
                        policyClient.Show();
                        this.Hide();
                    }
                }
                else
                {
                    userDetails = false;
                }
            }
            if (userDetails)
            {
                MessageBox.Show("Welcome User");
            }
            else
            {
                MessageBox.Show("Incorrect user details entered");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
