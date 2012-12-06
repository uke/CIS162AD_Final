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
            this.menuItemHelp = new System.Windows.Forms.MenuItem();
            this.menuItemAbout = new System.Windows.Forms.MenuItem();
            this.menuItemFile_Exit = new System.Windows.Forms.MenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxAccountDetails = new System.Windows.Forms.GroupBox();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            // menuItemHelp
            // 
            this.menuItemHelp.Index = 1;
            this.menuItemHelp.Shortcut = System.Windows.Forms.Shortcut.F1;
            this.menuItemHelp.Text = "&Help";
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Index = 2;
            this.menuItemAbout.Text = "&About";
            // 
            // menuItemFile_Exit
            // 
            this.menuItemFile_Exit.Index = 0;
            this.menuItemFile_Exit.Text = "E&xit";
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
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MEID ROBxxxxxx";
            // 
            // groupBoxAccountDetails
            // 
            this.groupBoxAccountDetails.Controls.Add(this.label6);
            this.groupBoxAccountDetails.Controls.Add(this.button2);
            this.groupBoxAccountDetails.Controls.Add(this.button1);
            this.groupBoxAccountDetails.Controls.Add(this.textBox3);
            this.groupBoxAccountDetails.Controls.Add(this.label5);
            this.groupBoxAccountDetails.Controls.Add(this.textBox2);
            this.groupBoxAccountDetails.Controls.Add(this.label4);
            this.groupBoxAccountDetails.Controls.Add(this.textBox1);
            this.groupBoxAccountDetails.Controls.Add(this.label3);
            this.groupBoxAccountDetails.Location = new System.Drawing.Point(13, 22);
            this.groupBoxAccountDetails.Name = "groupBoxAccountDetails";
            this.groupBoxAccountDetails.Size = new System.Drawing.Size(429, 194);
            this.groupBoxAccountDetails.TabIndex = 2;
            this.groupBoxAccountDetails.TabStop = false;
            this.groupBoxAccountDetails.Text = "Account Details";
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.label11);
            this.groupBoxActivity.Controls.Add(this.button3);
            this.groupBoxActivity.Controls.Add(this.textBox5);
            this.groupBoxActivity.Controls.Add(this.textBox4);
            this.groupBoxActivity.Controls.Add(this.label10);
            this.groupBoxActivity.Controls.Add(this.label9);
            this.groupBoxActivity.Controls.Add(this.label8);
            this.groupBoxActivity.Controls.Add(this.label7);
            this.groupBoxActivity.Location = new System.Drawing.Point(12, 222);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(430, 156);
            this.groupBoxActivity.TabIndex = 3;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Activity";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Beginning Balance";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 20);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(116, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "this is an error message";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "$1,234,567,89";
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
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
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(291, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 70);
            this.button3.TabIndex = 6;
            this.button3.Text = "Apply";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(17, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "this is an error message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 396);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;

    }
}

