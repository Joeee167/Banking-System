namespace OOP_project
{
    partial class UpdateClientScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateClientScreen));
            this.UpdateByAccNumLb = new System.Windows.Forms.Label();
            this.AccountNumberTx = new System.Windows.Forms.TextBox();
            this.UpdateBt = new System.Windows.Forms.Button();
            this.MainMenuBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UpdateByAccNumLb
            // 
            this.UpdateByAccNumLb.AutoSize = true;
            this.UpdateByAccNumLb.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateByAccNumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateByAccNumLb.Location = new System.Drawing.Point(12, 109);
            this.UpdateByAccNumLb.Name = "UpdateByAccNumLb";
            this.UpdateByAccNumLb.Size = new System.Drawing.Size(142, 20);
            this.UpdateByAccNumLb.TabIndex = 0;
            this.UpdateByAccNumLb.Text = "AccountNumber";
            // 
            // AccountNumberTx
            // 
            this.AccountNumberTx.Location = new System.Drawing.Point(192, 109);
            this.AccountNumberTx.Name = "AccountNumberTx";
            this.AccountNumberTx.Size = new System.Drawing.Size(109, 22);
            this.AccountNumberTx.TabIndex = 1;
            this.AccountNumberTx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // UpdateBt
            // 
            this.UpdateBt.BackColor = System.Drawing.Color.CadetBlue;
            this.UpdateBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBt.Location = new System.Drawing.Point(95, 224);
            this.UpdateBt.Name = "UpdateBt";
            this.UpdateBt.Size = new System.Drawing.Size(93, 41);
            this.UpdateBt.TabIndex = 2;
            this.UpdateBt.Text = "Update";
            this.UpdateBt.UseVisualStyleBackColor = false;
            this.UpdateBt.Click += new System.EventHandler(this.UpdateBt_Click);
            // 
            // MainMenuBt
            // 
            this.MainMenuBt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBt.Location = new System.Drawing.Point(593, 12);
            this.MainMenuBt.Name = "MainMenuBt";
            this.MainMenuBt.Size = new System.Drawing.Size(131, 36);
            this.MainMenuBt.TabIndex = 3;
            this.MainMenuBt.Text = "MainMenu";
            this.MainMenuBt.UseVisualStyleBackColor = false;
            this.MainMenuBt.Click += new System.EventHandler(this.MainMenuBt_Click);
            // 
            // UpdateClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenuBt);
            this.Controls.Add(this.UpdateBt);
            this.Controls.Add(this.AccountNumberTx);
            this.Controls.Add(this.UpdateByAccNumLb);
            this.Name = "UpdateClientScreen";
            this.Text = "UpdateClientScreen";
            this.Load += new System.EventHandler(this.UpdateClientScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UpdateByAccNumLb;
        private System.Windows.Forms.TextBox AccountNumberTx;
        private System.Windows.Forms.Button UpdateBt;
        private System.Windows.Forms.Button MainMenuBt;
    }
}