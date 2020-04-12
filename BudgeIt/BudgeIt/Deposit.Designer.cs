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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAllTransaction
            // 
            this.buttonAllTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAllTransaction.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllTransaction.ForeColor = System.Drawing.Color.Black;
            this.buttonAllTransaction.Location = new System.Drawing.Point(482, 510);
            this.buttonAllTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAllTransaction.Name = "buttonAllTransaction";
            this.buttonAllTransaction.Size = new System.Drawing.Size(250, 50);
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
            this.label5.Location = new System.Drawing.Point(473, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 53);
            this.label5.TabIndex = 42;
            this.label5.Text = "Deposit";
            // 
            // comboBoxDepositUserID
            // 
            this.comboBoxDepositUserID.FormattingEnabled = true;
            this.comboBoxDepositUserID.Location = new System.Drawing.Point(391, 157);
            this.comboBoxDepositUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxDepositUserID.Name = "comboBoxDepositUserID";
            this.comboBoxDepositUserID.Size = new System.Drawing.Size(379, 28);
            this.comboBoxDepositUserID.TabIndex = 40;
            this.comboBoxDepositUserID.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepositUserID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "User ID :";
            // 
            // buttonDepositBack
            // 
            this.buttonDepositBack.BackColor = System.Drawing.Color.Black;
            this.buttonDepositBack.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDepositBack.ForeColor = System.Drawing.Color.White;
            this.buttonDepositBack.Location = new System.Drawing.Point(674, 410);
            this.buttonDepositBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDepositBack.Name = "buttonDepositBack";
            this.buttonDepositBack.Size = new System.Drawing.Size(157, 75);
            this.buttonDepositBack.TabIndex = 38;
            this.buttonDepositBack.Text = "Back";
            this.buttonDepositBack.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 286);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 29);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter an amount :";
            // 
            // textBoxDepositAmount
            // 
            this.textBoxDepositAmount.Location = new System.Drawing.Point(391, 284);
            this.textBoxDepositAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDepositAmount.Name = "textBoxDepositAmount";
            this.textBoxDepositAmount.Size = new System.Drawing.Size(379, 26);
            this.textBoxDepositAmount.TabIndex = 36;
            // 
            // buttonDepositDelete
            // 
            this.buttonDepositDelete.BackColor = System.Drawing.Color.Black;
            this.buttonDepositDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDepositDelete.Location = new System.Drawing.Point(509, 410);
            this.buttonDepositDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDepositDelete.Name = "buttonDepositDelete";
            this.buttonDepositDelete.Size = new System.Drawing.Size(157, 75);
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
            this.buttonDepositDeposit.Location = new System.Drawing.Point(344, 410);
            this.buttonDepositDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDepositDeposit.Name = "buttonDepositDeposit";
            this.buttonDepositDeposit.Size = new System.Drawing.Size(157, 75);
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
            this.label2.Location = new System.Drawing.Point(135, 349);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "New balance is :";
            // 
            // textBoxDepositNewBalance
            // 
            this.textBoxDepositNewBalance.Location = new System.Drawing.Point(391, 352);
            this.textBoxDepositNewBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDepositNewBalance.Name = "textBoxDepositNewBalance";
            this.textBoxDepositNewBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxDepositNewBalance.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Current balance is :";
            // 
            // textBoxDepositCurrentBalance
            // 
            this.textBoxDepositCurrentBalance.Location = new System.Drawing.Point(391, 222);
            this.textBoxDepositCurrentBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDepositCurrentBalance.Name = "textBoxDepositCurrentBalance";
            this.textBoxDepositCurrentBalance.Size = new System.Drawing.Size(379, 26);
            this.textBoxDepositCurrentBalance.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1068, 741);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1064, 743);
            this.Controls.Add(this.buttonAllTransaction);
            this.Controls.Add(this.label5);
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
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAllTransaction;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}