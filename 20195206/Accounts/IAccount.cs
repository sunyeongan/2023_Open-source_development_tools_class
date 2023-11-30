using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public interface IAccount
    {
        public void Deposit(double amount); // 입금
        public void Withdraw(double amount); // 출금
    }
}
