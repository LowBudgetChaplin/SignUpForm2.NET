namespace WindowsFormsApp1
{
    partial class Signup
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
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTransactions = new System.Windows.Forms.Label();
            this.labelSMS = new System.Windows.Forms.Label();
            this.checkReports = new System.Windows.Forms.CheckBox();
            this.checkSMS = new System.Windows.Forms.CheckBox();
            this.checkTransactions = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(284, 55);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(440, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(284, 103);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(440, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Address: ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(284, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(440, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTransactions);
            this.groupBox1.Controls.Add(this.labelSMS);
            this.groupBox1.Controls.Add(this.checkReports);
            this.groupBox1.Controls.Add(this.checkSMS);
            this.groupBox1.Controls.Add(this.checkTransactions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 194);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelTransactions
            // 
            this.labelTransactions.AutoSize = true;
            this.labelTransactions.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransactions.Location = new System.Drawing.Point(473, 147);
            this.labelTransactions.Name = "labelTransactions";
            this.labelTransactions.Size = new System.Drawing.Size(37, 19);
            this.labelTransactions.TabIndex = 7;
            this.labelTransactions.Text = ".......";
            this.labelTransactions.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelSMS
            // 
            this.labelSMS.AutoSize = true;
            this.labelSMS.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSMS.Location = new System.Drawing.Point(473, 39);
            this.labelSMS.Name = "labelSMS";
            this.labelSMS.Size = new System.Drawing.Size(37, 19);
            this.labelSMS.TabIndex = 5;
            this.labelSMS.Text = ".......";
            this.labelSMS.Click += new System.EventHandler(this.labelSMS_Click);
            // 
            // checkReports
            // 
            this.checkReports.AutoSize = true;
            this.checkReports.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkReports.Location = new System.Drawing.Point(159, 89);
            this.checkReports.Name = "checkReports";
            this.checkReports.Size = new System.Drawing.Size(128, 35);
            this.checkReports.TabIndex = 4;
            this.checkReports.Text = "Reports";
            this.checkReports.UseVisualStyleBackColor = true;
            this.checkReports.CheckedChanged += new System.EventHandler(this.checkReports_CheckedChanged);
            // 
            // checkSMS
            // 
            this.checkSMS.AutoSize = true;
            this.checkSMS.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSMS.Location = new System.Drawing.Point(159, 33);
            this.checkSMS.Name = "checkSMS";
            this.checkSMS.Size = new System.Drawing.Size(250, 35);
            this.checkSMS.TabIndex = 3;
            this.checkSMS.Text = "SMS Notifications";
            this.checkSMS.UseVisualStyleBackColor = true;
            this.checkSMS.CheckedChanged += new System.EventHandler(this.checkSMS_CheckedChanged);
            // 
            // checkTransactions
            // 
            this.checkTransactions.AutoSize = true;
            this.checkTransactions.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTransactions.Location = new System.Drawing.Point(159, 147);
            this.checkTransactions.Name = "checkTransactions";
            this.checkTransactions.Size = new System.Drawing.Size(289, 35);
            this.checkTransactions.TabIndex = 2;
            this.checkTransactions.Text = "Transactions Reports";
            this.checkTransactions.UseVisualStyleBackColor = true;
            this.checkTransactions.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(284, 396);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(172, 45);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Sign Up";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Name = "Signup";
            this.Text = "Sign Up";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkReports;
        private System.Windows.Forms.CheckBox checkSMS;
        private System.Windows.Forms.CheckBox checkTransactions;
        private System.Windows.Forms.Label labelTransactions;
        private System.Windows.Forms.Label labelSMS;
        private System.Windows.Forms.Button submitButton;
    }
}

