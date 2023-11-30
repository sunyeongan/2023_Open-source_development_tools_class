using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class AccountInfo
    {
        public static void Main()
        {
            CheckingAccount kim = new CheckingAccount("kim", 11.99);

            kim.Deposit(5.77);
            kim.Withdraw(11.22);
            Console.WriteLine("Current balance is ${0}", kim.Balance);

        }
    }
}
