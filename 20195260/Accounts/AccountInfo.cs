﻿using System;
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
            CheckingAccount bryan = new CheckingAccount("Mr. Bryan Walton", 11.99);

            bryan.Credit(5.77);
            bryan.Deposit(11.22);
            Console.WriteLine("Current balance is ${0}", bryan.Balance);
        }
    }
}
