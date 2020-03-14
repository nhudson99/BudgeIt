namespace MoneySys
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
            this.buttonDepositBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDepositDelete = new System.Windows.Forms.Button();
            this.buttonDepositDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepositNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepositCurrentBalance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDepositUserID = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.buttonGoToWithdraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.buttonGotoBills = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDepositBack
            // 
            this.buttonDepositBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDepositBack.Location = new System.Drawing.Point(565, 286);
            this.buttonDepositBack.Name = "buttonDepositBack";
            this.buttonDepositBack.Size = new System.Drawing.Size(80, 33);
            this.buttonDepositBack.TabIndex = 17;
            this.buttonDepositBack.Text = "Back";
            this.buttonDepositBack.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Enter an amount :";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(389, 176);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositAmount.TabIndex = 15;
            // 
            // buttonDepositDelete
            // 
            this.buttonDepositDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDelete.Location = new System.Drawing.Point(477, 286);
            this.buttonDepositDelete.Name = "buttonDepositDelete";
            this.buttonDepositDelete.Size = new System.Drawing.Size(82, 33);
            this.buttonDepositDelete.TabIndex = 14;
            this.buttonDepositDelete.Text = "Clear";
            this.buttonDepositDelete.UseVisualStyleBackColor = true;
            this.buttonDepositDelete.Click += new System.EventHandler(this.buttonDepositDelete_Click);
            // 
            // buttonDepositDeposit
            // 
            this.buttonDepositDeposit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonDepositDeposit.Location = new System.Drawing.Point(391, 286);
            this.buttonDepositDeposit.Name = "buttonDepositDeposit";
            this.buttonDepositDeposit.Size = new System.Drawing.Size(80, 33);
            this.buttonDepositDeposit.TabIndex = 13;
            this.buttonDepositDeposit.Text = "Deposit";
            this.buttonDepositDeposit.UseVisualStyleBackColor = true;
            this.buttonDepositDeposit.Click += new System.EventHandler(this.buttonDepositDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "New balance is :";
            // 
            // textBoxDepositNewBalance
            // 
            this.textBoxDepositNewBalance.Location = new System.Drawing.Point(391, 249);
            this.textBoxDepositNewBalance.Name = "textBoxDepositNewBalance";
            this.textBoxDepositNewBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositNewBalance.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxDepositCurrentBalance
            // 
            this.textBoxDepositCurrentBalance.Location = new System.Drawing.Point(389, 136);
            this.textBoxDepositCurrentBalance.Name = "textBoxDepositCurrentBalance";
            this.textBoxDepositCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositCurrentBalance.TabIndex = 9;
            this.textBoxDepositCurrentBalance.TextChanged += new System.EventHandler(this.textBoxDepositCurrentBalance_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "User ID :";
            // 
            // comboBoxDepositUserID
            // 
            this.comboBoxDepositUserID.FormattingEnabled = true;
            this.comboBoxDepositUserID.Location = new System.Drawing.Point(389, 93);
            this.comboBoxDepositUserID.Name = "comboBoxDepositUserID";
            this.comboBoxDepositUserID.Size = new System.Drawing.Size(254, 21);
            this.comboBoxDepositUserID.TabIndex = 22;
            this.comboBoxDepositUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepositUserID_SelectedIndexChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KFSC-PC;Initial Catalog=TestMoney;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // buttonGoToWithdraw
            // 
            this.buttonGoToWithdraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonGoToWithdraw.Location = new System.Drawing.Point(429, 377);
            this.buttonGoToWithdraw.Name = "buttonGoToWithdraw";
            this.buttonGoToWithdraw.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToWithdraw.TabIndex = 23;
            this.buttonGoToWithdraw.Text = "Go to Withdraw";
            this.buttonGoToWithdraw.UseVisualStyleBackColor = true;
            this.buttonGoToWithdraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(444, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 24;
            this.label5.Text = "Deposit";
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(429, 415);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(167, 32);
            this.buttonAllTransaction.TabIndex = 28;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            this.buttonAllTransaction.Click += new System.EventHandler(this.buttonAllTransaction_Click);
            // 
            // buttonGotoBills
            // 
            this.buttonGotoBills.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGotoBills.ForeColor = System.Drawing.Color.Green;
            this.buttonGotoBills.Location = new System.Drawing.Point(429, 453);
            this.buttonGotoBills.Name = "buttonGotoBills";
            this.buttonGotoBills.Size = new System.Drawing.Size(167, 32);
            this.buttonGotoBills.TabIndex = 29;
            this.buttonGotoBills.Text = "Go to Bills";
            this.buttonGotoBills.UseVisualStyleBackColor = true;
            this.buttonGotoBills.Click += new System.EventHandler(this.buttonGotoBills_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(236, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Notes :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(391, 213);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescription.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(649, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(649, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 55;
            this.label8.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(649, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 56;
            this.label10.Text = "$";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 571);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
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

        private System.Windows.Forms.Button buttonDepositBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Button buttonDepositDelete;
        private System.Windows.Forms.Button buttonDepositDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepositNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepositCurrentBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDepositUserID;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Button buttonGoToWithdraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Button buttonGotoBills;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}