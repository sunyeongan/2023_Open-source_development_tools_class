using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class CheckingAccount : IAccount
    {
        public string AccountHolderName { get; }
        public double Balance { get; private set; }

        public CheckingAccount(string accountHolderName, double initialBalance)
        {
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal exceeds balance!");
            }
        }
        public void Deposit(double amount)
        {
            throw new ArgumentOutOfRangeException("amount");
        }
    }
}
