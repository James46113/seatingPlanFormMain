namespace seatingPlanFormMain
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
            this.importStudents = new System.Windows.Forms.Button();
            this.generatePlan = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.clearStudents = new System.Windows.Forms.Button();
            this.addBox = new System.Windows.Forms.TextBox();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.shuffledBox = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // importStudents
            // 
            this.importStudents.Location = new System.Drawing.Point(12, 12);
            this.importStudents.Name = "importStudents";
            this.importStudents.Size = new System.Drawing.Size(75, 23);
            this.importStudents.TabIndex = 0;
            this.importStudents.Text = "importStudents";
            this.importStudents.UseVisualStyleBackColor = true;
            this.importStudents.Click += new System.EventHandler(this.importStudents_Click);
            // 
            // generatePlan
            // 
            this.generatePlan.Location = new System.Drawing.Point(12, 41);
            this.generatePlan.Name = "generatePlan";
            this.generatePlan.Size = new System.Drawing.Size(75, 23);
            this.generatePlan.TabIndex = 1;
            this.generatePlan.Text = "generatePlan";
            this.generatePlan.UseVisualStyleBackColor = true;
            this.generatePlan.Click += new System.EventHandler(this.generatePlan_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(12, 70);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(75, 23);
            this.addStudent.TabIndex = 2;
            this.addStudent.Text = "addStudent";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // clearStudents
            // 
            this.clearStudents.Location = new System.Drawing.Point(12, 99);
            this.clearStudents.Name = "clearStudents";
            this.clearStudents.Size = new System.Drawing.Size(75, 23);
            this.clearStudents.TabIndex = 3;
            this.clearStudents.Text = "clearStudents";
            this.clearStudents.UseVisualStyleBackColor = true;
            this.clearStudents.Click += new System.EventHandler(this.clearStudents_Click);
            // 
            // addBox
            // 
            this.addBox.Location = new System.Drawing.Point(12, 128);
            this.addBox.Name = "addBox";
            this.addBox.Size = new System.Drawing.Size(100, 20);
            this.addBox.TabIndex = 4;
            this.addBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addBox_KeyDown);
            // 
            // studentsBox
            // 
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.Location = new System.Drawing.Point(12, 154);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(120, 95);
            this.studentsBox.TabIndex = 5;
            this.studentsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDoubleClick);
            // 
            // shuffledBox
            // 
            this.shuffledBox.FormattingEnabled = true;
            this.shuffledBox.Location = new System.Drawing.Point(12, 255);
            this.shuffledBox.Name = "shuffledBox";
            this.shuffledBox.Size = new System.Drawing.Size(120, 95);
            this.shuffledBox.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shuffledBox);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.addBox);
            this.Controls.Add(this.clearStudents);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.generatePlan);
            this.Controls.Add(this.importStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importStudents;
        private System.Windows.Forms.Button generatePlan;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button clearStudents;
        private System.Windows.Forms.TextBox addBox;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.ListBox shuffledBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

