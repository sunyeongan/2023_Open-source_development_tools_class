using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public class AccountInfo
    {
        
        public static void Main()
        {
            CheckingAccount ba = new CheckingAccount("Mr. Bryan Walton", 11.99);

            ba.Withdraw(5.77);
            ba.Deposit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }

}
