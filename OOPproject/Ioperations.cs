using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public interface Ioperations
    {
        void Deposit(float amount, Person person);
        void Withdraw(float amount, Person person);

    }
}
