using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public class SavingsAccount : Ioperations
    {
        public float Balance;
        public static float InterestRate=0.1f;
        public SavingsAccount(float Balance)
        {
            this.Balance = Balance;
        }
        public void Deposit(float amount, Person person)
        {
            if (amount > 0)
            {
                Client c = (Client)person;

                Balance += amount;

                string[] readtext = File.ReadAllLines("Clients.txt");
                File.WriteAllText("Clients.txt", string.Empty);

                using (StreamWriter writer = new StreamWriter("Clients.txt"))
                {
                    foreach (string s in readtext)
                    {
                        if (!s.Contains(c.PIN))
                        {
                            writer.WriteLine(s);
                        }
                        else
                        {
                            writer.WriteLine(c.AccountNumber + "#//#" + c.PIN + "#//#" + c.ClientName + "#//#" + c.PhoneNumber + "#//#" + c.debitCard.Accountbalance + "#//#" + Balance);
                        }
                    }
                }

                MessageBox.Show("Balance Updated Successfully!");
            }

            else
            {
                MessageBox.Show("Negative Value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void Withdraw(float amount, Person person)
        {
            Client c = (Client)person;
            if (1.1*amount <= Balance)
            {
                DialogResult d = MessageBox.Show(string.Format("Are you sure you want to withdraw this amount? (an additional fees of {0} will be withdrawn)",0.1*amount), "Warning", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)

                {
                    Balance -= (float)1.1*amount ;

                    string[] readtext = File.ReadAllLines("Clients.txt");
                    File.WriteAllText("Clients.txt", string.Empty);

                    using (StreamWriter writer = new StreamWriter("Clients.txt"))
                    {
                        foreach (string s in readtext)
                        {
                            if (!s.Contains(c.PIN))
                            {
                                writer.WriteLine(s);
                            }
                            else
                            {
                                writer.WriteLine(c.AccountNumber + "#//#" + c.PIN + "#//#" + c.ClientName + "#//#" + c.PhoneNumber + "#//#" + c.debitCard.Accountbalance + "#//#" + Balance);
                            }
                        }
                    }

                    MessageBox.Show("Balance Updated Successfully!");
                }
            }

            else
            {
                MessageBox.Show("Not Enough Balance!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public float CalcMonth()
        {
            return 0.1f * Balance;
        }
    }
}
