using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    internal class CheckingAccount : IAccount
    {
        private decimal balance;
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return balance;
        }

       
    }
}
