using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class Client : Person
    {
        public string AccountNumber;
        public string ClientName;
        public string PhoneNumber;
        public string PIN;


        public DebitCard debitCard;
        public SavingsAccount savingAccount;

        public Client(string username ,string PIN , string ClientName , string PhoneNumber , float AccountBalance,float Savings) : base()
        {
            this.AccountNumber = username;
            this.ClientName = ClientName;
            this.PhoneNumber = PhoneNumber;
            this.PIN = PIN;

            debitCard = new DebitCard(AccountBalance);
            savingAccount = new SavingsAccount(Savings);

        }
    }
}
