using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject.classes
{
    public class BankRegister
    {
        decimal balance;

        public decimal Balance
        {
            get
            {
                return balance;
            }
        }

        public decimal Deposit(decimal Amount)
        {
            balance += Amount;
            return balance;
        }

        public bool TryWithdraw(decimal Amount, out string ErrorMessage)
        {
            ErrorMessage = "";
            if (balance - Amount >= 0)
            {
                balance -= Amount;
                return true;
            }

            ErrorMessage = "Insuficient Funds";
            return false;
        }
    }
}
