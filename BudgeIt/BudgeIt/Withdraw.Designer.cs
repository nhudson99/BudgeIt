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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonAllTransaction = new System.Windows.Forms.Button();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(599, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 18);
            this.label10.TabIndex = 72;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(599, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 18);
            this.label7.TabIndex = 70;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(162, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Notes :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(339, 197);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(254, 20);
            this.textBoxDescription.TabIndex = 68;
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Black;
            this.buttonAllTransaction.Location = new System.Drawing.Point(398, 356);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(185, 53);
            this.buttonAllTransaction.TabIndex = 67;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(392, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 35);
            this.label5.TabIndex = 65;
            this.label5.Text = "Withdraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(162, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Enter an amount :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.label8.Location = new System.Drawing.Point(599, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 71;
            this.label8.Text = "$";
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawBack.Location = new System.Drawing.Point(541, 278);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(113, 53);
            this.buttonWithdrawBack.TabIndex = 61;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = false;
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(339, 153);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawAmount.TabIndex = 60;
            // 
            // buttonWithdrawDelete
            // 
            this.buttonWithdrawDelete.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawDelete.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawDelete.Location = new System.Drawing.Point(423, 278);
            this.buttonWithdrawDelete.Name = "buttonWithdrawDelete";
            this.buttonWithdrawDelete.Size = new System.Drawing.Size(113, 53);
            this.buttonWithdrawDelete.TabIndex = 59;
            this.buttonWithdrawDelete.Text = "Clear";
            this.buttonWithdrawDelete.UseVisualStyleBackColor = false;
            this.buttonWithdrawDelete.Click += new System.EventHandler(this.buttonWithdrawDelete_Click_1);
            // 
            // buttonWithdrawWithdraw
            // 
            this.buttonWithdrawWithdraw.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawWithdraw.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawWithdraw.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawWithdraw.Location = new System.Drawing.Point(305, 278);
            this.buttonWithdrawWithdraw.Name = "buttonWithdrawWithdraw";
            this.buttonWithdrawWithdraw.Size = new System.Drawing.Size(113, 53);
            this.buttonWithdrawWithdraw.TabIndex = 58;
            this.buttonWithdrawWithdraw.Text = "Withdraw";
            this.buttonWithdrawWithdraw.UseVisualStyleBackColor = false;
            this.buttonWithdrawWithdraw.Click += new System.EventHandler(this.buttonWithdrawWithdraw_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(162, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 57;
            this.label2.Text = "New balance is :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxWithdrawNewBalance
            // 
            this.textBoxWithdrawNewBalance.Location = new System.Drawing.Point(339, 239);
            this.textBoxWithdrawNewBalance.Name = "textBoxWithdrawNewBalance";
            this.textBoxWithdrawNewBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawNewBalance.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(162, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Current balance is :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxWithdrawCurrentBalance
            // 
            this.textBoxWithdrawCurrentBalance.Location = new System.Drawing.Point(339, 113);
            this.textBoxWithdrawCurrentBalance.Name = "textBoxWithdrawCurrentBalance";
            this.textBoxWithdrawCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxWithdrawCurrentBalance.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 297);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 252);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(33, 49);
            this.lblName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 39);
            this.lblName.TabIndex = 75;
            this.lblName.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 74;
            this.label4.Text = "Welcome,";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(901, 548);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.buttonAllTransaction);
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
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAllTransaction;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label4;
    }
}