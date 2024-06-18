using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace OOP_project
{
    public class Employee : Person
    {
        public Employee(string username, string password) : base(username, password)
        {

        }

        public void AddClient(AddClientsScreen client)
        {
            bool flag = false;  // flag to check if a user is found with the entered username and password


            foreach (string line in System.IO.File.ReadAllLines("ClientsLogin.txt"))
            {
                if (line.Contains(client.accountNumber))    // Contains " searches in file for a required value "
                {

                    MessageBox.Show("Client with the same account number already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    flag = true;
                }
            }


            if (flag == false)
            {
                string ClientInfo = "\r\n" + client.accountNumber + "#//#" + client.password;
                System.IO.File.AppendAllText("ClientsLogin.txt", ClientInfo);


                ClientInfo = "\r\n" + client.accountNumber + "#//#" + client.PIN + "#//#" + client.ClientName + "#//#" + client.PhoneNumber + "#//#" + client.ClientBalance +"#//#"+ client.SavingsBalance;
                System.IO.File.AppendAllText("Clients.txt", ClientInfo);
                MessageBox.Show("Client added successfully!");

            }

            

        }

        public void FindClient(FindClientScreen client)
        {
            // Search for a client with the entered account number

            bool flag = false;

            // 1. Read the content of the file
            string[] readText = File.ReadAllLines("Clients.txt");

            // 2. Search for the client in strings

            foreach (string s in readText)
            {

                if (s.Contains(client.acc))    // add string to file except the one with the entered account number
                {

                    MessageBox.Show(s.Replace("#//#", "\t"));
                    flag = true;
                }
            }

            if (flag == false)
            {
                client.FindByAccountNumbertx.ResetText();
                MessageBox.Show("Client NOT Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteClient(DeleteClient client)
        {
            // Remove line with the entered account number

            bool flag = false;

            foreach (string line in System.IO.File.ReadAllLines("Clients.txt"))
            {

                if (line.Contains(client.acc))    // Contains " searches in file for a required value "
                {
                    flag = true;
                }
            }


            if (flag == false)
                MessageBox.Show("NOT Found");

            else
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete this client?", "Warning", MessageBoxButtons.YesNo);

                if (d == DialogResult.Yes)
                {

                    // 1. Read the content of the file
                    string[] readText = File.ReadAllLines("Clients.txt");

                    // 2. Empty the file
                    File.WriteAllText("Clients.txt", String.Empty);

                    // 3. Fill up again, but without the deleted line
                    using (StreamWriter writer = new StreamWriter("Clients.txt"))
                    {
                        foreach (string s in readText)
                        {


                            if (!s.Contains(client.acc))    // add string to file except the one with the entered account number
                            {

                                writer.WriteLine(s);

                            }
                        }
                    }

                    MessageBox.Show("Client Deleted Successfully");

                }

                else
                {
                    client.AccountNumberIn.ResetText();
                }
            }
        }
    }
}
