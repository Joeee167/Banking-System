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
    public partial class UpdateClientScreen : Form
    {
        public string acc;
        public Person p = null;
        public UpdateClientScreen()
        {
            InitializeComponent();
        }

        public UpdateClientScreen(Person person)
        {
            p=person;
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            acc = AccountNumberTx.Text;

        }

        private void UpdateBt_Click(object sender, EventArgs e)
        {
            

            // Search for a client with the entered account number

            bool flag = false;

            // 1. Read the content of the file
            string[] readText = File.ReadAllLines("Clients.txt");

            // 2. Search for the client in strings

            foreach (string s in readText)
            {

                if (s.Contains(acc))   
                {
                    flag = true;
                }
            }

            if (flag == false)
            {
                AccountNumberTx.ResetText();
                MessageBox.Show("Client NOT Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                this.Hide();
                UpdateInfo updateInfo = new UpdateInfo(acc, p);
                updateInfo.Show();
            }
        }

        private void MainMenuBt_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu = new MainMenu(p);

            menu.Show();
        }

        private void UpdateClientScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
