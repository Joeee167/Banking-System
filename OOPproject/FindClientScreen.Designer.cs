namespace OOP_project
{
    partial class FindClientScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindClientScreen));
            this.FindByAccountNumbertx = new System.Windows.Forms.TextBox();
            this.FindByAccountNumberLb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindByAccountNumbertx
            // 
            this.FindByAccountNumbertx.Location = new System.Drawing.Point(197, 119);
            this.FindByAccountNumbertx.Name = "FindByAccountNumbertx";
            this.FindByAccountNumbertx.Size = new System.Drawing.Size(100, 22);
            this.FindByAccountNumbertx.TabIndex = 0;
            this.FindByAccountNumbertx.TextChanged += new System.EventHandler(this.FindByAccountNumbertx_TextChanged);
            // 
            // FindByAccountNumberLb
            // 
            this.FindByAccountNumberLb.AutoSize = true;
            this.FindByAccountNumberLb.BackColor = System.Drawing.Color.SteelBlue;
            this.FindByAccountNumberLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindByAccountNumberLb.Location = new System.Drawing.Point(22, 119);
            this.FindByAccountNumberLb.Name = "FindByAccountNumberLb";
            this.FindByAccountNumberLb.Size = new System.Drawing.Size(142, 20);
            this.FindByAccountNumberLb.TabIndex = 1;
            this.FindByAccountNumberLb.Text = "AccountNumber";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(137, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenu.Location = new System.Drawing.Point(589, 12);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(144, 35);
            this.BackToMainMenu.TabIndex = 3;
            this.BackToMainMenu.Text = "Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = false;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // FindClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FindByAccountNumberLb);
            this.Controls.Add(this.FindByAccountNumbertx);
            this.Name = "FindClientScreen";
            this.Text = "FindClientScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FindByAccountNumberLb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToMainMenu;
        public System.Windows.Forms.TextBox FindByAccountNumbertx;
    }
}