using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bank2;

namespace bank
{
    public class AccountInfo
    {

        
        public static void Main()
        {
            CheckingAccount bryan = new CheckingAccount("Mr. Bryan Walton", 11.99);

            bryan.Deposit(5.77);
            bryan.Withdraw(11.22);
            
            Console.WriteLine("current balance is ${0}", bryan.Balance);



        }
    }


}
