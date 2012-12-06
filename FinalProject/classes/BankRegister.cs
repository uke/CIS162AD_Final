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

            // CASE 1: if we're already under water, don't let them increase debt
            if (balance < 0 && netAmount < 0)
            {
                ErrorMessage = "Unable to increase negative balance, DEADBEAT";
                return false;
            }

            // CZASE 2: if we're already under water, allow a positive net result that claws our
            // way out of the hole we're in
            if (balance < 0 && netAmount > 0)
            {
                balance += netAmount;
                NewBalance = balance;
                return true;
            }

            // CASE 3: net effect is zero, don't do anything
            if (netAmount == 0) // I know, redundant test, left it in for clarity
            {
                NewBalance = balance;
                return true;
            }

            // CASE 4: balance changed, remains positive
            balance += netAmount;
            return true;

        }

        public bool TryWithdraw(decimal Amount, out decimal NewBalance, out string ErrorMessage)
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
