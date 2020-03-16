namespace BudgeIt
{
    partial class Transactions
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
            this.textBoxTransactionsCurrentBalance = new System.Windows.Forms.TextBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonGoToDeposit = new System.Windows.Forms.Button();
            this.buttonGoToWithdraw = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxTransactionsUserID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxTransactionsCurrentBalance
            // 
            this.textBoxTransactionsCurrentBalance.Location = new System.Drawing.Point(310, 82);
            this.textBoxTransactionsCurrentBalance.Name = "textBoxTransactionsCurrentBalance";
            this.textBoxTransactionsCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxTransactionsCurrentBalance.TabIndex = 42;
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHome.Location = new System.Drawing.Point(346, 447);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(167, 33);
            this.buttonHome.TabIndex = 41;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            // 
            // buttonGoToDeposit
            // 
            this.buttonGoToDeposit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToDeposit.ForeColor = System.Drawing.Color.Green;
            this.buttonGoToDeposit.Location = new System.Drawing.Point(161, 448);
            this.buttonGoToDeposit.Name = "buttonGoToDeposit";
            this.buttonGoToDeposit.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToDeposit.TabIndex = 40;
            this.buttonGoToDeposit.Text = "Go to Deposit";
            this.buttonGoToDeposit.UseVisualStyleBackColor = true;
            // 
            // buttonGoToWithdraw
            // 
            this.buttonGoToWithdraw.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToWithdraw.ForeColor = System.Drawing.Color.Red;
            this.buttonGoToWithdraw.Location = new System.Drawing.Point(528, 448);
            this.buttonGoToWithdraw.Name = "buttonGoToWithdraw";
            this.buttonGoToWithdraw.Size = new System.Drawing.Size(167, 32);
            this.buttonGoToWithdraw.TabIndex = 39;
            this.buttonGoToWithdraw.Text = "Go to Withdraw";
            this.buttonGoToWithdraw.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(534, 295);
            this.dataGridView1.TabIndex = 38;
            // 
            // comboBoxTransactionsUserID
            // 
            this.comboBoxTransactionsUserID.FormattingEnabled = true;
            this.comboBoxTransactionsUserID.Location = new System.Drawing.Point(310, 45);
            this.comboBoxTransactionsUserID.Name = "comboBoxTransactionsUserID";
            this.comboBoxTransactionsUserID.Size = new System.Drawing.Size(254, 21);
            this.comboBoxTransactionsUserID.TabIndex = 37;
            this.comboBoxTransactionsUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxTransactionsUserID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 36;
            this.label4.Text = "User ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(304, -30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 35);
            this.label5.TabIndex = 35;
            this.label5.Text = "All Transactions";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=KFSC-PC;Initial Catalog=TestMoney;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTransactionsCurrentBalance);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonGoToDeposit);
            this.Controls.Add(this.buttonGoToWithdraw);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTransactionsUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTransactionsCurrentBalance;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonGoToDeposit;
        private System.Windows.Forms.Button buttonGoToWithdraw;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxTransactionsUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
    }
}