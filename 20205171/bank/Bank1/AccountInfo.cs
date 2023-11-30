using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank1
{
    class AccountInfo
    {
        private readonly string m_customerName;
        public double m_balance;

        public AccountInfo(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

    }
}
