namespace OOP_project
{
    partial class TransactionsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsMenu));
            this.WithdrawButton = new System.Windows.Forms.Button();
            this.DepositButton = new System.Windows.Forms.Button();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.AddAmountLb = new System.Windows.Forms.Label();
            this.AmountTx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WithdrawButton
            // 
            this.WithdrawButton.BackColor = System.Drawing.Color.CadetBlue;
            this.WithdrawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawButton.Location = new System.Drawing.Point(24, 185);
            this.WithdrawButton.Name = "WithdrawButton";
            this.WithdrawButton.Size = new System.Drawing.Size(130, 30);
            this.WithdrawButton.TabIndex = 0;
            this.WithdrawButton.Text = "Withdarw";
            this.WithdrawButton.UseVisualStyleBackColor = false;
            this.WithdrawButton.Click += new System.EventHandler(this.WithdrawButton_Click);
            // 
            // DepositButton
            // 
            this.DepositButton.BackColor = System.Drawing.Color.CadetBlue;
            this.DepositButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositButton.Location = new System.Drawing.Point(188, 185);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(130, 30);
            this.DepositButton.TabIndex = 1;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = false;
            this.DepositButton.Click += new System.EventHandler(this.DepositButton_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToMainMenuButton.Location = new System.Drawing.Point(457, 12);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(125, 37);
            this.BackToMainMenuButton.TabIndex = 2;
            this.BackToMainMenuButton.Text = "MainMenu";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // AddAmountLb
            // 
            this.AddAmountLb.AutoSize = true;
            this.AddAmountLb.BackColor = System.Drawing.Color.SteelBlue;
            this.AddAmountLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAmountLb.Location = new System.Drawing.Point(21, 110);
            this.AddAmountLb.Name = "AddAmountLb";
            this.AddAmountLb.Size = new System.Drawing.Size(110, 20);
            this.AddAmountLb.TabIndex = 3;
            this.AddAmountLb.Text = "Add Amount";
            // 
            // AmountTx
            // 
            this.AmountTx.Location = new System.Drawing.Point(188, 110);
            this.AmountTx.Name = "AmountTx";
            this.AmountTx.Size = new System.Drawing.Size(100, 22);
            this.AmountTx.TabIndex = 4;
            this.AmountTx.TextChanged += new System.EventHandler(this.AmountTx_TextChanged);
            // 
            // TransactionsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(624, 374);
            this.Controls.Add(this.AmountTx);
            this.Controls.Add(this.AddAmountLb);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.DepositButton);
            this.Controls.Add(this.WithdrawButton);
            this.Name = "TransactionsMenu";
            this.Text = "DebitCardMenu";
            this.Load += new System.EventHandler(this.TransactionsMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WithdrawButton;
        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.Label AddAmountLb;
        private System.Windows.Forms.TextBox AmountTx;
    }
}