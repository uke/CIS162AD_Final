using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        enum Mode
        {
            Details,
            Activity
        }

      //  Mode currentMode;

        public Form1()
        {
            InitializeComponent();

            groupBoxAvailableBalance.Visible = false;

        }

        private void SetControlVisibility()
        {
            menuItemFileContinue.Enabled = buttonContinue.Enabled
                = textBoxAccountName.Text.Trim().Length > 0
                && textBoxAccountNumber.Text.Trim().Length > 0
                && textBoxStartingBalance.Text.Trim().Length > 0;
        }

        private void SetAccountInputReadOnly(bool ReadOnly)
        {

            textBoxStartingBalance.ReadOnly = ReadOnly;
            textBoxAccountName.ReadOnly = ReadOnly;
            textBoxAccountNumber.ReadOnly = ReadOnly;
        }

        #region Event Handlers
        #region ABout Menu
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CIS162AD Final Project -- Bank Of Bartlett\n\n"
                + "By Robert Bartlett, MEID ROB2081807, 2012-12-7\n\n"
                + "This app simulates a bank register.  Thought I'd spiff it up just a tad.",
                "About CIS162AD Final Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
        #endregion

        private void menuItemFileExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the Bank of Bartlett application? Nothing will be saved and you will be left penniless with only a smelly dog of dubious ancestry for a friend.", "Quit Bank of Bartlett?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Environment.Exit(0);
        }

        #region Clear & Continue buttons
        private void menuItemFileContinue_Click(object sender, EventArgs e)
        {
            SetAccountInputReadOnly(true);
            tabControlMainTabs.SelectedIndex = 1; // set Activity tab as active
            menuItemFileClear.Enabled = buttonClear.Enabled = true;
            menuItemFileContinue.Enabled = buttonContinue.Enabled = false;
            labelBeginningBalance.Text = "Available Balance";
            groupBoxAvailableBalance.Visible = true;

        }

        private void menuItemFileClear_Click(object sender, EventArgs e)
        {
            SetAccountInputReadOnly(false);
            menuItemFileClear.Enabled = buttonClear.Enabled = false;
            menuItemFileContinue.Enabled = buttonContinue.Enabled = true;

            textBoxAccountName.Text = string.Empty;
            textBoxAccountNumber.Text = string.Empty;
            textBoxStartingBalance.Text = string.Empty;

            tabControlMainTabs.SelectedIndex = 0;   // force them back to first tab
            labelBeginningBalance.Text = "Beginning Balance";

            groupBoxAvailableBalance.Visible = false;
 
        } 
        #endregion

        private void menuItemHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help!");
        }

        private void menuItemViewAccountInformation_Click(object sender, EventArgs e)
        {
            tabControlMainTabs.SelectedIndex = 0;   // set account details tab as active
        }

        private void menuItemViewActivity_Click(object sender, EventArgs e)
        {
            tabControlMainTabs.SelectedIndex = 1; // set Activity tab as active
        }

        private void textBoxAccountName_Leave(object sender, EventArgs e)
        {
            SetControlVisibility();
        }

        private void textBoxAccountNumber_Leave(object sender, EventArgs e)
        {
            SetControlVisibility();
        }

        private void textBoxStartingBalance_Leave(object sender, EventArgs e)
        {
            SetControlVisibility();
        } 

        private void textBoxStartingBalance_KeyUp(object sender, KeyEventArgs e)
        {
            SetControlVisibility();
        }

        private void textBoxAccountNumber_KeyUp(object sender, KeyEventArgs e)
        {
            SetControlVisibility();
        }

        private void textBoxAccountName_KeyUp(object sender, KeyEventArgs e)
        {
            SetControlVisibility();
        }
        #endregion

    }
}
