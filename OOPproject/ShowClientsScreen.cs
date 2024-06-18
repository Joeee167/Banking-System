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
    public partial class ShowClientsScreen : Form
    {
        public Person p = null;

        public ShowClientsScreen()
        {
            InitializeComponent();
        }

        public ShowClientsScreen(Person person)
        {
            p = person;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClientsInfotx_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void ShowClientsScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void MainMenuBt_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu = new MainMenu(p);

            menu.Show();
        }
    }
}
