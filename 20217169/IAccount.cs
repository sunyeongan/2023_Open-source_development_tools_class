﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounts;

namespace Accounts
{
    public interface IAccount
    {
        void Withdraw(double amount);
        void Deposit(double amount);
    }
}
