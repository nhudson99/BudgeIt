namespace BudgeIt
{
    partial class Bills
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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonGoToWithdraw = new System.Windows.Forms.Button();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.buttonGoToDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBillsUserID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWithdrawBack = new System.Windows.Forms.Button();
            this.textBoxBillsAmount = new System.Windows.Forms.TextBox();
            this.buttonBillsDelete = new System.Windows.Forms.Button();
            this.buttonBillsPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBillsNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBillsCurrentBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(616, 225);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 68;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(616, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 66;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(166, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Bill type :";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(356, 189);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescription.TabIndex = 64;
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
            this.label8.Location = new System.Drawing.Point(616, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 67;
            this.label8.Text = "$";
            // 
            // buttonGoToWithdraw
            // 
            this.buttonGoToWithdraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonGoToWithdraw.Location = new System.Drawing.Point(399, 333);
            this.buttonGoToWithdraw.Name = "buttonGoToWithdraw";
            this.buttonGoToWithdraw.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToWithdraw.TabIndex = 63;
            this.buttonGoToWithdraw.Text = "Go to Withdraw";
            this.buttonGoToWithdraw.UseVisualStyleBackColor = true;
            this.buttonGoToWithdraw.Click += new System.EventHandler(this.buttonGoToWithdraw_Click);
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(399, 409);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(167, 32);
            this.buttonAllTransaction.TabIndex = 62;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            this.buttonAllTransaction.Click += new System.EventHandler(this.buttonAllTransaction_Click);
            // 
            // buttonGoToDeposit
            // 
            this.buttonGoToDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonGoToDeposit.Location = new System.Drawing.Point(399, 371);
            this.buttonGoToDeposit.Name = "buttonGoToDeposit";
            this.buttonGoToDeposit.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToDeposit.TabIndex = 61;
            this.buttonGoToDeposit.Text = "Go to Deposit";
            this.buttonGoToDeposit.UseVisualStyleBackColor = true;
            this.buttonGoToDeposit.Click += new System.EventHandler(this.buttonGoToDeposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(436, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 35);
            this.label5.TabIndex = 60;
            this.label5.Text = "Bills";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Enter the bill amount :";
            // 
            // comboBoxBillsUserID
            // 
            this.comboBoxBillsUserID.FormattingEnabled = true;
            this.comboBoxBillsUserID.Location = new System.Drawing.Point(356, 66);
            this.comboBoxBillsUserID.Name = "comboBoxBillsUserID";
            this.comboBoxBillsUserID.Size = new System.Drawing.Size(254, 21);
            this.comboBoxBillsUserID.TabIndex = 58;
            this.comboBoxBillsUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxBillsUserID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(166, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "User ID :";
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.Location = new System.Drawing.Point(530, 266);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(80, 33);
            this.buttonWithdrawBack.TabIndex = 56;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = true;
            // 
            // textBoxBillsAmount
            // 
            this.textBoxBillsAmount.Location = new System.Drawing.Point(356, 151);
            this.textBoxBillsAmount.Name = "textBoxBillsAmount";
            this.textBoxBillsAmount.Size = new System.Drawing.Size(254, 20);
            this.textBoxBillsAmount.TabIndex = 55;
            // 
            // buttonBillsDelete
            // 
            this.buttonBillsDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillsDelete.Location = new System.Drawing.Point(442, 266);
            this.buttonBillsDelete.Name = "buttonBillsDelete";
            this.buttonBillsDelete.Size = new System.Drawing.Size(82, 33);
            this.buttonBillsDelete.TabIndex = 54;
            this.buttonBillsDelete.Text = "Clear";
            this.buttonBillsDelete.UseVisualStyleBackColor = true;
            this.buttonBillsDelete.Click += new System.EventHandler(this.buttonBillsDelete_Click);
            // 
            // buttonBillsPay
            // 
            this.buttonBillsPay.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillsPay.ForeColor = System.Drawing.Color.Red;
            this.buttonBillsPay.Location = new System.Drawing.Point(356, 266);
            this.buttonBillsPay.Name = "buttonBillsPay";
            this.buttonBillsPay.Size = new System.Drawing.Size(80, 33);
            this.buttonBillsPay.TabIndex = 53;
            this.buttonBillsPay.Text = "Pay";
            this.buttonBillsPay.UseVisualStyleBackColor = true;
            this.buttonBillsPay.Click += new System.EventHandler(this.buttonBillsPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "New balance is :";
            // 
            // textBoxBillsNewBalance
            // 
            this.textBoxBillsNewBalance.Location = new System.Drawing.Point(356, 225);
            this.textBoxBillsNewBalance.Name = "textBoxBillsNewBalance";
            this.textBoxBillsNewBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxBillsNewBalance.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxBillsCurrentBalance
            // 
            this.textBoxBillsCurrentBalance.Location = new System.Drawing.Point(356, 111);
            this.textBoxBillsCurrentBalance.Name = "textBoxBillsCurrentBalance";
            this.textBoxBillsCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxBillsCurrentBalance.TabIndex = 49;
            // 
            // Bills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 484);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonGoToWithdraw);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.buttonGoToDeposit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxBillsUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWithdrawBack);
            this.Controls.Add(this.textBoxBillsAmount);
            this.Controls.Add(this.buttonBillsDelete);
            this.Controls.Add(this.buttonBillsPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBillsNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBillsCurrentBalance);
            this.Name = "Bills";
            this.Text = "Bills";
            this.Load += new System.EventHandler(this.Bills_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGoToWithdraw;
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Button buttonGoToDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBillsUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWithdrawBack;
        private System.Windows.Forms.TextBox textBoxBillsAmount;
        private System.Windows.Forms.Button buttonBillsDelete;
        private System.Windows.Forms.Button buttonBillsPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBillsNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBillsCurrentBalance;
    }
}