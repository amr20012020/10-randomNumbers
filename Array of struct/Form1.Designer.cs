
namespace Array_of_struct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stdID = new System.Windows.Forms.TextBox();
            this.stuName = new System.Windows.Forms.TextBox();
            this.Add_student = new System.Windows.Forms.Button();
            this.display_student_list = new System.Windows.Forms.Button();
            this.Search_by_Name = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.display_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // stdID
            // 
            this.stdID.Location = new System.Drawing.Point(94, 42);
            this.stdID.Name = "stdID";
            this.stdID.Size = new System.Drawing.Size(168, 22);
            this.stdID.TabIndex = 2;
            this.stdID.TextChanged += new System.EventHandler(this.stduID_TextChanged);
            // 
            // stuName
            // 
            this.stuName.Location = new System.Drawing.Point(94, 85);
            this.stuName.Name = "stuName";
            this.stuName.Size = new System.Drawing.Size(168, 22);
            this.stuName.TabIndex = 3;
            // 
            // Add_student
            // 
            this.Add_student.Location = new System.Drawing.Point(301, 259);
            this.Add_student.Name = "Add_student";
            this.Add_student.Size = new System.Drawing.Size(139, 61);
            this.Add_student.TabIndex = 5;
            this.Add_student.Text = "Add Student ";
            this.Add_student.UseVisualStyleBackColor = true;
            this.Add_student.Click += new System.EventHandler(this.button1_Click);
            // 
            // display_student_list
            // 
            this.display_student_list.Location = new System.Drawing.Point(301, 349);
            this.display_student_list.Name = "display_student_list";
            this.display_student_list.Size = new System.Drawing.Size(139, 61);
            this.display_student_list.TabIndex = 6;
            this.display_student_list.Text = "Display Student List";
            this.display_student_list.UseVisualStyleBackColor = true;
            this.display_student_list.Click += new System.EventHandler(this.button2_Click);
            // 
            // Search_by_Name
            // 
            this.Search_by_Name.Location = new System.Drawing.Point(301, 98);
            this.Search_by_Name.Name = "Search_by_Name";
            this.Search_by_Name.Size = new System.Drawing.Size(139, 61);
            this.Search_by_Name.TabIndex = 7;
            this.Search_by_Name.Text = "Search By Name";
            this.Search_by_Name.UseVisualStyleBackColor = true;
            this.Search_by_Name.Click += new System.EventHandler(this.button3_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(301, 181);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(139, 61);
            this.Save_btn.TabIndex = 9;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(301, 20);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(139, 61);
            this.remove_btn.TabIndex = 10;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // display_text
            // 
            this.display_text.Location = new System.Drawing.Point(12, 117);
            this.display_text.Multiline = true;
            this.display_text.Name = "display_text";
            this.display_text.Size = new System.Drawing.Size(283, 307);
            this.display_text.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 436);
            this.Controls.Add(this.display_text);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Search_by_Name);
            this.Controls.Add(this.display_student_list);
            this.Controls.Add(this.Add_student);
            this.Controls.Add(this.stuName);
            this.Controls.Add(this.stdID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stdID;
        private System.Windows.Forms.TextBox stuName;
        private System.Windows.Forms.Button Add_student;
        private System.Windows.Forms.Button display_student_list;
        private System.Windows.Forms.Button Search_by_Name;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.TextBox display_text;
    }
}

