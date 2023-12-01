using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{


    internal class CheckingAccount
    {
        private double m_balance;
        public CheckingAccount(double balance)
        {
            m_balance = balance;
        }
        public void Withdraw(double amount)
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
        public void Deposit(double amount)
        {
            if(amount > m_balance.balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }
    }
}
