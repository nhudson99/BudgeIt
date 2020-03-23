namespace BudgeIt
{
    partial class Withdraw
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
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.buttonGoToDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxWithdrawUserID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWithdrawBack = new System.Windows.Forms.Button();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.buttonWithdrawDelete = new System.Windows.Forms.Button();
            this.buttonWithdrawWithdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWithdrawNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWithdrawCurrentBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(521, 598);
            this.buttonAllTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(250, 50);
            this.buttonAllTransaction.TabIndex = 41;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonGoToDeposit
            // 
            this.buttonGoToDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonGoToDeposit.Location = new System.Drawing.Point(521, 540);
            this.buttonGoToDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGoToDeposit.Name = "buttonGoToDeposit";
            this.buttonGoToDeposit.Size = new System.Drawing.Size(250, 50);
            this.buttonGoToDeposit.TabIndex = 40;
            this.buttonGoToDeposit.Text = "Go to Deposit";
            this.buttonGoToDeposit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(533, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 53);
            this.label5.TabIndex = 39;
            this.label5.Text = "Withdraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Enter an amount :";
            // 
            // comboBoxWithdrawUserID
            // 
            this.comboBoxWithdrawUserID.FormattingEnabled = true;
            this.comboBoxWithdrawUserID.Location = new System.Drawing.Point(454, 138);
            this.comboBoxWithdrawUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxWithdrawUserID.Name = "comboBoxWithdrawUserID";
            this.comboBoxWithdrawUserID.Size = new System.Drawing.Size(379, 28);
            this.comboBoxWithdrawUserID.TabIndex = 37;
            this.comboBoxWithdrawUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxWithdrawUserID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 36;
            this.label4.Text = "User ID :";
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.Location = new System.Drawing.Point(715, 400);
            this.buttonWithdrawBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(120, 50);
            this.buttonWithdrawBack.TabIndex = 35;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = true;
            this.buttonWithdrawBack.Click += new System.EventHandler(this.buttonWithdrawBack_Click);
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(454, 269);
            this.textBoxWithdrawAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawAmount.TabIndex = 34;
            // 
            // buttonWithdrawDelete
            // 
            this.buttonWithdrawDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawDelete.Location = new System.Drawing.Point(583, 400);
            this.buttonWithdrawDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawDelete.Name = "buttonWithdrawDelete";
            this.buttonWithdrawDelete.Size = new System.Drawing.Size(123, 50);
            this.buttonWithdrawDelete.TabIndex = 33;
            this.buttonWithdrawDelete.Text = "Clear";
            this.buttonWithdrawDelete.UseVisualStyleBackColor = true;
            this.buttonWithdrawDelete.Click += new System.EventHandler(this.buttonWithdrawDelete_Click);
            // 
            // buttonWithdrawWithdraw
            // 
            this.buttonWithdrawWithdraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonWithdrawWithdraw.Location = new System.Drawing.Point(454, 400);
            this.buttonWithdrawWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawWithdraw.Name = "buttonWithdrawWithdraw";
            this.buttonWithdrawWithdraw.Size = new System.Drawing.Size(120, 50);
            this.buttonWithdrawWithdraw.TabIndex = 32;
            this.buttonWithdrawWithdraw.Text = "Withdraw";
            this.buttonWithdrawWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdrawWithdraw.Click += new System.EventHandler(this.buttonWithdrawWithdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 334);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "New balance is :";
            // 
            // textBoxWithdrawNewBalance
            // 
            this.textBoxWithdrawNewBalance.Location = new System.Drawing.Point(454, 337);
            this.textBoxWithdrawNewBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawNewBalance.Name = "textBoxWithdrawNewBalance";
            this.textBoxWithdrawNewBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawNewBalance.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 204);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxWithdrawCurrentBalance
            // 
            this.textBoxWithdrawCurrentBalance.Location = new System.Drawing.Point(454, 207);
            this.textBoxWithdrawCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawCurrentBalance.Name = "textBoxWithdrawCurrentBalance";
            this.textBoxWithdrawCurrentBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawCurrentBalance.TabIndex = 28;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 696);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.buttonGoToDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxWithdrawUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWithdrawBack);
            this.Controls.Add(this.textBoxWithdrawAmount);
            this.Controls.Add(this.buttonWithdrawDelete);
            this.Controls.Add(this.buttonWithdrawWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWithdrawNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWithdrawCurrentBalance);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Button buttonGoToDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxWithdrawUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWithdrawBack;
        private System.Windows.Forms.TextBox textBoxWithdrawAmount;
        private System.Windows.Forms.Button buttonWithdrawDelete;
        private System.Windows.Forms.Button buttonWithdrawWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWithdrawNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWithdrawCurrentBalance;
    }
}