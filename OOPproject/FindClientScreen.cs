using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class FindClientScreen : Form
    {
        public string acc;
        public Person p = null;

        public FindClientScreen()
        {
            InitializeComponent();
        }

        public FindClientScreen(Person person)
        {
            p=person;
            InitializeComponent();
        }

        private void BackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu = new MainMenu(p);

            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)  // Submit button
        {
            if (p is Employee)
            {
                Employee employee = (Employee)p;

                employee.FindClient(this);
            }

            else
            {
                Admin admin = (Admin)p;

                admin.FindClient(this);

            }

        }

        private void FindByAccountNumbertx_TextChanged(object sender, EventArgs e)
        {
            acc = FindByAccountNumbertx.Text;

        }
    }
}




