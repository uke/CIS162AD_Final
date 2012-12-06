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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItemFile = new System.Windows.Forms.MenuItem();
            this.menuItemFile_Exit = new System.Windows.Forms.MenuItem();
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.linkLabelClearInputFields = new System.Windows.Forms.LinkLabel();
            this.labelAcctDetailsError = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.textBoxBeginningBalance = new System.Windows.Forms.TextBox();
            this.labelBeginningBalance = new System.Windows.Forms.Label();
            this.textBoxAccountNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.labelActivityError = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxWithdrawlAmount = new System.Windows.Forms.TextBox();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAvailableBalance = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxAccountDetails.SuspendLayout();
            this.groupBoxActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile,
            this.menuItemHelp,
            this.menuItemAbout});
            // 
            // menuItemFile
            // 
            this.menuItemFile.Index = 0;
            this.menuItemFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFile_Exit});
            this.menuItemFile.Text = "&File";
            // 
            // menuItemFile_Exit
            // 
            this.menuItemFile_Exit.Index = 0;
            this.menuItemFile_Exit.Text = "E&xit";
            this.menuItemFile_Exit.Click += new System.EventHandler(this.menuItemFile_Exit_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 1;
            this.menuItemHelp.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItemHelp.Text = "&Help";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            this.menuItemAbout.Text = "&About";
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robert Bartlett";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(338, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MEID ROB2081807";
            // 
            // groupBoxAccountDetails
            // 
            this.groupBoxAccountDetails.Controls.Add(this.linkLabelClearInputFields);
            this.groupBoxAccountDetails.Controls.Add(this.labelAcctDetailsError);
            this.groupBoxAccountDetails.Controls.Add(this.buttonContinue);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxBeginningBalance);
            this.groupBoxAccountDetails.Controls.Add(this.labelBeginningBalance);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxAccountNumber);
            this.groupBoxAccountDetails.Controls.Add(this.label4);
            this.groupBoxAccountDetails.Controls.Add(this.textBoxAccountName);
            this.groupBoxAccountDetails.Controls.Add(this.label3);
            this.groupBoxAccountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAccountDetails.Location = new System.Drawing.Point(13, 22);
            this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
            this.groupBoxAccountDetails.Size = new System.Drawing.Size(456, 194);
            this.groupBoxAccountDetails.TabIndex = 2;
            this.groupBoxAccountDetails.TabStop = false;
            this.groupBoxAccountDetails.Text = "Account Details";
            // 
            // linkLabelClearInputFields
            // 
            this.linkLabelClearInputFields.AutoSize = true;
            this.linkLabelClearInputFields.Location = new System.Drawing.Point(113, 159);
            this.linkLabelClearInputFields.Name = "linkLabelClearInputFields";
            this.linkLabelClearInputFields.Size = new System.Drawing.Size(56, 13);
            this.linkLabelClearInputFields.TabIndex = 5;
            this.linkLabelClearInputFields.TabStop = true;
            this.linkLabelClearInputFields.Text = "clear input";
            this.linkLabelClearInputFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearInputFields_LinkClicked);
            // 
            // labelAcctDetailsError
            // 
            this.labelAcctDetailsError.AutoSize = true;
            this.labelAcctDetailsError.ForeColor = System.Drawing.Color.Red;
            this.labelAcctDetailsError.Location = new System.Drawing.Point(191, 159);
            this.labelAcctDetailsError.Name = "labelAcctDetailsError";
            this.labelAcctDetailsError.Size = new System.Drawing.Size(117, 13);
            this.labelAcctDetailsError.TabIndex = 4;
            this.labelAcctDetailsError.Text = "this is an error message";
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(290, 30);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(115, 71);
            this.buttonContinue.TabIndex = 3;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // textBoxBeginningBalance
            // 
            this.textBoxBeginningBalance.Location = new System.Drawing.Point(116, 120);
            this.textBoxBeginningBalance.Name = "textBoxBeginningBalance";
            this.textBoxBeginningBalance.Size = new System.Drawing.Size(155, 20);
            this.textBoxBeginningBalance.TabIndex = 2;
            this.textBoxBeginningBalance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AccountDetailsTextBoxes_KeyUp);
            // 
            // labelBeginningBalance
            // 
            this.labelBeginningBalance.AutoSize = true;
            this.labelBeginningBalance.Location = new System.Drawing.Point(7, 127);
            this.labelBeginningBalance.Name = "labelBeginningBalance";
            this.labelBeginningBalance.Size = new System.Drawing.Size(96, 13);
            this.labelBeginningBalance.TabIndex = 0;
            this.labelBeginningBalance.Text = "Beginning Balance";
            // 
            // textBoxAccountNumber
            // 
            this.textBoxAccountNumber.Location = new System.Drawing.Point(116, 76);
            this.textBoxAccountNumber.Name = "textBoxAccountNumber";
            this.textBoxAccountNumber.Size = new System.Drawing.Size(155, 20);
            this.textBoxAccountNumber.TabIndex = 1;
            this.textBoxAccountNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AccountDetailsTextBoxes_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account Number";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(116, 30);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(155, 20);
            this.textBoxAccountName.TabIndex = 0;
            this.textBoxAccountName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AccountDetailsTextBoxes_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Name";
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.Color.Red;
            this.buttonClear.Location = new System.Drawing.Point(372, 73);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 70);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.TabStop = false;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.labelActivityError);
            this.groupBoxActivity.Controls.Add(this.buttonClear);
            this.groupBoxActivity.Controls.Add(this.buttonApply);
            this.groupBoxActivity.Controls.Add(this.textBoxWithdrawlAmount);
            this.groupBoxActivity.Controls.Add(this.textBoxDepositAmount);
            this.groupBoxActivity.Controls.Add(this.label10);
            this.groupBoxActivity.Controls.Add(this.label9);
            this.groupBoxActivity.Controls.Add(this.labelAvailableBalance);
            this.groupBoxActivity.Controls.Add(this.label7);
            this.groupBoxActivity.Enabled = false;
            this.groupBoxActivity.Location = new System.Drawing.Point(12, 222);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(457, 156);
            this.groupBoxActivity.TabIndex = 3;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Activity";
            // 
            // labelActivityError
            // 
            this.labelActivityError.AutoSize = true;
            this.labelActivityError.ForeColor = System.Drawing.Color.Red;
            this.labelActivityError.Location = new System.Drawing.Point(17, 130);
            this.labelActivityError.Name = "labelActivityError";
            this.labelActivityError.Size = new System.Drawing.Size(117, 13);
            this.labelActivityError.TabIndex = 4;
            this.labelActivityError.Text = "this is an error message";
            // 
            // buttonApply
            // 
            this.buttonApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.Green;
            this.buttonApply.Location = new System.Drawing.Point(281, 73);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 70);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // textBoxWithdrawlAmount
            // 
            this.textBoxWithdrawlAmount.Location = new System.Drawing.Point(152, 90);
            this.textBoxWithdrawlAmount.Name = "textBoxWithdrawlAmount";
            this.textBoxWithdrawlAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxWithdrawlAmount.TabIndex = 5;
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(18, 90);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepositAmount.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Withdrawl Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Deposit Amount";
            // 
            // labelAvailableBalance
            // 
            this.labelAvailableBalance.AutoSize = true;
            this.labelAvailableBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableBalance.Location = new System.Drawing.Point(147, 20);
            this.labelAvailableBalance.Name = "labelAvailableBalance";
            this.labelAvailableBalance.Size = new System.Drawing.Size(137, 25);
            this.labelAvailableBalance.TabIndex = 1;
            this.labelAvailableBalance.Text = "$1,234,567,89";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Available Balance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 396);
            this.Controls.Add(this.groupBoxActivity);
            this.Controls.Add(this.groupBoxAccountDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Bank of Bartlett Online Banking";
            this.groupBoxAccountDetails.ResumeLayout(false);
            this.groupBoxAccountDetails.PerformLayout();
            this.groupBoxActivity.ResumeLayout(false);
            this.groupBoxActivity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItemFile;
        private System.Windows.Forms.MenuItem menuItemFile_Exit;
        private System.Windows.Forms.MenuItem menuItemHelp;
        private System.Windows.Forms.MenuItem menuItemAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxAccountDetails;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.Label labelAcctDetailsError;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.TextBox textBoxBeginningBalance;
        private System.Windows.Forms.Label labelBeginningBalance;
        private System.Windows.Forms.TextBox textBoxAccountNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelActivityError;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxWithdrawlAmount;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelAvailableBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel linkLabelClearInputFields;

    }
}

