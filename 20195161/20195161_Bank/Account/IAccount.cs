using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);

        double CheckAmount();
    }
}
