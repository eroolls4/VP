namespace DrawingShapes
{
    partial class Form1
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
            this.sHAPETYPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIRCLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQUAREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHAPETYPEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sHAPETYPEToolStripMenuItem
            // 
            this.sHAPETYPEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cIRCLEToolStripMenuItem,
            this.sQUAREToolStripMenuItem});
            this.sHAPETYPEToolStripMenuItem.Name = "sHAPETYPEToolStripMenuItem";
            this.sHAPETYPEToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.sHAPETYPEToolStripMenuItem.Text = "SHAPE TYPE";
            // 
            // cIRCLEToolStripMenuItem
            // 
            this.cIRCLEToolStripMenuItem.Checked = true;
            this.cIRCLEToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cIRCLEToolStripMenuItem.Name = "cIRCLEToolStripMenuItem";
            this.cIRCLEToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cIRCLEToolStripMenuItem.Text = "CIRCLE";
            this.cIRCLEToolStripMenuItem.Click += new System.EventHandler(this.cIRCLEToolStripMenuItem_Click);
            // 
            // sQUAREToolStripMenuItem
            // 
            this.sQUAREToolStripMenuItem.Name = "sQUAREToolStripMenuItem";
            this.sQUAREToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sQUAREToolStripMenuItem.Text = "SQUARE";
            this.sQUAREToolStripMenuItem.Click += new System.EventHandler(this.sQUAREToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 521);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.handlePaint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.handleMouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sHAPETYPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIRCLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQUAREToolStripMenuItem;
    }
}

