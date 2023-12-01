using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    interface IAccount
    {
        void Deposit(double amount);
        void Debit(double amount);
        void Credit(double amount);
        void ShowBalance();
    }
}
