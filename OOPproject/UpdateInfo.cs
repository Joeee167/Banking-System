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
    
    public partial class UpdateInfo : Form
    {
        // variables for client info

        public string accountNumber;
        public string PIN;
        public string ClientName;
        public string PhoneNumber;
        public string ClientBalance;
        public string updatedInfo;
        public string Savingsbalance;

        public Person p = null;

        public UpdateInfo(string accountNum,Person person)
        {
            InitializeComponent();
            accountNumber = accountNum;
            p=person;
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Savingtx_TextChanged(object sender, EventArgs e)
        {

            Savingsbalance = Savingtx.Text;
        }


        private void button1_Click(object sender, EventArgs e)  // Submit button
        {
            p.UpdateClient(this);
   
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu= new MainMenu(p);

            menu.Show();
        }

        // Load the screen with ReadOnly TextBox with the client's account number

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            this.AccountNumbertx.Text = accountNumber;
        }

       
    }
}
