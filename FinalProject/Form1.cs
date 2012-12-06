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
        decimal startingBalance;

        public Form1()
        {
            InitializeComponent();
            SetContinueButtonEnabled();
        }

        private void SetContinueButtonEnabled()
        {
            buttonContinue.Enabled = (textBoxBeginningBalance.Text.Length > 0
                && textBoxAccountName.Text.Length > 0
                && textBoxAccountNumber.Text.Length > 0) ;
            
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

            if (textBoxDepositAmount.Text.Length > 0)
                textBoxDepositAmount.Focus();
            else
                textBoxWithdrawlAmount.Focus();

            ClearWithDrawDepositControls();
        } 
     

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            register = new BankRegister
            {
                Balance = startingBalance
            };

            groupBoxActivity.Enabled = true;
            groupBoxAccountDetails.Enabled = false;
           // buttonContinue.Enabled = false;
            SetAccoundDetailsTextBoxesReadOnly(true);

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            groupBoxActivity.Enabled = false;
            groupBoxAccountDetails.Enabled = true;
            SetAccoundDetailsTextBoxesReadOnly(false);
            //buttonContinue.Enabled = true;
        }

        #endregion
    }
}
