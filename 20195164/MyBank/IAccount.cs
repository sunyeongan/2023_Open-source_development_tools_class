using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public interface IAccount
    {
        string AccountHolderName { get; }
        double Balance { get; }
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
