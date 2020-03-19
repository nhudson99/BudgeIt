namespace BudgeIt
{
    partial class Calendar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAudit = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.Expenses = new System.Windows.Forms.TextBox();
            this.Disposable = new System.Windows.Forms.TextBox();
            this.Income = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LBLName = new System.Windows.Forms.Label();
            this.btnTrans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Disposable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expenses";
            // 
            // btnAudit
            // 
            this.btnAudit.Location = new System.Drawing.Point(478, 65);
            this.btnAudit.Margin = new System.Windows.Forms.Padding(2);
            this.btnAudit.Name = "btnAudit";
            this.btnAudit.Size = new System.Drawing.Size(56, 19);
            this.btnAudit.TabIndex = 7;
            this.btnAudit.Text = "Audit";
            this.btnAudit.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(212, 389);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(106, 58);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(323, 389);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(106, 58);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnBills
            // 
            this.btnBills.Location = new System.Drawing.Point(434, 389);
            this.btnBills.Margin = new System.Windows.Forms.Padding(2);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(106, 58);
            this.btnBills.TabIndex = 10;
            this.btnBills.Text = "Bills";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // Expenses
            // 
            this.Expenses.Location = new System.Drawing.Point(373, 38);
            this.Expenses.Name = "Expenses";
            this.Expenses.Size = new System.Drawing.Size(100, 20);
            this.Expenses.TabIndex = 12;
            // 
            // Disposable
            // 
            this.Disposable.Location = new System.Drawing.Point(373, 77);
            this.Disposable.Name = "Disposable";
            this.Disposable.Size = new System.Drawing.Size(100, 20);
            this.Disposable.TabIndex = 13;
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(373, 127);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(100, 20);
            this.Income.TabIndex = 14;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(373, 194);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Location = new System.Drawing.Point(100, 13);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(35, 13);
            this.LBLName.TabIndex = 17;
            this.LBLName.Text = "label5";
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(544, 389);
            this.btnTrans.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(106, 58);
            this.btnTrans.TabIndex = 18;
            this.btnTrans.Text = "Transaction History";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click_1);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 642);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.LBLName);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.Disposable);
            this.Controls.Add(this.Expenses);
            this.Controls.Add(this.btnBills);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnAudit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAudit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.TextBox Expenses;
        private System.Windows.Forms.TextBox Disposable;
        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Button btnTrans;
    }
}

