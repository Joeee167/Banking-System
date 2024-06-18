using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOP_project
{
    public class DebitCard : Ioperations
    {
        public float Accountbalance;

        public DebitCard(float accountbalance)
        {
            Accountbalance = accountbalance;
        }

        public void Withdraw(float amount,Person person)
        {
            Client c = (Client)person;
            if(amount<=Accountbalance)
            {
                Accountbalance-=amount;

                string[] readtext = File.ReadAllLines("Clients.txt");
                File.WriteAllText("Clients.txt",string.Empty);

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
                            writer.WriteLine(c.AccountNumber + "#//#" + c.PIN + "#//#" + c.ClientName + "#//#" + c.PhoneNumber + "#//#" + Accountbalance + "#//#" + c.savingAccount.Balance);
                        }
                    }
                }

                MessageBox.Show("Balance Updated Successfully!");
            }

            else
            {
                MessageBox.Show("Not Enough Balance!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Deposit(float amount,Person person)
        {

            if(amount>0)
            {
                Client c = (Client)person;

                Accountbalance += amount;

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
                            writer.WriteLine(c.AccountNumber + "#//#" + c.PIN + "#//#" + c.ClientName + "#//#" + c.PhoneNumber + "#//#" + Accountbalance+"#//#" + c.savingAccount.Balance);
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
    }
}
