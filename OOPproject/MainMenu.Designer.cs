namespace OOP_project
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ShowClients = new System.Windows.Forms.Button();
            this.AddClients = new System.Windows.Forms.Button();
            this.UpdateClients = new System.Windows.Forms.Button();
            this.FindClient = new System.Windows.Forms.Button();
            this.DeleteClient = new System.Windows.Forms.Button();
            this.Transactions = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowClients
            // 
            this.ShowClients.BackColor = System.Drawing.Color.SteelBlue;
            this.ShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowClients.Location = new System.Drawing.Point(12, 58);
            this.ShowClients.Name = "ShowClients";
            this.ShowClients.Size = new System.Drawing.Size(150, 40);
            this.ShowClients.TabIndex = 0;
            this.ShowClients.Text = "Show Clients";
            this.ShowClients.UseVisualStyleBackColor = false;
            this.ShowClients.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddClients
            // 
            this.AddClients.BackColor = System.Drawing.Color.SteelBlue;
            this.AddClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClients.Location = new System.Drawing.Point(12, 146);
            this.AddClients.Name = "AddClients";
            this.AddClients.Size = new System.Drawing.Size(150, 40);
            this.AddClients.TabIndex = 1;
            this.AddClients.Text = "Add Client";
            this.AddClients.UseVisualStyleBackColor = false;
            this.AddClients.Click += new System.EventHandler(this.AddClients_Click);
            // 
            // UpdateClients
            // 
            this.UpdateClients.BackColor = System.Drawing.Color.SteelBlue;
            this.UpdateClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateClients.Location = new System.Drawing.Point(199, 146);
            this.UpdateClients.Name = "UpdateClients";
            this.UpdateClients.Size = new System.Drawing.Size(166, 40);
            this.UpdateClients.TabIndex = 2;
            this.UpdateClients.Text = "Update Client";
            this.UpdateClients.UseVisualStyleBackColor = false;
            this.UpdateClients.Click += new System.EventHandler(this.UpdateClients_Click);
            // 
            // FindClient
            // 
            this.FindClient.BackColor = System.Drawing.Color.SteelBlue;
            this.FindClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindClient.Location = new System.Drawing.Point(12, 251);
            this.FindClient.Name = "FindClient";
            this.FindClient.Size = new System.Drawing.Size(150, 40);
            this.FindClient.TabIndex = 3;
            this.FindClient.Text = "Find Client";
            this.FindClient.UseVisualStyleBackColor = false;
            this.FindClient.Click += new System.EventHandler(this.FindClient_Click);
            // 
            // DeleteClient
            // 
            this.DeleteClient.BackColor = System.Drawing.Color.SteelBlue;
            this.DeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClient.Location = new System.Drawing.Point(199, 58);
            this.DeleteClient.Name = "DeleteClient";
            this.DeleteClient.Size = new System.Drawing.Size(166, 40);
            this.DeleteClient.TabIndex = 4;
            this.DeleteClient.Text = "Delete Client";
            this.DeleteClient.UseVisualStyleBackColor = false;
            this.DeleteClient.Click += new System.EventHandler(this.DeleteClient_Click);
            // 
            // Transactions
            // 
            this.Transactions.BackColor = System.Drawing.Color.SteelBlue;
            this.Transactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactions.Location = new System.Drawing.Point(199, 251);
            this.Transactions.Name = "Transactions";
            this.Transactions.Size = new System.Drawing.Size(166, 40);
            this.Transactions.TabIndex = 5;
            this.Transactions.Text = "Transactions";
            this.Transactions.UseVisualStyleBackColor = false;
            this.Transactions.Click += new System.EventHandler(this.Transactions_Click);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LogOut.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(588, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(160, 37);
            this.LogOut.TabIndex = 6;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Transactions);
            this.Controls.Add(this.DeleteClient);
            this.Controls.Add(this.FindClient);
            this.Controls.Add(this.UpdateClients);
            this.Controls.Add(this.AddClients);
            this.Controls.Add(this.ShowClients);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowClients;
        private System.Windows.Forms.Button AddClients;
        private System.Windows.Forms.Button UpdateClients;
        private System.Windows.Forms.Button FindClient;
        private System.Windows.Forms.Button DeleteClient;
        private System.Windows.Forms.Button Transactions;
        private System.Windows.Forms.Button LogOut;
    }
}