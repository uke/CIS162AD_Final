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

            SetContinueButtonEnabled();
            SetClearInputLabelVisible();
            labelAcctDetailsError.Visible = false;
        }

        private bool TryParseAndValidate(string Input, out decimal Number, out string ErrorMessage)
        {
            Number = 0;
            ErrorMessage = null;

            if (!decimal.TryParse(Input, out Number))
            {
                ErrorMessage = string.Format("Not a valid number: '{0}'", Input);
                return false;
            }

            return true;
        }

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

        private void UpdateAvailableBalanceLabel(decimal Balance)
        {
            labelAvailableBalance.Text = string.Format("{0:C}", Balance);
            labelAvailableBalance.ForeColor = Balance < 0 ? Color.Red : Color.Green;
        }

        private void SetClearInputLabelVisible()
        {
            linkLabelClearInputFields.Visible = (textBoxBeginningBalance.Text.Length > 0
                || textBoxAccountName.Text.Length > 0
                || textBoxAccountNumber.Text.Length > 0);
        }

        private void SetAccoundDetailsTextBoxesReadOnly(bool ReadOnly)
        {
            textBoxAccountName.ReadOnly = ReadOnly;
            textBoxAccountNumber.ReadOnly = ReadOnly;
            textBoxBeginningBalance.ReadOnly = ReadOnly;
        }

        private void ClearWithDrawDepositControls()
        {
            textBoxDepositAmount.Text = "";
            textBoxWithdrawlAmount.Text = "";
        }

        private void ClearAccountDetailsControls()
        {
            textBoxAccountNumber.Text = "";
            textBoxAccountName.Text = "";
            textBoxBeginningBalance.Text = "";
            linkLabelClearInputFields.Visible = false;
        }

        #region Event handlers
        private void menuItemFile_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?  If you do, we will confiscate all your money and give it to politicians.", "Exit Bank of Bartlett?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Environment.Exit(0);
        }

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help!");
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About!");
        }

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
            if (!register.TryDebitCredit(credit, debit, out newBalance, out errMsg))
            {
                labelActivityError.Text = errMsg;
                return;
            }

            UpdateAvailableBalanceLabel(newBalance);

            ClearWithDrawDepositControls();
        }


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

            labelAvailableBalance.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxActivity.Enabled = false;
            groupBoxAccountDetails.Enabled = true;
            SetAccoundDetailsTextBoxesReadOnly(false);
            textBoxBeginningBalance.Text = register.Balance.ToString(); // update oour beginning balance
        }

        private void AccountDetailsTextBoxes_KeyUp(object sender, KeyEventArgs e)
        {
            decimal startingBalance;

            // if there's a value in the starting amount (and it's not a minus sign), validate
            // and store the starting balance
            if (textBoxBeginningBalance.Text.Length > 0 && !textBoxBeginningBalance.Text.StartsWith("-"))
            {
                string errMsg;

                if (!TryParseAndValidate(textBoxBeginningBalance.Text, out startingBalance, out errMsg))
                {
                    labelAcctDetailsError.Text = errMsg;
                    labelAcctDetailsError.Visible = true;
                }
                else
                {
                    labelAcctDetailsError.Text = "";
                    labelAcctDetailsError.Visible = false;
                }
            }

            SetContinueButtonEnabled();
            SetClearInputLabelVisible();
        }

        private void linkLabelClearInputFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearAccountDetailsControls();
            textBoxAccountName.Focus();
            SetContinueButtonEnabled();
        }
        #endregion
    }
}
