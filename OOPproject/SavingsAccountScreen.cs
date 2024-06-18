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
    public partial class SavingsAccountScreen : Form
    {
        public Person p = null;
        public float amount;
        public float interest;
        public SavingsAccountScreen()
        {
            InitializeComponent();
        }

        public SavingsAccountScreen(Person person)
        {
            p = person;
            InitializeComponent();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            Client c = (Client)p;
            amount = float.Parse(AmountTx.Text);

            c.savingAccount.Withdraw(amount,p);
        }

        private void TransactionsMenu_Load(object sender, EventArgs e)
        {

        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenu m=new MainMenu(p);

            m.Show();
        }

        private void AmountTx_TextChanged(object sender, EventArgs e)
        {
            if(AmountTx.Text == "-")
            {
                MessageBox.Show("Can't enter negative number");
                AmountTx.ResetText();
            }

            

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            Client c = (Client)p;

            amount = float.Parse(AmountTx.Text);

            c.savingAccount.Deposit(amount,p);
        }

        private void Monthlybt_Click(object sender, EventArgs e)
        {
            Client c = (Client)p;

            interest = c.savingAccount.CalcMonth();

            MessageBox.Show(string.Format("Your monthly interest is {0:C}",interest));
        }
    }
}
