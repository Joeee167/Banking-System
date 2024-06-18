using System.Windows.Forms;

namespace OOP_project
{
    partial class UpdateInfo : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateInfo));
            this.AccountNumberInput = new System.Windows.Forms.Label();
            this.PinInput = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.Label();
            this.PhoneNumberInput = new System.Windows.Forms.Label();
            this.AccountBalanceInput = new System.Windows.Forms.Label();
            this.AccountNumbertx = new System.Windows.Forms.TextBox();
            this.AccountBalancetx = new System.Windows.Forms.TextBox();
            this.PhoneNumbrtx = new System.Windows.Forms.TextBox();
            this.Nametx = new System.Windows.Forms.TextBox();
            this.Pintx = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Savingtx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AccountNumberInput
            // 
            this.AccountNumberInput.AutoSize = true;
            this.AccountNumberInput.BackColor = System.Drawing.Color.SteelBlue;
            this.AccountNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNumberInput.Location = new System.Drawing.Point(12, 23);
            this.AccountNumberInput.Name = "AccountNumberInput";
            this.AccountNumberInput.Size = new System.Drawing.Size(142, 20);
            this.AccountNumberInput.TabIndex = 0;
            this.AccountNumberInput.Text = "AccountNumber";
            // 
            // PinInput
            // 
            this.PinInput.AutoSize = true;
            this.PinInput.BackColor = System.Drawing.Color.SteelBlue;
            this.PinInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinInput.Location = new System.Drawing.Point(14, 78);
            this.PinInput.Name = "PinInput";
            this.PinInput.Size = new System.Drawing.Size(39, 20);
            this.PinInput.TabIndex = 1;
            this.PinInput.Text = "PIN";
            this.PinInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameInput
            // 
            this.NameInput.AutoSize = true;
            this.NameInput.BackColor = System.Drawing.Color.SteelBlue;
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(12, 131);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(57, 20);
            this.NameInput.TabIndex = 2;
            this.NameInput.Text = "Name";
            this.NameInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumberInput
            // 
            this.PhoneNumberInput.AutoSize = true;
            this.PhoneNumberInput.BackColor = System.Drawing.Color.SteelBlue;
            this.PhoneNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberInput.Location = new System.Drawing.Point(12, 174);
            this.PhoneNumberInput.Name = "PhoneNumberInput";
            this.PhoneNumberInput.Size = new System.Drawing.Size(126, 20);
            this.PhoneNumberInput.TabIndex = 3;
            this.PhoneNumberInput.Text = "PhoneNumber";
            this.PhoneNumberInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountBalanceInput
            // 
            this.AccountBalanceInput.AutoSize = true;
            this.AccountBalanceInput.BackColor = System.Drawing.Color.SteelBlue;
            this.AccountBalanceInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountBalanceInput.Location = new System.Drawing.Point(12, 226);
            this.AccountBalanceInput.Name = "AccountBalanceInput";
            this.AccountBalanceInput.Size = new System.Drawing.Size(122, 20);
            this.AccountBalanceInput.TabIndex = 4;
            this.AccountBalanceInput.Text = "DebitBalance";
            // 
            // AccountNumbertx
            // 
            this.AccountNumbertx.Location = new System.Drawing.Point(193, 23);
            this.AccountNumbertx.Name = "AccountNumbertx";
            this.AccountNumbertx.ReadOnly = true;
            this.AccountNumbertx.Size = new System.Drawing.Size(125, 22);
            this.AccountNumbertx.TabIndex = 5;
            this.AccountNumbertx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AccountBalancetx
            // 
            this.AccountBalancetx.Location = new System.Drawing.Point(193, 226);
            this.AccountBalancetx.Name = "AccountBalancetx";
            this.AccountBalancetx.Size = new System.Drawing.Size(118, 22);
            this.AccountBalancetx.TabIndex = 6;
            this.AccountBalancetx.TextChanged += new System.EventHandler(this.AccountBalancetx_TextChanged);
            // 
            // PhoneNumbrtx
            // 
            this.PhoneNumbrtx.Location = new System.Drawing.Point(193, 174);
            this.PhoneNumbrtx.Name = "PhoneNumbrtx";
            this.PhoneNumbrtx.Size = new System.Drawing.Size(118, 22);
            this.PhoneNumbrtx.TabIndex = 7;
            this.PhoneNumbrtx.TextChanged += new System.EventHandler(this.PhoneNumbrtx_TextChanged);
            // 
            // Nametx
            // 
            this.Nametx.Location = new System.Drawing.Point(193, 131);
            this.Nametx.Name = "Nametx";
            this.Nametx.Size = new System.Drawing.Size(118, 22);
            this.Nametx.TabIndex = 8;
            this.Nametx.TextChanged += new System.EventHandler(this.Nametx_TextChanged);
            // 
            // Pintx
            // 
            this.Pintx.Location = new System.Drawing.Point(193, 78);
            this.Pintx.Name = "Pintx";
            this.Pintx.Size = new System.Drawing.Size(120, 22);
            this.Pintx.TabIndex = 9;
            this.Pintx.TextChanged += new System.EventHandler(this.Pintx_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(148, 322);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(92, 40);
            this.Submit.TabIndex = 10;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(472, 16);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(125, 37);
            this.MainMenu.TabIndex = 11;
            this.MainMenu.Text = "MainMenu";
            this.MainMenu.UseVisualStyleBackColor = false;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "SavingsBalance";
            // 
            // Savingtx
            // 
            this.Savingtx.Location = new System.Drawing.Point(193, 274);
            this.Savingtx.Name = "Savingtx";
            this.Savingtx.Size = new System.Drawing.Size(118, 22);
            this.Savingtx.TabIndex = 13;
            this.Savingtx.TextChanged += new System.EventHandler(this.Savingtx_TextChanged);
            // 
            // UpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(627, 374);
            this.Controls.Add(this.Savingtx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Pintx);
            this.Controls.Add(this.Nametx);
            this.Controls.Add(this.PhoneNumbrtx);
            this.Controls.Add(this.AccountBalancetx);
            this.Controls.Add(this.AccountNumbertx);
            this.Controls.Add(this.AccountBalanceInput);
            this.Controls.Add(this.PhoneNumberInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.PinInput);
            this.Controls.Add(this.AccountNumberInput);
            this.Name = "UpdateInfo";
            this.Text = "UpdateClientInfo";
            this.Load += new System.EventHandler(this.UpdateInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountNumberInput;
        private System.Windows.Forms.Label PinInput;
        private System.Windows.Forms.Label NameInput;
        private System.Windows.Forms.Label PhoneNumberInput;
        private System.Windows.Forms.Label AccountBalanceInput;
        private System.Windows.Forms.TextBox AccountNumbertx;
        private System.Windows.Forms.TextBox AccountBalancetx;
        private System.Windows.Forms.TextBox PhoneNumbrtx;
        private System.Windows.Forms.TextBox Nametx;
        private System.Windows.Forms.TextBox Pintx;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button MainMenu;
        private Label label1;
        private TextBox Savingtx;
    }
}