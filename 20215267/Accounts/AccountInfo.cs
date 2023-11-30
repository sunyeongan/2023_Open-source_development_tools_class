using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class AccountInfo
    {
        private readonly string m_customerName;
        private double m_balance;
        private AccountInfo() { }

        public AccountInfo(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }
        public double Balance
        {
            get { return m_balance; }
        }

        public static void Main()
        {
            CheckingAccount bryan = new CheckingAccount("Mr. Bryan Walton", 11.99);
        }
    }
}
