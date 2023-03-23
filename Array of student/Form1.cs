using System;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_of_student
{
    public partial class Form1 : Form
    {
        public bool less = false;
        public int current = 0;
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

        private void ID_TEXT_TextChanged(object sender, EventArgs e)
        {

        }

        //private void Add_btn_Click(object sender, EventArgs e)
        //{
        //    student s;
        //    s.id = Int32.Parse(ID_TEXT.Text);
        //    s.name = Name_text.Text;
        //    studlist.Add(s);
        //    ID_TEXT.Clear();
        //    Name_text.Clear();
        //    display_btn_Click(sender, e);
        //}

        private void Add_btn_Click(object sender, EventArgs e)
        {
            int current = 0;
            bool road = false;
            student s;
            s.id = Int32.Parse(ID_TEXT.Text);
            s.name = Name_text.Text;

            foreach(student x in studlist)
            {
                if(s.id<x.id)
                {
                    current = studlist.LastIndexOf(x);
                    road = true;
                    break;
                }
            }
            if(road)
            {
                studlist.Insert(current, s);
                ID_TEXT.Clear();
                Name_text.Clear();
                road = false;
            }
            else
            {
                studlist.Add(s);
                ID_TEXT.Clear();
                Name_text.Clear();
                road = false;
            }
            display_btn_Click(sender, e);
        }

        private void display_btn_Click(object sender, EventArgs e)
        {
            display_text.Text = "";
            foreach (student item in studlist)
            {
                display_text.Text += "ID = " + item.id + "\t Name = " + item.name + Environment.NewLine;
            }
        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("E:\\student.txt");
            foreach (student item in studlist)
            {
                sw.WriteLine("ID = " + item.id + "\t Name = " + item.name);
            }
            sw.Close();
            MessageBox.Show("Done", "Save", MessageBoxButtons.OK);
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if(Name_text.Text == "")
            {
                MessageBox.Show("Write Student Name", "Error");
            }
            else
            {
                foreach(student s in studlist)
                {
                    if(s.name == Name_text.Text)
                    {
                        MessageBox.Show("Found at index " + studlist.IndexOf(s) + "\t ID = " + s.id, "found");
                        flag = true;
                    }
                }
            }
            if(flag == false && Name_text.Text != "")
            {
                MessageBox.Show("student not found", "not found");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            foreach(student s in studlist)
            {
                if(s.name == Name_text.Text)
                {
                    studlist.RemoveAt(studlist.IndexOf(s));
                    break;
                }
            }
            display_btn_Click(sender, e);
        }
    }
}
