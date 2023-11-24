using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    internal interface IAccount
    {
        void Deposit(decimal amount);

        void Withdraw(decimal amount);

        decimal GetBalance();
    }
}
