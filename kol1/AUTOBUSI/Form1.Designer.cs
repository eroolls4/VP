﻿namespace AUTOBUSI
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
            this.lbBusses = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.tbAvgPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbBusses
            // 
            this.lbBusses.FormattingEnabled = true;
            this.lbBusses.ItemHeight = 16;
            this.lbBusses.Location = new System.Drawing.Point(24, 30);
            this.lbBusses.Name = "lbBusses";
            this.lbBusses.Size = new System.Drawing.Size(273, 276);
            this.lbBusses.TabIndex = 0;
            this.lbBusses.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.ItemHeight = 16;
            this.lbLines.Location = new System.Drawing.Point(438, 30);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(273, 276);
            this.lbLines.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD NEW BUSS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleAddNewBuss);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(269, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "REMOVE BUSS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.handleRemoveBuss);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(269, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "ADD NEW LINE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.handleAddLine);
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Enabled = false;
            this.tbMostExpensive.Location = new System.Drawing.Point(438, 369);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.Size = new System.Drawing.Size(273, 22);
            this.tbMostExpensive.TabIndex = 5;
            // 
            // tbAvgPrice
            // 
            this.tbAvgPrice.Enabled = false;
            this.tbAvgPrice.Location = new System.Drawing.Point(438, 441);
            this.tbAvgPrice.Name = "tbAvgPrice";
            this.tbAvgPrice.Size = new System.Drawing.Size(273, 22);
            this.tbAvgPrice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "MOST EXPENSIVE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "AVG PRICE FOR LINES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "AUTOBUSES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "LINES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 489);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAvgPrice);
            this.Controls.Add(this.tbMostExpensive);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBusses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBusses;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.TextBox tbAvgPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

