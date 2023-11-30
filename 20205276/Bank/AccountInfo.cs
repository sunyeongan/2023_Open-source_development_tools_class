using System;

namespace Bank
{
    public class AccountInfo
    {
        private double _balance;

        public CheckingAccount(double initialBalance)
        {
            _balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > _balance)
            {
                throw new ArgumentOutOfRangeException("amount", "Withdrawal exceeds balance!");
            }

            _balance -= amount;
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
}