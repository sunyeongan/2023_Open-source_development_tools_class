using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public interface IAccount
    {
        double Balance { get; }
        void Withdraw(double amount);
        void Credit(double amount);

    }
}
