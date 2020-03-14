namespace MoneySys
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
            this.textBoxWithdrawCurrentBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWithdrawNewBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWithdrawWithdraw = new System.Windows.Forms.Button();
            this.buttonWithdrawDelete = new System.Windows.Forms.Button();
            this.textBoxWithdrawAmount = new System.Windows.Forms.TextBox();
            this.buttonWithdrawBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWithdrawUserID = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGoToDeposit = new System.Windows.Forms.Button();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxWithdrawCurrentBalance
            // 
            this.textBoxWithdrawCurrentBalance.Location = new System.Drawing.Point(393, 136);
            this.textBoxWithdrawCurrentBalance.Name = "textBoxWithdrawCurrentBalance";
            this.textBoxWithdrawCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawCurrentBalance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxWithdrawNewBalance
            // 
            this.textBoxWithdrawNewBalance.Location = new System.Drawing.Point(393, 262);
            this.textBoxWithdrawNewBalance.Name = "textBoxWithdrawNewBalance";
            this.textBoxWithdrawNewBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawNewBalance.TabIndex = 2;
            this.textBoxWithdrawNewBalance.TextChanged += new System.EventHandler(this.textBoxWithdrawNewBalance_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "New balance is :";
            // 
            // buttonWithdrawWithdraw
            // 
            this.buttonWithdrawWithdraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonWithdrawWithdraw.Location = new System.Drawing.Point(393, 303);
            this.buttonWithdrawWithdraw.Name = "buttonWithdrawWithdraw";
            this.buttonWithdrawWithdraw.Size = new System.Drawing.Size(80, 33);
            this.buttonWithdrawWithdraw.TabIndex = 4;
            this.buttonWithdrawWithdraw.Text = "Withdraw";
            this.buttonWithdrawWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdrawWithdraw.Click += new System.EventHandler(this.buttonWithdrawWithdraw_Click);
            // 
            // buttonWithdrawDelete
            // 
            this.buttonWithdrawDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawDelete.Location = new System.Drawing.Point(479, 303);
            this.buttonWithdrawDelete.Name = "buttonWithdrawDelete";
            this.buttonWithdrawDelete.Size = new System.Drawing.Size(82, 33);
            this.buttonWithdrawDelete.TabIndex = 5;
            this.buttonWithdrawDelete.Text = "Clear";
            this.buttonWithdrawDelete.UseVisualStyleBackColor = true;
            this.buttonWithdrawDelete.Click += new System.EventHandler(this.buttonWithdrawDelete_Click);
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(393, 176);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawAmount.TabIndex = 6;
            this.textBoxWithdrawAmount.TextChanged += new System.EventHandler(this.textBoxWithdrawAmount_TextChanged);
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.Location = new System.Drawing.Point(567, 303);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(80, 33);
            this.buttonWithdrawBack.TabIndex = 8;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "User ID :";
            // 
            // comboBoxWithdrawUserID
            // 
            this.comboBoxWithdrawUserID.FormattingEnabled = true;
            this.comboBoxWithdrawUserID.Location = new System.Drawing.Point(393, 91);
            this.comboBoxWithdrawUserID.Name = "comboBoxWithdrawUserID";
            this.comboBoxWithdrawUserID.Size = new System.Drawing.Size(254, 21);
            this.comboBoxWithdrawUserID.TabIndex = 21;
            this.comboBoxWithdrawUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxWithdrawUserID_SelectedIndexChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KFSC-PC;Initial Catalog=TestMoney;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Enter an amount :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(446, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 35);
            this.label5.TabIndex = 25;
            this.label5.Text = "Withdraw";
            // 
            // buttonGoToDeposit
            // 
            this.buttonGoToDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonGoToDeposit.Location = new System.Drawing.Point(438, 394);
            this.buttonGoToDeposit.Name = "buttonGoToDeposit";
            this.buttonGoToDeposit.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToDeposit.TabIndex = 26;
            this.buttonGoToDeposit.Text = "Go to Deposit";
            this.buttonGoToDeposit.UseVisualStyleBackColor = true;
            this.buttonGoToDeposit.Click += new System.EventHandler(this.buttonGoToDeposit_Click);
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Blue;
            this.buttonAllTransaction.Location = new System.Drawing.Point(438, 432);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(167, 32);
            this.buttonAllTransaction.TabIndex = 27;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = true;
            this.buttonAllTransaction.Click += new System.EventHandler(this.buttonAllTransaction_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Notes :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(393, 220);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescription.TabIndex = 48;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(653, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 53;
            this.label10.Text = "$";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 571);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
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
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWithdrawCurrentBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWithdrawNewBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWithdrawWithdraw;
        private System.Windows.Forms.Button buttonWithdrawDelete;
        private System.Windows.Forms.TextBox textBoxWithdrawAmount;
        private System.Windows.Forms.Button buttonWithdrawBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWithdrawUserID;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonGoToDeposit;
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}