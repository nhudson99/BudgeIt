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
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.buttonGoToDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonWithdrawBack = new System.Windows.Forms.Button();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.buttonWithdrawDelete = new System.Windows.Forms.Button();
            this.buttonWithdrawWithdraw = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWithdrawNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWithdrawCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1198, 460);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 36);
            this.label10.TabIndex = 72;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1198, 217);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 36);
            this.label7.TabIndex = 70;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 375);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 39);
            this.label6.TabIndex = 69;
            this.label6.Text = "Notes :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(678, 379);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(504, 31);
            this.textBoxDescription.TabIndex = 68;
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(768, 787);
            this.buttonAllTransaction.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(334, 62);
            this.buttonAllTransaction.TabIndex = 67;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonGoToDeposit
            // 
            this.buttonGoToDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonGoToDeposit.Location = new System.Drawing.Point(768, 713);
            this.buttonGoToDeposit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGoToDeposit.Name = "buttonGoToDeposit";
            this.buttonGoToDeposit.Size = new System.Drawing.Size(334, 62);
            this.buttonGoToDeposit.TabIndex = 66;
            this.buttonGoToDeposit.Text = "Go to Deposit";
            this.buttonGoToDeposit.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(784, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(318, 70);
            this.label5.TabIndex = 65;
            this.label5.Text = "Withdraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 39);
            this.label3.TabIndex = 64;
            this.label3.Text = "Enter an amount :";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KFSC-PC;Initial Catalog=TestMoney;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1198, 298);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 36);
            this.label8.TabIndex = 71;
            this.label8.Text = "$";
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.Location = new System.Drawing.Point(1026, 538);
            this.buttonWithdrawBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(160, 63);
            this.buttonWithdrawBack.TabIndex = 61;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = true;
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(678, 294);
            this.textBoxWithdrawAmount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(504, 31);
            this.textBoxWithdrawAmount.TabIndex = 60;
            // 
            // buttonWithdrawDelete
            // 
            this.buttonWithdrawDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawDelete.Location = new System.Drawing.Point(850, 538);
            this.buttonWithdrawDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonWithdrawDelete.Name = "buttonWithdrawDelete";
            this.buttonWithdrawDelete.Size = new System.Drawing.Size(164, 63);
            this.buttonWithdrawDelete.TabIndex = 59;
            this.buttonWithdrawDelete.Text = "Clear";
            this.buttonWithdrawDelete.UseVisualStyleBackColor = true;
            this.buttonWithdrawDelete.Click += new System.EventHandler(this.buttonWithdrawDelete_Click_1);
            // 
            // buttonWithdrawWithdraw
            // 
            this.buttonWithdrawWithdraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonWithdrawWithdraw.Location = new System.Drawing.Point(678, 538);
            this.buttonWithdrawWithdraw.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonWithdrawWithdraw.Name = "buttonWithdrawWithdraw";
            this.buttonWithdrawWithdraw.Size = new System.Drawing.Size(160, 63);
            this.buttonWithdrawWithdraw.TabIndex = 58;
            this.buttonWithdrawWithdraw.Text = "Withdraw";
            this.buttonWithdrawWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdrawWithdraw.Click += new System.EventHandler(this.buttonWithdrawWithdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 456);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 39);
            this.label2.TabIndex = 57;
            this.label2.Text = "New balance is :";
            // 
            // textBoxWithdrawNewBalance
            // 
            this.textBoxWithdrawNewBalance.Location = new System.Drawing.Point(678, 460);
            this.textBoxWithdrawNewBalance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxWithdrawNewBalance.Name = "textBoxWithdrawNewBalance";
            this.textBoxWithdrawNewBalance.Size = new System.Drawing.Size(504, 31);
            this.textBoxWithdrawNewBalance.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 39);
            this.label1.TabIndex = 55;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxWithdrawCurrentBalance
            // 
            this.textBoxWithdrawCurrentBalance.Location = new System.Drawing.Point(678, 217);
            this.textBoxWithdrawCurrentBalance.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxWithdrawCurrentBalance.Name = "textBoxWithdrawCurrentBalance";
            this.textBoxWithdrawCurrentBalance.Size = new System.Drawing.Size(504, 31);
            this.textBoxWithdrawCurrentBalance.TabIndex = 54;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(302, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 74;
            this.lblName.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Welcome,";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1718, 956);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.buttonGoToDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonWithdrawBack);
            this.Controls.Add(this.textBoxWithdrawAmount);
            this.Controls.Add(this.buttonWithdrawDelete);
            this.Controls.Add(this.buttonWithdrawWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWithdrawNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWithdrawCurrentBalance);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Withdraw";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 100, 100);
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Button buttonGoToDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonWithdrawBack;
        private System.Windows.Forms.TextBox textBoxWithdrawAmount;
        private System.Windows.Forms.Button buttonWithdrawDelete;
        private System.Windows.Forms.Button buttonWithdrawWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWithdrawNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWithdrawCurrentBalance;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
    }
}