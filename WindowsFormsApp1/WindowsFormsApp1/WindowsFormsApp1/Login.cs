using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Login: DataHandler
    {
        public bool CheckUserDetails(string Username, string Password)
        {
            string[] Usernames = { "Sarah Moer", "Trevor De Klerk", "John Doe", "Sipho Skhosana", "Mbali Gumede" };
            string[] Passwords = { "3456pm", "8903pc", "7854pr", "1234md", "3254cc" };
            bool userDetails = false;

            for (int i = 0; i <= 4; i++)
            {
                if ((Username == Usernames[i]) & (Password == Passwords[i]))
                {
                    userDetails = true;
                }

            }

            if (userDetails == false)
            {
                MessageBox.Show("Invalid Username or Password!!!");
            }

            return userDetails;
        }

        public override void Create()
        {
            throw new NotImplementedException();
        }

        public void OpenForm(string departmentCode)
        {
            
        }
    }
}
