using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    public class AccountInfo
    {
        public string m_customername; //고객 이름
        public double m_balance=1000.0; //잔액

        public static void Main(string[] args)
        {
            CheckingAccount bryan = new CheckingAccount("Mr.Bryan Waltion", 11.99);
            bryan.Deposit(5.77);
            bryan.Withdraw(300.0);
            Console.WriteLine("계좌의 잔액: " + bryan.m_balance);

        }
    }

}
