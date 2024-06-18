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
using System.Security.Cryptography;

namespace OOP_project
{
    public partial class MainMenu : Form
    {
        public Person p = null;
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(Person person)
        {
            p = person;
            InitializeComponent();


            if (!(p is Admin))
            {
                ShowClients.Enabled = false;    // if person is not an admin , Show Clients button is locked

            }

            if(p is Client)
            {
                AddClients.Enabled = false; // if person is client , Add Clients button is enabled
                FindClient.Enabled = false; // if person is client , Find Clients button is enabled
                DeleteClient.Enabled = false; // if person is client , Delete Clients button is enabled

            }

            if (!(p is Client))
            {
                Transactions.Enabled = false;
            }

           

        }

        private void button1_Click(object sender, EventArgs e)      // Show Clients Button
        {
            

            if(p is Admin)
            {
                this.Hide();
                Admin admin = (Admin)p;

                admin.ShowClients();
            }

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            // Back to login screen when clicking " LogOut Button "

            LoginScreen login = new LoginScreen();

            this.Hide();
            login.Show();
        }

        private void AddClients_Click(object sender, EventArgs e)
        {
            // Move to add clients screen when clicking " Add Clients " 

            AddClientsScreen add = new AddClientsScreen(p);
            this.Hide();
            add.Show();
           
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            // Show Delete Client Screen

            this.Hide();

            DeleteClient delete = new DeleteClient(p);

            delete.Show();
        }

        private void FindClient_Click(object sender, EventArgs e)
        {
            this.Hide();

            FindClientScreen find = new FindClientScreen(p);

            find.Show();
        }

        private void UpdateClients_Click(object sender, EventArgs e)
        {
            if (p is Client)
            {
                Client c = (Client)p;
                this.Hide();
                UpdateInfo updateInfo = new UpdateInfo(c.AccountNumber, p);
                updateInfo.Show();
            }
            else

            {
                this.Hide();

                UpdateClientScreen update = new UpdateClientScreen(p);

                update.Show();
            }
  
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            CardChoice CardChoiceScreen = new CardChoice(p);
            this.Hide();
            CardChoiceScreen.Show();
        }
    }
}
