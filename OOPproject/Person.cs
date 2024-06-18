using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.IO;

namespace OOP_project
{
    public class Person
    { 
        public string UserName { get; set; }
        public string Password { get; set; }
       

        public Person(string userName, string password)
        {
            UserName = userName;
            Password = password;
            
        }

        public Person()
        {
            
        }


        public static void Login( LoginScreen login , string UserName , string Password )
        {
            bool flag = false;  // flag to check if admin,employee or client is found with the entered username and password

            Person person = null;


            foreach (string line in System.IO.File.ReadAllLines("Admins.txt"))
            {
                if (line.Contains(UserName + "#//#" + Password))    // Contains " searches in file for a required value "
                {

                    person = new Admin(UserName,Password);
                    flag = true;
                }
            }


            if (flag == false)
            {
                foreach (string line in System.IO.File.ReadAllLines("Employee.txt"))
                {
                    if (line.Contains(UserName + "#//#" + Password))    // Contains " searches in file for a required value "
                    {
                        person = new Employee(UserName, Password);
                        flag = true;
                    }
                }
            }

            if (flag == false)
            {
                foreach (string line in System.IO.File.ReadAllLines("ClientsLogin.txt"))
                {
                    if (line.Contains(UserName + "#//#" + Password))   // if client is found , search in clients find to get his data
                    {
                        

                        // 1. Read the content of the file
                        string[] readText = File.ReadAllLines("Clients.txt");

                        // 2. Search for the client in strings

                        foreach (string s in readText)
                        {

                            if (s.Contains(UserName))    
                            {
                                string s1 = s;

                                string[] ClientData= new string[6];

                                for (int i=0;i<5;i++)
                                {
                                    ClientData[i] = s1.Substring(0, s1.IndexOf("#//#"));  // Split the client data to send it to the constructor
                                    s1 = s1.Remove(0, ClientData[i].Length + 4);
                                }

                                ClientData[5] = s1;  // Savings Account balance has no seperator after it

                                person = new Client(ClientData[0], ClientData[1], ClientData[2], ClientData[3], float.Parse(ClientData[4]), float.Parse(ClientData[5]));

                                flag = true;
                            }
                        }

                        
                      
                    }
                }
            }

            if(flag == false)
            {
                MessageBox.Show("Not Found","Warning",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                login.Hide();
                MainMenu menu1 = new MainMenu(person);
                menu1.Show();

            }

        }

        public void UpdateClient(UpdateInfo update)
        {
            // update client info in file

            update.updatedInfo = update.accountNumber + "#//#" + update.PIN + "#//#" + update.ClientName + "#//#" + update.PhoneNumber + "#//#" + update.ClientBalance + "#//#" + update.Savingsbalance;



            DialogResult d = MessageBox.Show("Are you sure you want to update this client?", "Warning", MessageBoxButtons.YesNo);

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


                        if (!s.Contains(update.accountNumber))    
                        {

                            writer.WriteLine(s);

                        }

                        else
                        {
                            writer.WriteLine(update.updatedInfo);
                        }
                    }
                }

                MessageBox.Show("Client updated Successfully");

            }

            else
            {
                update.Hide();

                MainMenu menu = new MainMenu(this);

                menu.Show();
            }

        }
    }
}
