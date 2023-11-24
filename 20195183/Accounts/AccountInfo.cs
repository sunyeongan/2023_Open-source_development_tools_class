using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounts
{
    public class AccountInfo
    {
        public AccountInfo(string name, double balance)
        {
            Console.WriteLine("{0} 님의 잔액은 {1}원 입니다.",name, balance);   
        }
    }
}
