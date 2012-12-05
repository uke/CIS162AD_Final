namespace FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlMainTabs = new System.Windows.Forms.TabControl();
            this.tabPageAccountDetails = new System.Windows.Forms.TabPage();
            this.labelAccountInfoErrorMessage = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxStartingBalance = new System.Windows.Forms.TextBox();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelBeginningBalance = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageActivity = new System.Windows.Forms.TabPage();
            this.buttonWithdrawFunds = new System.Windows.Forms.Button();
            this.buttonDepositFunds = new System.Windows.Forms.Button();
            this.textBoxTransactionAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxAvailableBalance = new System.Windows.Forms.GroupBox();
            this.labelAvailableBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemFileContinue = new System.Windows.Forms.MenuItem();
            this.menuItemFileClear = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItemFileExit = new System.Windows.Forms.MenuItem();
            this.menuItemView = new System.Windows.Forms.MenuItem();
            this.menuItemViewAccountInformation = new System.Windows.Forms.MenuItem();
            this.menuItemViewActivity = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.tabControlMainTabs.SuspendLayout();
            this.tabPageAccountDetails.SuspendLayout();
            this.tabPageActivity.SuspendLayout();
            this.groupBoxAvailableBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainTabs
            // 
            this.tabControlMainTabs.Controls.Add(this.tabPageAccountDetails);
            this.tabControlMainTabs.Controls.Add(this.tabPageActivity);
            this.tabControlMainTabs.Location = new System.Drawing.Point(20, 98);
            this.tabControlMainTabs.Name = "tabControlMainTabs";
            this.tabControlMainTabs.SelectedIndex = 0;
            this.tabControlMainTabs.Size = new System.Drawing.Size(558, 273);
            this.tabControlMainTabs.TabIndex = 0;
            // 
            // tabPageAccountDetails
            // 
            this.tabPageAccountDetails.Controls.Add(this.labelAccountInfoErrorMessage);
            this.tabPageAccountDetails.Controls.Add(this.buttonClear);
            this.tabPageAccountDetails.Controls.Add(this.buttonContinue);
            this.tabPageAccountDetails.Controls.Add(this.textBoxStartingBalance);
            this.tabPageAccountDetails.Controls.Add(this.textBoxAccountNumber);
            this.tabPageAccountDetails.Controls.Add(this.textBoxAccountName);
            this.tabPageAccountDetails.Controls.Add(this.labelBeginningBalance);
            this.tabPageAccountDetails.Controls.Add(this.label5);
            this.tabPageAccountDetails.Controls.Add(this.label4);
            this.tabPageAccountDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccountDetails.Name = "tabPageAccountDetails";
            this.tabPageAccountDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccountDetails.Size = new System.Drawing.Size(550, 247);
            this.tabPageAccountDetails.TabIndex = 0;
            this.tabPageAccountDetails.Text = "Account Information";
            this.tabPageAccountDetails.ToolTipText = "This is where you enter the account details.";
            this.tabPageAccountDetails.UseVisualStyleBackColor = true;
            // 
            // labelAccountInfoErrorMessage
            // 
            this.labelAccountInfoErrorMessage.AutoSize = true;
            this.labelAccountInfoErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelAccountInfoErrorMessage.Location = new System.Drawing.Point(115, 116);
            this.labelAccountInfoErrorMessage.Name = "labelAccountInfoErrorMessage";
            this.labelAccountInfoErrorMessage.Size = new System.Drawing.Size(207, 13);
            this.labelAccountInfoErrorMessage.TabIndex = 5;
            this.labelAccountInfoErrorMessage.Text = "Beginning balance must be a valid number";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(215, 158);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.menuItemFileClear_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Enabled = false;
            this.buttonContinue.Location = new System.Drawing.Point(118, 158);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.menuItemFileContinue_Click);
            // 
            // textBoxStartingBalance
            // 
            this.textBoxStartingBalance.Location = new System.Drawing.Point(118, 85);
            this.textBoxStartingBalance.Name = "textBoxStartingBalance";
            this.textBoxStartingBalance.Size = new System.Drawing.Size(119, 20);
            this.textBoxStartingBalance.TabIndex = 2;
            this.textBoxStartingBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxStartingBalance_KeyUp);
            this.textBoxStartingBalance.Leave += new System.EventHandler(this.textBoxStartingBalance_Leave);
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(118, 50);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(172, 20);
            this.textBoxAccountNumber.TabIndex = 1;
            this.textBoxAccountNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAccountNumber_KeyUp);
            this.textBoxAccountNumber.Leave += new System.EventHandler(this.textBoxAccountNumber_Leave);
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(118, 15);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(172, 20);
            this.textBoxAccountName.TabIndex = 0;
            this.textBoxAccountName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxAccountName_KeyUp);
            this.textBoxAccountName.Leave += new System.EventHandler(this.textBoxAccountName_Leave);
            // 
            // labelBeginningBalance
            // 
            this.labelBeginningBalance.AutoSize = true;
            this.labelBeginningBalance.Location = new System.Drawing.Point(8, 88);
            this.labelBeginningBalance.Name = "labelBeginningBalance";
            this.labelBeginningBalance.Size = new System.Drawing.Size(96, 13);
            this.labelBeginningBalance.TabIndex = 0;
            this.labelBeginningBalance.Text = "Beginning Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Name";
            // 
            // tabPageActivity
            // 
            this.tabPageActivity.Controls.Add(this.buttonWithdrawFunds);
            this.tabPageActivity.Controls.Add(this.buttonDepositFunds);
            this.tabPageActivity.Controls.Add(this.textBoxTransactionAmount);
            this.tabPageActivity.Controls.Add(this.label8);
            this.tabPageActivity.Controls.Add(this.label7);
            this.tabPageActivity.Location = new System.Drawing.Point(4, 22);
            this.tabPageActivity.Name = "tabPageActivity";
            this.tabPageActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActivity.Size = new System.Drawing.Size(386, 247);
            this.tabPageActivity.TabIndex = 1;
            this.tabPageActivity.Text = "Activity";
            this.tabPageActivity.UseVisualStyleBackColor = true;
            // 
            // buttonWithdrawFunds
            // 
            this.buttonWithdrawFunds.Location = new System.Drawing.Point(219, 105);
            this.buttonWithdrawFunds.Name = "buttonWithdrawFunds";
            this.buttonWithdrawFunds.Size = new System.Drawing.Size(93, 57);
            this.buttonWithdrawFunds.TabIndex = 5;
            this.buttonWithdrawFunds.Text = "Witdraw";
            this.buttonWithdrawFunds.UseVisualStyleBackColor = true;
            // 
            // buttonDepositFunds
            // 
            this.buttonDepositFunds.Location = new System.Drawing.Point(62, 105);
            this.buttonDepositFunds.Name = "buttonDepositFunds";
            this.buttonDepositFunds.Size = new System.Drawing.Size(93, 57);
            this.buttonDepositFunds.TabIndex = 5;
            this.buttonDepositFunds.Text = "Deposit";
            this.buttonDepositFunds.UseVisualStyleBackColor = true;
            // 
            // textBoxTransactionAmount
            // 
            this.textBoxTransactionAmount.Location = new System.Drawing.Point(161, 34);
            this.textBoxTransactionAmount.Name = "textBoxTransactionAmount";
            this.textBoxTransactionAmount.Size = new System.Drawing.Size(131, 20);
            this.textBoxTransactionAmount.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Dollar Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 1;
            // 
            // groupBoxAvailableBalance
            // 
            this.groupBoxAvailableBalance.Controls.Add(this.labelAvailableBalance);
            this.groupBoxAvailableBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAvailableBalance.Location = new System.Drawing.Point(228, 24);
            this.groupBoxAvailableBalance.Name = "groupBoxAvailableBalance";
            this.groupBoxAvailableBalance.Size = new System.Drawing.Size(350, 79);
            this.groupBoxAvailableBalance.TabIndex = 2;
            this.groupBoxAvailableBalance.TabStop = false;
            this.groupBoxAvailableBalance.Text = "Available Balance";
            // 
            // labelAvailableBalance
            // 
            this.labelAvailableBalance.AutoSize = true;
            this.labelAvailableBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBalance.ForeColor = System.Drawing.Color.Red;
            this.labelAvailableBalance.Location = new System.Drawing.Point(6, 26);
            this.labelAvailableBalance.Name = "labelAvailableBalance";
            this.labelAvailableBalance.Size = new System.Drawing.Size(112, 31);
            this.labelAvailableBalance.TabIndex = 0;
            this.labelAvailableBalance.Text = "$108.50";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank of Bartlett";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Robert Bartlett, MEID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(124, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ROB2081807";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemView,
            this.menuItemHelp,
            this.menuItemAbout});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileContinue,
            this.menuItemFileClear,
            this.menuItem1,
            this.menuItemFileExit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFileContinue
            // 
            this.menuItemFileContinue.Enabled = false;
            this.menuItemFileContinue.Index = 0;
            this.menuItemFileContinue.Text = "Con&tinue";
            this.menuItemFileContinue.Click += new System.EventHandler(this.menuItemFileContinue_Click);
            // 
            // menuItemFileClear
            // 
            this.menuItemFileClear.Index = 1;
            this.menuItemFileClear.Text = "&Clear";
            this.menuItemFileClear.Click += new System.EventHandler(this.menuItemFileClear_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuItemFileExit
            // 
            this.menuItemFileExit.Index = 3;
            this.menuItemFileExit.Text = "E&xit";
            this.menuItemFileExit.Click += new System.EventHandler(this.menuItemFileExit_Click);
            // 
            // menuItemView
            // 
            this.menuItemView.Index = 1;
            this.menuItemView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemViewAccountInformation,
            this.menuItemViewActivity});
            this.menuItemView.Text = "&View";
            // 
            // menuItemViewAccountInformation
            // 
            this.menuItemViewAccountInformation.Index = 0;
            this.menuItemViewAccountInformation.Text = "Account &Information";
            this.menuItemViewAccountInformation.Click += new System.EventHandler(this.menuItemViewAccountInformation_Click);
            // 
            // menuItemViewActivity
            // 
            this.menuItemViewActivity.Index = 1;
            this.menuItemViewActivity.Text = "&Activity";
            this.menuItemViewActivity.Click += new System.EventHandler(this.menuItemViewActivity_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 2;
            this.menuItemHelp.Text = "&Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 3;
            this.menuItemAbout.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 383);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControlMainTabs);
            this.Controls.Add(this.groupBoxAvailableBalance);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Bank of Bartlett Online Banking";
            this.tabControlMainTabs.ResumeLayout(false);
            this.tabPageAccountDetails.ResumeLayout(false);
            this.tabPageAccountDetails.PerformLayout();
            this.tabPageActivity.ResumeLayout(false);
            this.tabPageActivity.PerformLayout();
            this.groupBoxAvailableBalance.ResumeLayout(false);
            this.groupBoxAvailableBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainTabs;
        private System.Windows.Forms.TabPage tabPageAccountDetails;
        private System.Windows.Forms.TabPage tabPageActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxStartingBalance;
        private System.Windows.Forms.Label labelBeginningBalance;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemFileClear;
        private System.Windows.Forms.MenuItem menuItemFileExit;
        private System.Windows.Forms.MenuItem menuItemView;
        private System.Windows.Forms.MenuItem menuItemViewAccountInformation;
        private System.Windows.Forms.MenuItem menuItemViewActivity;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItemFileContinue;
        private System.Windows.Forms.GroupBox groupBoxAvailableBalance;
        private System.Windows.Forms.Label labelAvailableBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonWithdrawFunds;
        private System.Windows.Forms.Button buttonDepositFunds;
        private System.Windows.Forms.TextBox textBoxTransactionAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAccountInfoErrorMessage;
    }
}

