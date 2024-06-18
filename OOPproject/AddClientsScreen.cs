using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace OOP_project
{
    
    public partial class AddClientsScreen : Form
    {
        // variables for client info

        public string accountNumber;
        public string password;
        public string PIN;
        public string ClientName;
        public string PhoneNumber;
        public string ClientBalance;
        public string SavingsBalance;

        public Person p = null;

        public AddClientsScreen()
        {
            InitializeComponent();
        }

        public AddClientsScreen(Person person)
        {
            p = person;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.accountNumber = AccountNumbertx.Text;  

        }

        private void passwordtx_TextChanged(object sender, EventArgs e)
        {
            password = passwordtx.Text;
        }

        private void Pintx_TextChanged(object sender, EventArgs e)
        {
            PIN = Pintx.Text;  
        }

        private void Nametx_TextChanged(object sender, EventArgs e)
        {
            ClientName =  Nametx.Text;  
        }

        private void PhoneNumbrtx_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber =  PhoneNumbrtx.Text;  
        }

        private void AccountBalancetx_TextChanged(object sender, EventArgs e)
        {
            ClientBalance =  AccountBalancetx.Text ; 
        }
        private void Savingstx_TextChanged(object sender, EventArgs e)
        {
            SavingsBalance = Savingstx.Text ;
        }



        private void button1_Click(object sender, EventArgs e)  // Submit Button
        {

            if(p is Employee)
            {
                Employee employee = (Employee)p;

                employee.AddClient(this);
            }

            else
            {
                Admin admin = (Admin)p;

                admin.AddClient(this);

            }
            
            
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu= new MainMenu(p);

            menu.Show();
        }

        private void AddClientsScreen_Load(object sender, EventArgs e)
        {

        }

        
    }
}
