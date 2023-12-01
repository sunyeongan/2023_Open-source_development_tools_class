using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class CheckingAccount : IAccount
    {
        AccountInfo acc;

        public CheckingAccount(string customerName, double balance)
        {
            acc = new AccountInfo(customerName, balance);
        }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            acc.m_balance += amount;
        }
        public void Debit(double amount)
        {
            if (amount > acc.m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            acc.m_balance -= amount;
        }
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            acc.m_balance -= amount;
        }
        public void ShowBalance()
        {
            Console.WriteLine("현재 잔액은 " + acc.m_balance + "입니다.");
        }
    }
}
