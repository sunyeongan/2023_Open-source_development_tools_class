using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank2;

namespace Bank2
{
    public interface IAccount 
    {

        void Deposit(double  amount); //입금
        void Withdraw(double amount); //출금
        string CustomerName();//이름 조회
        double Balance();//잔액 조회
    
    
    }
}
