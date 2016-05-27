namespace lab17
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboShip = new System.Windows.Forms.ComboBox();
            this.txtDisplayShipping = new System.Windows.Forms.TextBox();
            this.lblDisplayShipping = new System.Windows.Forms.Label();
            this.lblChooseShipping = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(495, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboShip
            // 
            this.comboShip.FormattingEnabled = true;
            this.comboShip.Items.AddRange(new object[] {
            "Standard",
            "Express",
            "Same Day"});
            this.comboShip.Location = new System.Drawing.Point(155, 143);
            this.comboShip.Name = "comboShip";
            this.comboShip.Size = new System.Drawing.Size(121, 24);
            this.comboShip.TabIndex = 1;
            this.comboShip.SelectedIndexChanged += new System.EventHandler(this.comboShip_SelectedIndexChanged);
            // 
            // txtDisplayShipping
            // 
            this.txtDisplayShipping.Location = new System.Drawing.Point(155, 259);
            this.txtDisplayShipping.Name = "txtDisplayShipping";
            this.txtDisplayShipping.Size = new System.Drawing.Size(100, 22);
            this.txtDisplayShipping.TabIndex = 2;
            // 
            // lblDisplayShipping
            // 
            this.lblDisplayShipping.AutoSize = true;
            this.lblDisplayShipping.Location = new System.Drawing.Point(165, 239);
            this.lblDisplayShipping.Name = "lblDisplayShipping";
            this.lblDisplayShipping.Size = new System.Drawing.Size(81, 17);
            this.lblDisplayShipping.TabIndex = 3;
            this.lblDisplayShipping.Text = "You Chose:";
            // 
            // lblChooseShipping
            // 
            this.lblChooseShipping.AutoSize = true;
            this.lblChooseShipping.Location = new System.Drawing.Point(131, 123);
            this.lblChooseShipping.Name = "lblChooseShipping";
            this.lblChooseShipping.Size = new System.Drawing.Size(170, 17);
            this.lblChooseShipping.TabIndex = 4;
            this.lblChooseShipping.Text = "Choose Shipping Method:";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 407);
            this.Controls.Add(this.lblChooseShipping);
            this.Controls.Add(this.lblDisplayShipping);
            this.Controls.Add(this.txtDisplayShipping);
            this.Controls.Add(this.comboShip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Shipping";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox comboShip;
        private System.Windows.Forms.TextBox txtDisplayShipping;
        private System.Windows.Forms.Label lblDisplayShipping;
        private System.Windows.Forms.Label lblChooseShipping;
    }
}

