using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts.Tests 
{
    [TestClass()]
    public class CheckingAccountTests 
    {
        [TestMethod]
        [Timeout(2000)]
        public void Withdraw_ValidAmount_ChangesBalance() 
        {
            
            double currentBalance = 10.0;
            double withdrawal = 1.0;
            double expected = 9.0;
            var account = new CheckingAccount("JohnDoe", currentBalance);

            account.Withdraw(withdrawal);
            
            Assert.AreEqual(expected, account.Balance);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Withdraw_AmountMoreThanBalance_Throws()
        {
             var account = new CheckingAccount("John Doe", 10.0);

            Assert.ThrowsException<System.ArgumentException>(() => account.Withdraw(20.0));
        }
    }
}