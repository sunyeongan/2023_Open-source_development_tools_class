using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);
        
    }
}
