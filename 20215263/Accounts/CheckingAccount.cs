using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class CheckingAccount: IAccount
    {
        public readonly string customerName;
        public double balance;

        public CheckingAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else if (amount < 0) {
                throw new ArgumentException(nameof(amount), "amount is minus!");
            }
            else
            {
                throw new ArgumentException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }

        public string CostomerName
        {
            get { return customerName; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            if(amount > balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            balance -= amount;
        }

        static void Main(string[] args)
        {
        }
    }
}
