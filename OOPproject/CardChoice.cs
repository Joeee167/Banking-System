using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public partial class CardChoice : Form
    {
        Person p = null;
        public CardChoice()
        {
            InitializeComponent();
        }

        public CardChoice(Person person)
        {
            p = person;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DebitCardbt_Click(object sender, EventArgs e)
        {
            this.Hide();

            TransactionsMenu t = new TransactionsMenu(p);

            t.Show();
        }

        private void SavingsAccountbt_Click(object sender, EventArgs e)
        {
            this.Hide();

            SavingsAccountScreen savingsAccountScreen = new SavingsAccountScreen(p);

            savingsAccountScreen.Show();
        }
    }
}
