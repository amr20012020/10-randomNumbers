using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Binary_file
{
    public partial class Form1 : Form
    {
        public string filename = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Create_click(object sender, EventArgs e)
        {
            filename = "E:\\test\\" + filenametextbox.Text + ".txt";
            if(!File.Exists(filename))
            {
                File.Create(filename).Close();
                MessageBox.Show("File is Created Successfully", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                errorlabel.Visible = true;
            }
        }

        private void Delete_click(object sender, EventArgs e)
        {
            filename = "E:\\test\\" + filenametextbox.Text + ".txt";
            File.Delete(filename);
            MessageBox.Show("File is Deleted");
            filenametextbox.Clear();
            errorlabel.Visible = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(filename, FileMode.Open, FileAccess.Write));
            int length = (int)bw.BaseStream.Length;
            if(length != 0)
            {
                bw.BaseStream.Seek(length, SeekOrigin.Begin);
            }
            bw.Write(int.Parse(ID_TEXTBOX.Text));

            Name_textBox.Text = Name_textBox.Text.PadRight(9);
            bw.Write(Name_textBox.Text.Substring(0, 9));

            phone_textBox.Text = phone_textBox.Text.PadRight(11);
            bw.Write(phone_textBox.Text.Substring(0, 11));

            bw.Write(int.Parse(year_textBox1.Text));

            bw.Write(gender_textBox2.Text.Substring(0, 1));

            ID_TEXTBOX.Text = Name_textBox.Text = phone_textBox.Text = year_textBox1.Text = gender_textBox2.Text = "";

            MessageBox.Show("Data saved successuflly");
            bw.Close();


        }

        private void filenametextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
