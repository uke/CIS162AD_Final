using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProject.classes; // NOTE: This is where the required class lives

namespace FinalProject
{
    /*****************************************************************************************
     * CIS162AD Final Project  Robert Bartlett 2012-12-08
     * 
     * A simpleminded bank register simulation. Let user enter basic account
     * informnation and a starting balance, then when everything passes
     * validation, switch to an Activity mode where they can enter deposits
     * and/or withdrawls to change the balance.  When they are done doing that
     * they can return to the accound details mode and modify or clear the
     * values.
     * 
     * Business logic implemented in a BankRegister object.
     * 
     * Annotated Project Specification can be found in 
     *      supportingDocs > CIS162ADFinal-ResponsetoProjectSpecifications.pdf
     *      
     * Primary design wireframe can be found in
     *      supportingDocs > wireframe.png
     * 
     * Test Matrix can be found in supportingDocs > CID162AD Final Project Test Matrix.pdf
     * 
     * Flowcharts, UML, structure diagram found in supportingDocs > flowchartsEtc.pdf
     * 
     * *****************************************************************************************/
    public partial class Form1 : Form
    {
        BankRegister register = new BankRegister(); // our business logic object

        const string ACCOUNT_TITLE = "Bank of Bartlett online banking -- Enter Account Details";
        const string ACTIVITY_TITLE = "Bank of Bartlett online banking - Account Activity";
        public Form1()
        {
            InitializeComponent();

            #region Misc initialization code
            SetContinueButtonEnabled();             // this will disable Continue because required fields are blank
            SetClearInputLabelVisible();            // this will make control invisible because input fields are blank
            this.Text = ACCOUNT_TITLE;
           
            // make stuff invisible to start
            groupBoxActivity.Visible = false;
            labelAcctDetailsError.Visible = false;  
            labelActivityError.Text = "";
            labelAvailTitle.Visible = false;
            #endregion
        }

        #region Helper logic
        #region Parse and validate numbers
        /// <summary>
        /// Parse and validate an input string, returning a decimal if a valid number. If not
        /// a valid number, return error message.
        /// </summary>
        /// <param name="Input">A number.  Can be negative.</param>
        /// <param name="Number">The number if sucesfully parsed, in decimal format</param>
        /// <param name="ErrorMessage">A brief description of the error.</param>
        /// <returns>True if the number validated, else false.</returns>
        private bool TryParseAndValidate(string Input, out decimal Number, out string ErrorMessage)
        {
            Number = 0;
            ErrorMessage = null;

            if (Input.Trim().Length == 0) // if no text, we're done
            {
                Number = 0;
                return true;
            }

            if (!decimal.TryParse(Input.Trim(), out Number)) // validate user input -- better be a number
            {
                ErrorMessage = string.Format("Not a valid number: '{0}'", Input);
                return false;   // oops
            }

            return true; // good user input
        }
        #endregion

        #region Set Continued button enabled
        /// <summary>
        /// Sets nabled property of the Continue button if all required input fields are filled in
        /// and validated.
        /// 
        /// Also sets visibilty of Available Balance labels.  
        /// </summary>
        private void SetContinueButtonEnabled()
        {
            string errMsg;
            decimal startingBalance = 0;

            // enable the button if input fields filled and valid
            buttonContinue.Enabled = (textBoxBeginningBalance.Text.Trim().Length > 0
                && TryParseAndValidate(textBoxBeginningBalance.Text, out startingBalance, out errMsg)
                && textBoxAccountName.Text.Trim().Length > 0
                && textBoxAccountNumber.Text.Trim().Length > 0);

            // if the Continue button got enabled, also set up Available Balance
            if (!buttonContinue.Enabled)
                labelAvailableBalance.Visible = labelAvailTitle.Visible = false;
            else
            {
                UpdateAvailableBalanceLabel(startingBalance);
                labelAvailableBalance.Visible = labelAvailTitle.Visible = true;
            }
        }
        #endregion

        #region Update the Available Balance label
        /// <summary>
        /// Formats Available Balance. Make it a dollar amount and color Red if negative,
        /// Green if positive.
        /// </summary>
        /// <param name="Balance"></param>
        private void UpdateAvailableBalanceLabel(decimal Balance)
        {
            labelAvailableBalance.Text = string.Format("{0:C}", Balance);
            labelAvailableBalance.ForeColor = Balance < 0 ? Color.Red : Color.Green;
        }
        #endregion

        #region Set clear input label visibility
        /// <summary>
        /// We only want to see the clear input control if there is data in any of the three
        /// input fields on the Account Details panel.
        /// </summary>
        private void SetClearInputLabelVisible()
        {
            linkLabelClearInputFields.Visible = (textBoxBeginningBalance.Text.Length > 0
                || textBoxAccountName.Text.Length > 0
                || textBoxAccountNumber.Text.Length > 0);
        }
        #endregion

        #region Set Account Details textboxes readonly or not
        /// <summary>
        /// Make Account Details input fields read only depending on parameter.
        /// </summary>
        /// <param name="ReadOnly">True if you want to makethe input fields read-only.  False 
        /// to make them accessible for input.</param>
        private void SetAccoundDetailsTextBoxesReadOnly(bool ReadOnly)
        {
            textBoxAccountName.ReadOnly = ReadOnly;
            textBoxAccountNumber.ReadOnly = ReadOnly;
            textBoxBeginningBalance.ReadOnly = ReadOnly;
        }
        #endregion

        #region Clear Deposit/Withdraw textboxes
        /// <summary>
        /// Clear out the Deposit Amount and Withdrawal Amount fields
        /// </summary>
        private void ClearWithDrawDepositControls()
        {
            textBoxDepositAmount.Clear();
            textBoxWithdrawalAmount.Clear();
        }
        #endregion

        #region Clear Account Details textboxes
        /// <summary>
        /// Clear out the input fields in the Account Details box, and
        /// make the clear input label invisible.
        /// </summary>
        private void ClearAccountDetailsControls()
        {
            textBoxAccountNumber.Clear();
            textBoxAccountName.Clear();
            textBoxBeginningBalance.Clear();
            linkLabelClearInputFields.Visible = false; // don't show control if there's nothing to clear
        }
        #endregion 
        #endregion

        #region Event handlers
        #region Menu events
        #region File -> Exit
        private void menuItemFile_Exit_Click(object sender, EventArgs e)
        {
            // user hit File -> Exit
            if (MessageBox.Show("Are you sure you want to exit?  If you do, we will confiscate all your money and give it to politicians.", "Exit Bank of Bartlett?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Environment.Exit(0);
        } 
        #endregion

        #region Help
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            // user hit Help
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("How to use this application");
            sb.AppendLine("---------------------------");
            sb.Append("The top group box ('Account Details') is where you enter Account Name, ");
            sb.Append("Number, and Starting Balance.\n\nWhen all information has been entered, ");
            sb.Append("hit the 'Continue' button to switch to the 'Activity' group box on the lower ");
            sb.Append("part of the form.");
            sb.Append("\n\nEnter dollar amounts in the 'Deposit Amount' and/or 'Withdrawal Amount' textboxes, ");
            sb.Append("then hit the 'Apply' button to update the available balance. When you are no longer ");
            sb.Append("amused by this activity, hit the 'Clear' button to return to the top panel.");
            sb.Append("\n\nNote that you can Apply Deposits and Withdrawals simultaneously.  The only restriction ");
            sb.Append("is that you cannot cause the balance to go negative, and you cannot increase a negative ");
            sb.Append("balance. Negative numbers are supported and dealt with arithmetically");
            MessageBox.Show(sb.ToString(), "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion

        #region About
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            // user hit About
            StringBuilder sb = new StringBuilder();
            sb.Append("CIS162AD Final Project\n\n");
            sb.AppendLine("By Robert Bartlett 2012-12-07");
            sb.AppendLine("\n\nPlease see the 'CIS162ADFinal-ResponseToProjectSpecifications.pdf' file for comments on the implementation.");
            MessageBox.Show(sb.ToString(), "About Bank of Bartlett", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion
        #endregion

        #region Apply Deposit or Withdrawal click
        private void buttonApply_Click(object sender, EventArgs e)
        {
            // user hit the Apply button
            labelActivityError.Text = "";

            // set the focus to the last input field that had data.  This
            // makes it better when they are entering multiple successive transactions
            // of one type-- Like a long series of deposits.
            if (textBoxDepositAmount.Text.Length > 0)
                textBoxDepositAmount.Focus();
            else
                if (textBoxWithdrawalAmount.Text.Length > 0)
                    textBoxWithdrawalAmount.Focus();
                else
                    textBoxDepositAmount.Focus();

            // The BankRegister TryDebitCreditTransaction() method accepts either or both
            // credit and/or debit.  We accept either here in the UI as well.
            decimal credit = 0;
            decimal debit = 0;
            string errMsg;

            if (!TryParseAndValidate(textBoxDepositAmount.Text, out credit, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            if (!TryParseAndValidate(textBoxWithdrawalAmount.Text, out debit, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            decimal newBalance = 0;
            if (!register.TryDebitCreditTransaction(credit, debit, out newBalance, out errMsg))
            {
                // An error occurs if the user tries to drive the balance negative, or more negative
                labelActivityError.Text = errMsg;
                return;
            }

            UpdateAvailableBalanceLabel(newBalance);                // show what our new balance is
            textBoxBeginningBalance.Text = newBalance.ToString();   // also update Account Details textbox (kludge alert)

            ClearWithDrawDepositControls();     // reset for next transaction
        }
        #endregion

        #region Continue button click
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            // instatiate a new BankRegister object, load with starting balance,
            // enable bottom group box for activity, disable account details group box.

            // note we don't validate the stating balance here-- That already happened elsewhere
            register = new BankRegister
            {
                Balance = Convert.ToDecimal(textBoxBeginningBalance.Text)
            };

            // switch to the Activity group box
            groupBoxActivity.Visible = true;
            groupBoxAccountDetails.Enabled = false;

            SetAccoundDetailsTextBoxesReadOnly(true);
            linkLabelClearInputFields.Visible = false;

            labelAvailableBalance.Visible = true;
            labelAvailTitle.Visible = true;

            labelBeginningBalance.Text = "Available Balance";   // required action for project-- Would not do this otherwise

            this.Text = ACTIVITY_TITLE; // switch form title
        }
        #endregion

        #region Clear button click
        private void buttonClear_Click(object sender, EventArgs e)
        {
            // Clear button exits Activity mode and returns user to Account Details. It does not actually
            // "clear" anything, but takes the user to a place where they can clear if they want. This
            // is an artifact of the project requirements, which are kind of silly and assume that the
            // app is a simpleminded thing.
            groupBoxActivity.Visible = false;
            groupBoxAccountDetails.Enabled = true;

            SetAccoundDetailsTextBoxesReadOnly(false);  // open up the accound details fields for input again
            SetClearInputLabelVisible();                // make clear link visible

            textBoxBeginningBalance.Text = register.Balance.ToString(); // update our beginning balance

            labelBeginningBalance.Text = "Beginning Balance";   // change this back

            this.Text = ACCOUNT_TITLE; // switch form title
        }
        #endregion

        #region Account Details textboxes  Key Up
        private void AccountDetailsTextBoxes_KeyUp(object sender, KeyEventArgs e)
        {
            // NOTE: all account detail textboxes are wired to this keyup event, to 
            // reduce duplication of code.

            // Validate content of text boxes and drive the setting of the Continue button's visibilty
            decimal startingBalance;

            labelAcctDetailsError.Text = "";
            labelAcctDetailsError.Visible = false;

            // if there's a value in the starting amount (and it's not a minus sign), validate
            // and store the starting balance. If it's a minus sign wait till user enters more data
            if (textBoxBeginningBalance.Text.Length > 0 && !textBoxBeginningBalance.Text.StartsWith("-"))
            {
                string errMsg;

                if (!TryParseAndValidate(textBoxBeginningBalance.Text, out startingBalance, out errMsg))
                {
                    labelAcctDetailsError.Text = errMsg;
                    labelAcctDetailsError.Visible = true;
                    textBoxBeginningBalance.Focus();
                    return;
                }
            }

            // put at least some restrictions on the kind of caca they can enter
            if (textBoxAccountName.Text.StartsWith(" "))
            {
                labelAcctDetailsError.Text = "Account Name cannot start with blank";
                labelAcctDetailsError.Visible = true;
                textBoxAccountName.Focus();
                return;
            }

            if (textBoxAccountNumber.Text.StartsWith(" "))
            {
                labelAcctDetailsError.Text = "Account Number cannot start with blank";
                labelAcctDetailsError.Visible = true;
                textBoxAccountNumber.Focus();
                return;
            }

            SetContinueButtonEnabled();         // now that we have data, set Continue visibility
            SetClearInputLabelVisible();        // likewise the clear label
        }
        #endregion

        #region Clear input fields linklabel click
        private void linkLabelClearInputFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // wipe out all input fields
            ClearAccountDetailsControls();      // clear the data
            textBoxAccountName.Focus();         // focus on first input field
            SetContinueButtonEnabled();         // disable Continue button
        }
        #endregion
        #endregion
    }
}
