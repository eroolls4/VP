namespace OnlinePayments2024
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.nudUplata = new System.Windows.Forms.NumericUpDown();
            this.btnUplati = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.lbSelectedStudentDetails = new System.Windows.Forms.Label();
            this.tbMaxStudent = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudUplata)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(12, 17);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(298, 388);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nudUplata
            // 
            this.nudUplata.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudUplata.Location = new System.Drawing.Point(362, 17);
            this.nudUplata.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUplata.Name = "nudUplata";
            this.nudUplata.Size = new System.Drawing.Size(206, 22);
            this.nudUplata.TabIndex = 1;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(362, 58);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(205, 25);
            this.btnUplati.TabIndex = 2;
            this.btnUplati.Text = "UPLATI";
            this.btnUplati.UseVisualStyleBackColor = true;
            this.btnUplati.Click += new System.EventHandler(this.handleAddPayment);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(16, 444);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(293, 34);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "ADD STUDENT";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.handleAdd);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(18, 497);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(290, 31);
            this.btnRemoveStudent.TabIndex = 4;
            this.btnRemoveStudent.Text = "REMOVE STUDENT";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbSelectedStudentDetails
            // 
            this.lbSelectedStudentDetails.AutoSize = true;
            this.lbSelectedStudentDetails.Location = new System.Drawing.Point(369, 122);
            this.lbSelectedStudentDetails.Name = "lbSelectedStudentDetails";
            this.lbSelectedStudentDetails.Size = new System.Drawing.Size(44, 16);
            this.lbSelectedStudentDetails.TabIndex = 5;
            this.lbSelectedStudentDetails.Text = "label1";
          
            // 
            // tbMaxStudent
            // 
            this.tbMaxStudent.Location = new System.Drawing.Point(367, 475);
            this.tbMaxStudent.Name = "tbMaxStudent";
            this.tbMaxStudent.Size = new System.Drawing.Size(279, 22);
            this.tbMaxStudent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 545);
            this.Controls.Add(this.tbMaxStudent);
            this.Controls.Add(this.lbSelectedStudentDetails);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnUplati);
            this.Controls.Add(this.nudUplata);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudUplata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.NumericUpDown nudUplata;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Label lbSelectedStudentDetails;
        private System.Windows.Forms.TextBox tbMaxStudent;
    }
}

