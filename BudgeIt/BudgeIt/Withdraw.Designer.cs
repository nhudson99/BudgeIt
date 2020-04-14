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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(898, 368);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 28);
            this.label10.TabIndex = 72;
            this.label10.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(898, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 28);
            this.label7.TabIndex = 70;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(243, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 69;
            this.label6.Text = "Notes :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(508, 303);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(379, 26);
            this.textBoxDescription.TabIndex = 68;
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Black;
            this.buttonAllTransaction.Location = new System.Drawing.Point(597, 548);
            this.buttonAllTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(278, 82);
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
            this.label5.Location = new System.Drawing.Point(588, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 53);
            this.label5.TabIndex = 65;
            this.label5.Text = "Withdraw";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(243, 232);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
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
            this.label8.Location = new System.Drawing.Point(898, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 28);
            this.label8.TabIndex = 71;
            this.label8.Text = "$";
            // 
            // buttonWithdrawBack
            // 
            this.buttonWithdrawBack.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonWithdrawBack.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawBack.Location = new System.Drawing.Point(812, 428);
            this.buttonWithdrawBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawBack.Name = "buttonWithdrawBack";
            this.buttonWithdrawBack.Size = new System.Drawing.Size(170, 82);
            this.buttonWithdrawBack.TabIndex = 61;
            this.buttonWithdrawBack.Text = "Back";
            this.buttonWithdrawBack.UseVisualStyleBackColor = false;
            this.buttonWithdrawBack.Click += new System.EventHandler(this.buttonWithdrawBack_Click);
            // 
            // textBoxWithdrawAmount
            // 
            this.textBoxWithdrawAmount.Location = new System.Drawing.Point(508, 235);
            this.textBoxWithdrawAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawAmount.Name = "textBoxWithdrawAmount";
            this.textBoxWithdrawAmount.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawAmount.TabIndex = 60;
            // 
            // buttonWithdrawDelete
            // 
            this.buttonWithdrawDelete.BackColor = System.Drawing.Color.Black;
            this.buttonWithdrawDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawDelete.ForeColor = System.Drawing.Color.White;
            this.buttonWithdrawDelete.Location = new System.Drawing.Point(634, 428);
            this.buttonWithdrawDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawDelete.Name = "buttonWithdrawDelete";
            this.buttonWithdrawDelete.Size = new System.Drawing.Size(170, 82);
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
            this.buttonWithdrawWithdraw.Location = new System.Drawing.Point(458, 428);
            this.buttonWithdrawWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonWithdrawWithdraw.Name = "buttonWithdrawWithdraw";
            this.buttonWithdrawWithdraw.Size = new System.Drawing.Size(170, 82);
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
            this.label2.Location = new System.Drawing.Point(243, 362);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "New balance is :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxWithdrawNewBalance
            // 
            this.textBoxWithdrawNewBalance.Location = new System.Drawing.Point(508, 368);
            this.textBoxWithdrawNewBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawNewBalance.Name = "textBoxWithdrawNewBalance";
            this.textBoxWithdrawNewBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawNewBalance.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(243, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Current balance is :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxWithdrawCurrentBalance
            // 
            this.textBoxWithdrawCurrentBalance.Location = new System.Drawing.Point(508, 174);
            this.textBoxWithdrawCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWithdrawCurrentBalance.Name = "textBoxWithdrawCurrentBalance";
            this.textBoxWithdrawCurrentBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxWithdrawCurrentBalance.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 457);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(960, 388);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(993, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(236, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1241, 840);
            this.Controls.Add(this.pictureBox2);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}