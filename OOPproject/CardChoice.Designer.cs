namespace OOP_project
{
    partial class CardChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardChoice));
            this.label1 = new System.Windows.Forms.Label();
            this.DebitCardbt = new System.Windows.Forms.Button();
            this.SavingsAccountbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the type of balance you want to do operation on";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DebitCardbt
            // 
            this.DebitCardbt.BackColor = System.Drawing.Color.CadetBlue;
            this.DebitCardbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitCardbt.Location = new System.Drawing.Point(16, 152);
            this.DebitCardbt.Name = "DebitCardbt";
            this.DebitCardbt.Size = new System.Drawing.Size(151, 34);
            this.DebitCardbt.TabIndex = 1;
            this.DebitCardbt.Text = "Debit Card";
            this.DebitCardbt.UseVisualStyleBackColor = false;
            this.DebitCardbt.Click += new System.EventHandler(this.DebitCardbt_Click);
            // 
            // SavingsAccountbt
            // 
            this.SavingsAccountbt.BackColor = System.Drawing.Color.CadetBlue;
            this.SavingsAccountbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavingsAccountbt.Location = new System.Drawing.Point(200, 152);
            this.SavingsAccountbt.Name = "SavingsAccountbt";
            this.SavingsAccountbt.Size = new System.Drawing.Size(151, 34);
            this.SavingsAccountbt.TabIndex = 2;
            this.SavingsAccountbt.Text = "Savings Account";
            this.SavingsAccountbt.UseVisualStyleBackColor = false;
            this.SavingsAccountbt.Click += new System.EventHandler(this.SavingsAccountbt_Click);
            // 
            // CardChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(612, 382);
            this.Controls.Add(this.SavingsAccountbt);
            this.Controls.Add(this.DebitCardbt);
            this.Controls.Add(this.label1);
            this.Name = "CardChoice";
            this.Text = "CardChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DebitCardbt;
        private System.Windows.Forms.Button SavingsAccountbt;
    }
}