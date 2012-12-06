using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinalProject.classes;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        BankRegister register = new BankRegister();

        public Form1()
        {
            InitializeComponent();

            #region Misc initialization code
            SetContinueButtonEnabled();
            SetClearInputLabelVisible();
            labelAcctDetailsError.Visible = false;
            labelActivityError.Text = "";
            #endregion
        }

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

            if (Input.Trim().Length == 0)
            {
                Number = 0;
                return true;
            }

            if (!decimal.TryParse(Input.Trim(), out Number))
            {
                ErrorMessage = string.Format("Not a valid number: '{0}'", Input);
                return false;
            }

            return true;
        }
        #endregion

        #region Set Continued button enabled
        private void SetContinueButtonEnabled()
        {
            string errMsg;
            decimal startingBalance = 0;

            buttonContinue.Enabled = (textBoxBeginningBalance.Text.Trim().Length > 0
                && TryParseAndValidate(textBoxBeginningBalance.Text, out startingBalance, out errMsg)
                && textBoxAccountName.Text.Trim().Length > 0
                && textBoxAccountNumber.Text.Trim().Length > 0);

            if (!buttonContinue.Enabled)
                labelAvailableBalance.Visible = false;
            else
            {
                UpdateAvailableBalanceLabel(startingBalance);
                labelAvailableBalance.Visible = true;
            }
        }
        #endregion

        #region Update the Available Balance label
        private void UpdateAvailableBalanceLabel(decimal Balance)
        {
            labelAvailableBalance.Text = string.Format("{0:C}", Balance);
            labelAvailableBalance.ForeColor = Balance < 0 ? Color.Red : Color.Green;
        }
        #endregion

        #region Set clear input label visibility
        private void SetClearInputLabelVisible()
        {
            linkLabelClearInputFields.Visible = (textBoxBeginningBalance.Text.Length > 0
                || textBoxAccountName.Text.Length > 0
                || textBoxAccountNumber.Text.Length > 0);
        }
        #endregion

        #region Set Account Details textboxes readonly or not
        private void SetAccoundDetailsTextBoxesReadOnly(bool ReadOnly)
        {
            textBoxAccountName.ReadOnly = ReadOnly;
            textBoxAccountNumber.ReadOnly = ReadOnly;
            textBoxBeginningBalance.ReadOnly = ReadOnly;
        }
        #endregion

        #region Clear Deposit/Withdraw textboxes
        private void ClearWithDrawDepositControls()
        {
            textBoxDepositAmount.Text = "";
            textBoxWithdrawlAmount.Text = "";
        }
        #endregion

        #region Clear Account Details textboxes
        private void ClearAccountDetailsControls()
        {
            textBoxAccountNumber.Text = "";
            textBoxAccountName.Text = "";
            textBoxBeginningBalance.Text = "";
            linkLabelClearInputFields.Visible = false;
        }
        #endregion

        #region Event handlers
        #region Menu events
        #region File -> Exit
        private void menuItemFile_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?  If you do, we will confiscate all your money and give it to politicians.", "Exit Bank of Bartlett?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Environment.Exit(0);
        } 
        #endregion

        #region Help
        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("How to use this application");
            sb.AppendLine("---------------------------");
            sb.Append("The top group box ('Account Details') is where you enter Account Name, ");
            sb.Append("Number, and Starting Balance.\n\nWhen all information has been entered, ");
            sb.Append("hit the 'Continue' button to switch to the 'Activity' group box on the lower ");
            sb.Append("part of the form.");
            sb.Append("\n\nEnter dollar amounts in the 'Deposit Amount' and/or 'Withdrawl Amount' textboxes, ");
            sb.Append("then hit the 'Apply' button to update the available balance. When you are no longer ");
            sb.Append("amused by this activity, hit the 'Clear' button to return to the top panel.");
            sb.Append("\n\nNote that you can Apply Deposits and Withdrawls simultaneously.  The only restriction ");
            sb.Append("is that you cannot cause the balance to go negative, and you cannot increase a negative ");
            sb.Append("balance. Negative numbers are supported and dealt with arithmetically");
            MessageBox.Show(sb.ToString(), "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion

        #region About
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CIS162AD Final Project\n\n");
            sb.AppendLine("By Robert Bartlett 2012-12-07");
            MessageBox.Show(sb.ToString(), "About Bank of Bartlett", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion
        #endregion

        #region Apply Deposit or Withdrawl click
        private void buttonApply_Click(object sender, EventArgs e)
        {
            labelActivityError.Text = "";

            if (textBoxDepositAmount.Text.Length > 0)
                textBoxDepositAmount.Focus();
            else
                textBoxWithdrawlAmount.Focus();

            decimal credit = 0;
            decimal debit = 0;
            string errMsg;

            if (!TryParseAndValidate(textBoxDepositAmount.Text, out credit, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            if (!TryParseAndValidate(textBoxWithdrawlAmount.Text, out debit, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            decimal newBalance = 0;
            if (!register.TryDebitCreditTransaction(credit, debit, out newBalance, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            UpdateAvailableBalanceLabel(newBalance);
            textBoxBeginningBalance.Text = newBalance.ToString();

            ClearWithDrawDepositControls();
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

            groupBoxActivity.Enabled = true;
            groupBoxAccountDetails.Enabled = false;

            SetAccoundDetailsTextBoxesReadOnly(true);
            linkLabelClearInputFields.Visible = false;

            labelAvailableBalance.Visible = true;

            labelBeginningBalance.Text = "Available Balance";
        }
        #endregion

        #region Clear button click
        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxActivity.Enabled = false;
            groupBoxAccountDetails.Enabled = true;
            SetAccoundDetailsTextBoxesReadOnly(false);
            SetClearInputLabelVisible();
            textBoxBeginningBalance.Text = register.Balance.ToString(); // update oour beginning balance

            labelBeginningBalance.Text = "Beginning Balance";
        }
        #endregion

        #region Account Details textboxes  Key Up
        private void AccountDetailsTextBoxes_KeyUp(object sender, KeyEventArgs e)
        {
            decimal startingBalance;

            labelAcctDetailsError.Text = "";
            labelAcctDetailsError.Visible = false;

            // if there's a value in the starting amount (and it's not a minus sign), validate
            // and store the starting balance
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

            SetContinueButtonEnabled();
            SetClearInputLabelVisible();
        }
        #endregion

        #region Clear input fields linklabel click
        private void linkLabelClearInputFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAccountDetailsControls();
            textBoxAccountName.Focus();
            SetContinueButtonEnabled();
        }
        #endregion
        #endregion
    }
}
