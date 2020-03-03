namespace BudgeIt
{
    partial class Deposit
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
            this.buttonGotoBills = new System.Windows.Forms.Button();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGoToWithdraw = new System.Windows.Forms.Button();
            this.comboBoxDepositUserID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDepositBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDepositDelete = new System.Windows.Forms.Button();
            this.buttonDepositDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepositNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepositCurrentBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGotoBills
            // 
            this.buttonGotoBills.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGotoBills.ForeColor = System.Drawing.Color.Green;
            this.buttonGotoBills.Location = new System.Drawing.Point(597, 832);
            this.buttonGotoBills.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGotoBills.Name = "buttonGotoBills";
            this.buttonGotoBills.Size = new System.Drawing.Size(334, 62);
            this.buttonGotoBills.TabIndex = 44;
            this.buttonGotoBills.Text = "Go to Bills";
            this.buttonGotoBills.UseVisualStyleBackColor = true;
            this.buttonGotoBills.Click += new System.EventHandler(this.buttonGotoBills_Click);
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(597, 759);
            this.buttonAllTransaction.Margin = new System.Windows.Forms.Padding(6);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(334, 62);
            this.buttonAllTransaction.TabIndex = 43;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            this.buttonAllTransaction.Click += new System.EventHandler(this.buttonAllTransaction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(631, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 70);
            this.label5.TabIndex = 42;
            this.label5.Text = "Deposit";
            // 
            // buttonGoToWithdraw
            // 
            this.buttonGoToWithdraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonGoToWithdraw.Location = new System.Drawing.Point(597, 686);
            this.buttonGoToWithdraw.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGoToWithdraw.Name = "buttonGoToWithdraw";
            this.buttonGoToWithdraw.Size = new System.Drawing.Size(334, 62);
            this.buttonGoToWithdraw.TabIndex = 41;
            this.buttonGoToWithdraw.Text = "Go to Withdraw";
            this.buttonGoToWithdraw.UseVisualStyleBackColor = true;
            this.buttonGoToWithdraw.Click += new System.EventHandler(this.buttonGoToWithdraw_Click);
            // 
            // comboBoxDepositUserID
            // 
            this.comboBoxDepositUserID.FormattingEnabled = true;
            this.comboBoxDepositUserID.Location = new System.Drawing.Point(521, 196);
            this.comboBoxDepositUserID.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxDepositUserID.Name = "comboBoxDepositUserID";
            this.comboBoxDepositUserID.Size = new System.Drawing.Size(504, 33);
            this.comboBoxDepositUserID.TabIndex = 40;
            this.comboBoxDepositUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepositUserID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 39);
            this.label4.TabIndex = 39;
            this.label4.Text = "User ID :";
            // 
            // buttonDepositBack
            // 
            this.buttonDepositBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDepositBack.Location = new System.Drawing.Point(869, 511);
            this.buttonDepositBack.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDepositBack.Name = "buttonDepositBack";
            this.buttonDepositBack.Size = new System.Drawing.Size(160, 63);
            this.buttonDepositBack.TabIndex = 38;
            this.buttonDepositBack.Text = "Back";
            this.buttonDepositBack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(211, 357);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter an amount :";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(521, 355);
            this.textBoxDepositAmount.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(504, 31);
            this.textBoxDepositAmount.TabIndex = 36;
            // 
            // buttonDepositDelete
            // 
            this.buttonDepositDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDelete.Location = new System.Drawing.Point(693, 511);
            this.buttonDepositDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDepositDelete.Name = "buttonDepositDelete";
            this.buttonDepositDelete.Size = new System.Drawing.Size(164, 63);
            this.buttonDepositDelete.TabIndex = 35;
            this.buttonDepositDelete.Text = "Clear";
            this.buttonDepositDelete.UseVisualStyleBackColor = true;
            this.buttonDepositDelete.Click += new System.EventHandler(this.buttonDepositDelete_Click);
            // 
            // buttonDepositDeposit
            // 
            this.buttonDepositDeposit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonDepositDeposit.Location = new System.Drawing.Point(521, 511);
            this.buttonDepositDeposit.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDepositDeposit.Name = "buttonDepositDeposit";
            this.buttonDepositDeposit.Size = new System.Drawing.Size(160, 63);
            this.buttonDepositDeposit.TabIndex = 34;
            this.buttonDepositDeposit.Text = "Deposit";
            this.buttonDepositDeposit.UseVisualStyleBackColor = true;
            this.buttonDepositDeposit.Click += new System.EventHandler(this.buttonDepositDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 33;
            this.label2.Text = "New balance is :";
            // 
            // textBoxDepositNewBalance
            // 
            this.textBoxDepositNewBalance.Location = new System.Drawing.Point(521, 440);
            this.textBoxDepositNewBalance.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDepositNewBalance.Name = "textBoxDepositNewBalance";
            this.textBoxDepositNewBalance.Size = new System.Drawing.Size(504, 31);
            this.textBoxDepositNewBalance.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxDepositCurrentBalance
            // 
            this.textBoxDepositCurrentBalance.Location = new System.Drawing.Point(521, 278);
            this.textBoxDepositCurrentBalance.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxDepositCurrentBalance.Name = "textBoxDepositCurrentBalance";
            this.textBoxDepositCurrentBalance.Size = new System.Drawing.Size(504, 31);
            this.textBoxDepositCurrentBalance.TabIndex = 30;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 929);
            this.Controls.Add(this.buttonGotoBills);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGoToWithdraw);
            this.Controls.Add(this.comboBoxDepositUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDepositBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.buttonDepositDelete);
            this.Controls.Add(this.buttonDepositDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDepositNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDepositCurrentBalance);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGotoBills;
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGoToWithdraw;
        private System.Windows.Forms.ComboBox comboBoxDepositUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDepositBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Button buttonDepositDelete;
        private System.Windows.Forms.Button buttonDepositDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepositNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepositCurrentBalance;
    }
}