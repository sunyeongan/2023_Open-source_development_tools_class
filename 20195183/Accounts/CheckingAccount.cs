using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class CheckingAccount : IAccount
    {
        double balance;

        public double Balance 
        { 
            get { return this.balance; } 
        }
        public void Withdraw(double amount)
        {
            if(balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
        public void Credit(double amount)
        {
            if (balance > 0)
            {
                balance += amount;
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Balance is minus!");
            }
        }
    }
}
