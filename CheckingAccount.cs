using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public class CheckingAccount:AccountInfo 
    {
        public CheckingAccount()
        {
            m_balance = 0;
            m_customername = "";
        }
        public CheckingAccount(string customername,double balance)
        {
            m_customername = customername;
            m_balance = balance;

        }
        public void Deposit(double amount) {//입금
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance = m_balance + amount; 
        }
     
        public void Withdraw(double amount) ///출금
        {
            if (m_balance >= amount)
            {
                m_balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdraw exceeds balance!");
            }
        }
        public string CustomerName//이름 조회
        {
            get { return m_customername; }
        }
        public double Balance//잔액 조회 
        { 
            get { return m_balance; }
        }

    }
}
