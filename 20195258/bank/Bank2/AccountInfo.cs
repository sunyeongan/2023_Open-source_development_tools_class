using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_
{
    internal class AccountInfo
    {
        public string AccountNumber { get; set; }

        public string AccountHolderName { get; set; }

        public string AccountType { get; set; }

        public AccountInfo(string accountNumber, string accountHolderName, string accountType, DateTime openDate)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            AccountType = accountType;
        }
    }
}
