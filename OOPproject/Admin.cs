using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_project
{
    public class Admin : Employee
    {
       public Admin(string username,string password): base( username, password)
       {

       }

        public void ShowClients()
        {
            // Show Clients Info on loading the screen

            ShowClientsScreen clientsScreen = new ShowClientsScreen(this);  // creating ShowClientsScreen object
            clientsScreen.Show();

            string ClientsInfo = File.ReadAllText("Clients.txt");

            // ClientsInfotx is set as public to be accessed in " Admin class "
            clientsScreen.ClientsInfotx.Text = "Username   PIN\tName\t\tPhone\t\tDebit card   Savings account\r\n" + ClientsInfo.Replace("#//#", "\t");      
        }
    }
}
