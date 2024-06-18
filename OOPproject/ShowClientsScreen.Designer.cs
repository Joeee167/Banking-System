namespace OOP_project
{
    partial class ShowClientsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowClientsScreen));
            this.ClientsInfotx = new System.Windows.Forms.TextBox();
            this.ClientsLb = new System.Windows.Forms.Label();
            this.MainMenuBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsInfotx
            // 
            this.ClientsInfotx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsInfotx.Location = new System.Drawing.Point(-4, 68);
            this.ClientsInfotx.Multiline = true;
            this.ClientsInfotx.Name = "ClientsInfotx";
            this.ClientsInfotx.ReadOnly = true;
            this.ClientsInfotx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ClientsInfotx.Size = new System.Drawing.Size(801, 382);
            this.ClientsInfotx.TabIndex = 0;
            this.ClientsInfotx.TextChanged += new System.EventHandler(this.ClientsInfotx_TextChanged);
            // 
            // ClientsLb
            // 
            this.ClientsLb.AutoSize = true;
            this.ClientsLb.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsLb.Location = new System.Drawing.Point(36, 21);
            this.ClientsLb.Name = "ClientsLb";
            this.ClientsLb.Size = new System.Drawing.Size(105, 20);
            this.ClientsLb.TabIndex = 1;
            this.ClientsLb.Text = "Clients Info";
            // 
            // MainMenuBt
            // 
            this.MainMenuBt.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenuBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuBt.Location = new System.Drawing.Point(461, 18);
            this.MainMenuBt.Name = "MainMenuBt";
            this.MainMenuBt.Size = new System.Drawing.Size(129, 34);
            this.MainMenuBt.TabIndex = 2;
            this.MainMenuBt.Text = "Main Menu";
            this.MainMenuBt.UseVisualStyleBackColor = false;
            this.MainMenuBt.Click += new System.EventHandler(this.MainMenuBt_Click);
            // 
            // ShowClientsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainMenuBt);
            this.Controls.Add(this.ClientsLb);
            this.Controls.Add(this.ClientsInfotx);
            this.Name = "ShowClientsScreen";
            this.Text = "ShowClientsScreen";
            this.Load += new System.EventHandler(this.ShowClientsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ClientsLb;
        private System.Windows.Forms.Button MainMenuBt;
        public System.Windows.Forms.TextBox ClientsInfotx;
    }
}