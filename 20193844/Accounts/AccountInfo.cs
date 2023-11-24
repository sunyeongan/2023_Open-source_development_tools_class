using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal class AccountInfo
    {
        public satic void Main()
        {
            CheckingAccount bryan = new("Mr. Bryan Walton", 11.99);

            bryan.Deposit(5.77);
            bryan.Withdraw(11.22);
            Console.WriteLine("Current balance is ${0}", bryan.Balance);
        }

    }
}
