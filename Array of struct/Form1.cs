using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_of_struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct student
        {
            public int id;
            public string name;
        };

        public List<student> studlist = new List<student>();


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s;
            s.id = Int32.Parse(stdID.Text);
            s.name = stuName.Text;
            studlist.Add(s);
            stdID.Clear();
            stuName.Clear();
            button2_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display_text.Text = "";
            foreach (student item in studlist)
            {
                display_text.Text += " ID = " + item.id + "\t Name=" + item.name + Environment.NewLine;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (stuName.Text == "")
            {
                MessageBox.Show("Write The Name Of The Student", "Error");
            }
            else
            {
                foreach (student s in studlist)
                {
                    if (stuName.Text == s.name)
                    {
                        MessageBox.Show(("found at Index " + studlist.IndexOf(s) + "\t ID = ")
                            + s.id , "Found");
                        flag = true;
                    }
                }
            }
            if (flag == false && stuName.Text != "")
                MessageBox.Show("Student not found","Not Found");
        }

      

        private void Save_btn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("E:\\student.txt");
            foreach(student item in studlist)
            {
                sw.WriteLine("ID = " + item.id + "\t Name = " + item.name);
            }
            sw.Close();
            MessageBox.Show("Done", "Save", MessageBoxButtons.OK);
        }

        private void stduID_TextChanged(object sender, EventArgs e)
        {

        }


        private void remove_btn_Click(object sender, EventArgs e)
        {
            foreach (student s in studlist)
            {
                if (s.name == stuName.Text)
                {
                    studlist.RemoveAt(studlist.IndexOf(s));
                    break;
                }
            }
       
        }
    }
}
