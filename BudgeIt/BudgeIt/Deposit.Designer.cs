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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deposit));
            this.buttonAllTransaction = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDepositBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDepositAmount = new System.Windows.Forms.TextBox();
            this.buttonDepositDelete = new System.Windows.Forms.Button();
            this.buttonDepositDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepositNewBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDepositCurrentBalance = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Black;
            this.buttonAllTransaction.Location = new System.Drawing.Point(321, 331);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(167, 32);
            this.buttonAllTransaction.TabIndex = 43;
            this.buttonAllTransaction.Text = "All Transaction";
            this.buttonAllTransaction.UseVisualStyleBackColor = false;
            this.buttonAllTransaction.Click += new System.EventHandler(this.buttonAllTransaction_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(315, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 42;
            this.label5.Text = "Deposit";
            // 
            // buttonDepositBack
            // 
            this.buttonDepositBack.BackColor = System.Drawing.Color.Black;
            this.buttonDepositBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDepositBack.ForeColor = System.Drawing.Color.White;
            this.buttonDepositBack.Location = new System.Drawing.Point(449, 266);
            this.buttonDepositBack.Name = "buttonDepositBack";
            this.buttonDepositBack.Size = new System.Drawing.Size(105, 49);
            this.buttonDepositBack.TabIndex = 38;
            this.buttonDepositBack.Text = "Back";
            this.buttonDepositBack.UseVisualStyleBackColor = false;
            this.buttonDepositBack.Click += new System.EventHandler(this.buttonDepositBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter an amount :";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(261, 185);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositAmount.TabIndex = 36;
            // 
            // buttonDepositDelete
            // 
            this.buttonDepositDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDepositDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDepositDelete.Location = new System.Drawing.Point(339, 266);
            this.buttonDepositDelete.Name = "buttonDepositDelete";
            this.buttonDepositDelete.Size = new System.Drawing.Size(105, 49);
            this.buttonDepositDelete.TabIndex = 35;
            this.buttonDepositDelete.Text = "Clear";
            this.buttonDepositDelete.UseVisualStyleBackColor = false;
            this.buttonDepositDelete.Click += new System.EventHandler(this.buttonDepositDelete_Click);
            // 
            // buttonDepositDeposit
            // 
            this.buttonDepositDeposit.BackColor = System.Drawing.Color.Black;
            this.buttonDepositDeposit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDeposit.ForeColor = System.Drawing.Color.White;
            this.buttonDepositDeposit.Location = new System.Drawing.Point(229, 266);
            this.buttonDepositDeposit.Name = "buttonDepositDeposit";
            this.buttonDepositDeposit.Size = new System.Drawing.Size(105, 49);
            this.buttonDepositDeposit.TabIndex = 34;
            this.buttonDepositDeposit.Text = "Deposit";
            this.buttonDepositDeposit.UseVisualStyleBackColor = false;
            this.buttonDepositDeposit.Click += new System.EventHandler(this.buttonDepositDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "New balance is :";
            // 
            // textBoxDepositNewBalance
            // 
            this.textBoxDepositNewBalance.Location = new System.Drawing.Point(261, 229);
            this.textBoxDepositNewBalance.Name = "textBoxDepositNewBalance";
            this.textBoxDepositNewBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositNewBalance.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxDepositCurrentBalance
            // 
            this.textBoxDepositCurrentBalance.Location = new System.Drawing.Point(261, 144);
            this.textBoxDepositCurrentBalance.Name = "textBoxDepositCurrentBalance";
            this.textBoxDepositCurrentBalance.Size = new System.Drawing.Size(254, 20);
            this.textBoxDepositCurrentBalance.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 382);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1064, 743);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDepositBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDepositAmount);
            this.Controls.Add(this.buttonDepositDelete);
            this.Controls.Add(this.buttonDepositDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDepositNewBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDepositCurrentBalance);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonDepositBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDepositAmount;
        private System.Windows.Forms.Button buttonDepositDelete;
        private System.Windows.Forms.Button buttonDepositDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepositNewBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDepositCurrentBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}