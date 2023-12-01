using Accounts;

namespace Accounts {
    public class AccountInfo {
        public static void Main() {
            CheckingAccount ba = new("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Withdraw(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}