
namespace Array_of_student
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
            this.ID_TEXT = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.display_text = new System.Windows.Forms.TextBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.Search_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.display_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // ID_TEXT
            // 
            this.ID_TEXT.Location = new System.Drawing.Point(77, 22);
            this.ID_TEXT.Name = "ID_TEXT";
            this.ID_TEXT.Size = new System.Drawing.Size(212, 22);
            this.ID_TEXT.TabIndex = 2;
            this.ID_TEXT.TextChanged += new System.EventHandler(this.ID_TEXT_TextChanged);
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(77, 56);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(212, 22);
            this.Name_text.TabIndex = 3;
            // 
            // display_text
            // 
            this.display_text.Location = new System.Drawing.Point(12, 93);
            this.display_text.Multiline = true;
            this.display_text.Name = "display_text";
            this.display_text.Size = new System.Drawing.Size(277, 297);
            this.display_text.TabIndex = 4;
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(295, 20);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(147, 56);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(295, 93);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(147, 56);
            this.Search_btn.TabIndex = 6;
            this.Search_btn.Text = "Search by Name";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(296, 171);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(147, 56);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(296, 256);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(147, 56);
            this.Add_btn.TabIndex = 8;
            this.Add_btn.Text = "Add Student";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // display_btn
            // 
            this.display_btn.Location = new System.Drawing.Point(296, 334);
            this.display_btn.Name = "display_btn";
            this.display_btn.Size = new System.Drawing.Size(147, 56);
            this.display_btn.TabIndex = 9;
            this.display_btn.Text = "Display Students";
            this.display_btn.UseVisualStyleBackColor = true;
            this.display_btn.Click += new System.EventHandler(this.display_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 410);
            this.Controls.Add(this.display_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.display_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.ID_TEXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID_TEXT;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.TextBox display_text;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button display_btn;
    }
}

