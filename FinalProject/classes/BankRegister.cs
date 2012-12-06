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

            set
            {
                balance = value;
            }
        }

        public decimal Deposit(decimal Amount)
        {
            balance += Amount;
            return balance;
        }

        public bool TryWithdraw(decimal Amount, out decimal NewBalance,  out string ErrorMessage)
        {
            ErrorMessage = "";
            NewBalance = balance;

            if (balance - Amount >= 0)
            {
                NewBalance = balance -= Amount;
                return true;
            }

            ErrorMessage = "Insuficient Funds";
            
            return false;
        }
    }
}
