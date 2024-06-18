namespace OOP_project
{
    partial class DeleteClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClient));
            this.DeleteByAccountNumbertx = new System.Windows.Forms.Label();
            this.AccountNumberIn = new System.Windows.Forms.TextBox();
            this.BackToMain = new System.Windows.Forms.Button();
            this.DeleteBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteByAccountNumbertx
            // 
            this.DeleteByAccountNumbertx.AutoSize = true;
            this.DeleteByAccountNumbertx.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteByAccountNumbertx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteByAccountNumbertx.Location = new System.Drawing.Point(32, 102);
            this.DeleteByAccountNumbertx.Name = "DeleteByAccountNumbertx";
            this.DeleteByAccountNumbertx.Size = new System.Drawing.Size(142, 20);
            this.DeleteByAccountNumbertx.TabIndex = 0;
            this.DeleteByAccountNumbertx.Text = "AccountNumber";
            // 
            // AccountNumberIn
            // 
            this.AccountNumberIn.Location = new System.Drawing.Point(229, 102);
            this.AccountNumberIn.Name = "AccountNumberIn";
            this.AccountNumberIn.Size = new System.Drawing.Size(100, 22);
            this.AccountNumberIn.TabIndex = 1;
            this.AccountNumberIn.TextChanged += new System.EventHandler(this.AccountNumberIn_TextChanged);
            // 
            // BackToMain
            // 
            this.BackToMain.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMain.Location = new System.Drawing.Point(602, 12);
            this.BackToMain.Name = "BackToMain";
            this.BackToMain.Size = new System.Drawing.Size(144, 35);
            this.BackToMain.TabIndex = 2;
            this.BackToMain.Text = "MainMenu";
            this.BackToMain.UseVisualStyleBackColor = false;
            this.BackToMain.Click += new System.EventHandler(this.BackToMain_Click);
            // 
            // DeleteBt
            // 
            this.DeleteBt.BackColor = System.Drawing.Color.CadetBlue;
            this.DeleteBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBt.Location = new System.Drawing.Point(131, 192);
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.Size = new System.Drawing.Size(116, 35);
            this.DeleteBt.TabIndex = 3;
            this.DeleteBt.Text = "Delete";
            this.DeleteBt.UseVisualStyleBackColor = false;
            this.DeleteBt.Click += new System.EventHandler(this.DeleteBt_Click);
            // 
            // DeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBt);
            this.Controls.Add(this.BackToMain);
            this.Controls.Add(this.AccountNumberIn);
            this.Controls.Add(this.DeleteByAccountNumbertx);
            this.Name = "DeleteClient";
            this.Text = "DeleteClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteByAccountNumbertx;
        private System.Windows.Forms.Button BackToMain;
        private System.Windows.Forms.Button DeleteBt;
        public System.Windows.Forms.TextBox AccountNumberIn;
    }
}