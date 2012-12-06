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

        public bool TryDebitCredit(decimal CreditAmount, decimal DebitAmount, out decimal NewBalance, out string ErrorMessage)
        {
            NewBalance = balance;
            ErrorMessage = null;
 
            // compute the net value of the transaction
            decimal netAmount = CreditAmount - DebitAmount;

            // if we're already under water, don't let them increase debt
            if (balance < 0 && netAmount < 0)
            {
                ErrorMessage = "Unable to increase negative balance, DEADBEAT";
                return false;
            }

            return true;
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
