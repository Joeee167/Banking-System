using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_project
{
    public partial class LoginScreen : Form
    {
        public string username;
        public string password;
        


        public LoginScreen()
        {
            InitializeComponent();
        }

       

        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }

       

        private void LoginButton_Click(object sender, EventArgs e)  // Login Button
        {
            Person.Login(this,username, password);  // Call the login method " static " from person class
        }   

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            password = PasswordInput.Text;  // set password to user input " PasswordInput "
        }

        
        private void usernameInput_TextChanged(object sender, EventArgs e)
        {
            username = usernameInput.Text;  // set username to user input " usernameInput "

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }
    }
}
