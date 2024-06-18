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
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_project
{
    public partial class DeleteClient : Form
    {
        public string acc;
        public Person p = null;
        public DeleteClient()
        {
            InitializeComponent();
        }

        public DeleteClient(Person person)
        {
            p = person;
            InitializeComponent();
        }


        private void AccountNumberIn_TextChanged(object sender, EventArgs e)
        {
             acc = AccountNumberIn.Text;


        }

        private void BackToMain_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu menu = new MainMenu(p);

            menu.Show();
        }

        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (p is Employee)
            {
                Employee employee = (Employee)p;

                employee.DeleteClient(this);
            }

            else
            {
                Admin admin = (Admin)p;

                admin.DeleteClient(this);

            }

        }
    }
}
