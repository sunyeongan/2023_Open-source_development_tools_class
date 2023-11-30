using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class CheckingAccount:IAccount
    {
        private readonly string m_customerName;
        private double m_balance;
        public CheckingAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }
        public void Withdraw(double amount)
        {
            if(m_balance>=amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
        public string CustomerName
    {
        get { return m_customerName; }
    }
        public double Balance
        {
            get { return m_balance; }
        }
        public void Deposit(double amount)
        {
            if(amount>m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance-=amount;  
        }
    }
}
