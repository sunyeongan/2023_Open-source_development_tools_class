using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class AccountInfo
    {
        public string AccountHolderName { get; }
        public double Balance { get; }

        public static void Main()
        {
            var account = new CheckingAccount("JohnDoe", 100.0);

            account.Deposit(10.77);
            account.Withdraw(50.0);
        }
    }
}
