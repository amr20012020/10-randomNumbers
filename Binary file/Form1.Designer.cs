
namespace Binary_file
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
            this.file = new System.Windows.Forms.Label();
            this.filenametextbox = new System.Windows.Forms.TextBox();
            this.Create_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.errorlabel = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.ID_TEXTBOX = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grade_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.choose_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.search_text = new System.Windows.Forms.TextBox();
            this.choose_file = new System.Windows.Forms.Button();
            this.ID_BTN = new System.Windows.Forms.Button();
            this.Name_btn = new System.Windows.Forms.Button();
            this.grade_btn = new System.Windows.Forms.Button();
            this.show_data = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.AutoSize = true;
            this.file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file.Location = new System.Drawing.Point(24, 20);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(39, 17);
            this.file.TabIndex = 0;
            this.file.Text = "File ";
            // 
            // filenametextbox
            // 
            this.filenametextbox.Location = new System.Drawing.Point(197, 12);
            this.filenametextbox.Name = "filenametextbox";
            this.filenametextbox.Size = new System.Drawing.Size(143, 22);
            this.filenametextbox.TabIndex = 1;
            this.filenametextbox.TextChanged += new System.EventHandler(this.filenametextbox_TextChanged);
            // 
            // Create_btn
            // 
            this.Create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create_btn.Location = new System.Drawing.Point(445, 12);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(108, 27);
            this.Create_btn.TabIndex = 2;
            this.Create_btn.Text = "Create";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(614, 12);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(128, 27);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.Delete_click);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(244, 49);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(63, 17);
            this.errorlabel.TabIndex = 4;
            this.errorlabel.Text = "File Exits";
            this.errorlabel.Visible = false;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(138, 81);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(25, 17);
            this.ID.TabIndex = 5;
            this.ID.Text = "ID:";
            // 
            // ID_TEXTBOX
            // 
            this.ID_TEXTBOX.Location = new System.Drawing.Point(179, 78);
            this.ID_TEXTBOX.Name = "ID_TEXTBOX";
            this.ID_TEXTBOX.Size = new System.Drawing.Size(143, 22);
            this.ID_TEXTBOX.TabIndex = 6;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(358, 78);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 17);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(427, 75);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(143, 22);
            this.Name_textBox.TabIndex = 8;
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(24, 153);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(92, 17);
            this.phone.TabIndex = 9;
            this.phone.Text = "Display File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Add book";
            // 
            // grade_textbox
            // 
            this.grade_textbox.Location = new System.Drawing.Point(677, 72);
            this.grade_textbox.Name = "grade_textbox";
            this.grade_textbox.Size = new System.Drawing.Size(143, 22);
            this.grade_textbox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(611, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Grade:";
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.Location = new System.Drawing.Point(869, 70);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(105, 27);
            this.save_btn.TabIndex = 20;
            this.save_btn.Text = "Save book";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // choose_btn
            // 
            this.choose_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_btn.Location = new System.Drawing.Point(182, 141);
            this.choose_btn.Name = "choose_btn";
            this.choose_btn.Size = new System.Drawing.Size(125, 40);
            this.choose_btn.TabIndex = 21;
            this.choose_btn.Text = "Choose file";
            this.choose_btn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Search";
            // 
            // search_text
            // 
            this.search_text.Location = new System.Drawing.Point(141, 214);
            this.search_text.Name = "search_text";
            this.search_text.Size = new System.Drawing.Size(143, 22);
            this.search_text.TabIndex = 23;
            // 
            // choose_file
            // 
            this.choose_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_file.Location = new System.Drawing.Point(334, 208);
            this.choose_file.Name = "choose_file";
            this.choose_file.Size = new System.Drawing.Size(125, 29);
            this.choose_file.TabIndex = 24;
            this.choose_file.Text = "Choose file";
            this.choose_file.UseVisualStyleBackColor = true;
            // 
            // ID_BTN
            // 
            this.ID_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_BTN.Location = new System.Drawing.Point(27, 272);
            this.ID_BTN.Name = "ID_BTN";
            this.ID_BTN.Size = new System.Drawing.Size(125, 29);
            this.ID_BTN.TabIndex = 25;
            this.ID_BTN.Text = "by ID";
            this.ID_BTN.UseVisualStyleBackColor = true;
            // 
            // Name_btn
            // 
            this.Name_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_btn.Location = new System.Drawing.Point(179, 272);
            this.Name_btn.Name = "Name_btn";
            this.Name_btn.Size = new System.Drawing.Size(125, 29);
            this.Name_btn.TabIndex = 26;
            this.Name_btn.Text = "by NAME";
            this.Name_btn.UseVisualStyleBackColor = true;
            // 
            // grade_btn
            // 
            this.grade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_btn.Location = new System.Drawing.Point(334, 272);
            this.grade_btn.Name = "grade_btn";
            this.grade_btn.Size = new System.Drawing.Size(125, 29);
            this.grade_btn.TabIndex = 27;
            this.grade_btn.Text = "by GRADE";
            this.grade_btn.UseVisualStyleBackColor = true;
            // 
            // show_data
            // 
            this.show_data.Location = new System.Drawing.Point(478, 120);
            this.show_data.Multiline = true;
            this.show_data.Name = "show_data";
            this.show_data.Size = new System.Drawing.Size(496, 181);
            this.show_data.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 326);
            this.Controls.Add(this.show_data);
            this.Controls.Add(this.grade_btn);
            this.Controls.Add(this.Name_btn);
            this.Controls.Add(this.ID_BTN);
            this.Controls.Add(this.choose_file);
            this.Controls.Add(this.search_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.choose_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.grade_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.ID_TEXTBOX);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.filenametextbox);
            this.Controls.Add(this.file);
            this.Name = "Form1";
            this.Text = ".";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file;
        private System.Windows.Forms.TextBox filenametextbox;
        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox ID_TEXTBOX;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grade_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button choose_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox search_text;
        private System.Windows.Forms.Button choose_file;
        private System.Windows.Forms.Button ID_BTN;
        private System.Windows.Forms.Button Name_btn;
        private System.Windows.Forms.Button grade_btn;
        private System.Windows.Forms.TextBox show_data;
    }
}

