using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject.classes
{
    /// <summary>
    /// Simulates a basic bank register.  Will not allow any transaction that results in
    /// an increased negative balance, or a negative balance from a positive one. 
    /// 
    /// Negative initial balances are allowed, but any transactions that try to make
    /// the balance more negative will be refused.
    /// 
    /// Credit and or Debit transaction is accomplished with a single method call. The net value
    /// of the credit and debit are applied against the balance.
    /// </summary>
    public class BankRegister
    {
        decimal balance; // maintains our pitiful bank balance

        #region public preoperties
        /// <summary>
        /// The current balance.
        /// </summary>
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
        #endregion

        #region Try to apply debit and credit to balance
        /// <summary>
        /// Apply a debit and/or credit to the current balance. Do not increase a negative
        /// balance, or cause a positive balance to become negative.
        /// </summary>
        /// <remarks>Negative numbers are supported, and are simply arithmetically added to (credit) 
        /// or subtracted from (debit) the balance.  So a negative debit will result 
        /// in a net gain, and a negative credit a net decrease in
        /// the balance.</remarks>
        /// <param name="CreditAmount">An amount to be added to the current balance. Negative numbers are valid.</param>
        /// <param name="DebitAmount">An amount to be subtracted from the current balance. Negative numbers are valid.</param>
        /// <param name="NewBalance">The result of the debit/credit combination applied against the old balance.</param>
        /// <param name="ErrorMessage">Description of why the transaction failed, if an error occurred.</param>
        /// <returns>True if the transaction suceeded, else False.</returns>
        public bool TryDebitCreditTransaction(decimal CreditAmount, decimal DebitAmount, out decimal NewBalance, out string ErrorMessage)
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
            if (netAmount == 0)
            {
                NewBalance = balance;
                return true;
            }

            // CASE 4: balance changed, remains positive
            if (balance + netAmount >= 0)
            {
                balance += netAmount;
                NewBalance = balance;
                return true;
            }

            // CASE 5: outcome would be negative balance if we allowed it, but we won't
            ErrorMessage = "This isn't a freaking casino.  Insufficient funds";
            NewBalance = balance;
            return false;
        } 
        #endregion
    }
}
