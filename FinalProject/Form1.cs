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
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CIS162AD Final Project -- Bank Of Bartlett\n\n"
                + "By Robert Bartlett, MEID ROB2081807, 2012-12-7\n\n"
                + "This app simulates a bank register.  Thought I'd spif it up just a tad.",
                "About CIS162AD Final Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit the Bank of Bartlett application? Nothing will be saved and you will be left penniless with only a dog as a friend.", "Quit Bank of Bartlett?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                Environment.Exit(0);
        }
    }
}
