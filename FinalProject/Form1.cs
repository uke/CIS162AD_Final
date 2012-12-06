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

        } 
        #endregion
    }
}
