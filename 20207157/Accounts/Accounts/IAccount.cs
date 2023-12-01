using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    internal interface IAccount
    {
        public void Withdraw(double amount);
        public void Deposit(double amount);
    }
}
