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

namespace seatingPlanFormMain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            studentsBox.Items.Clear();
            students.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            using (StreamReader reader = new StreamReader(files[0]))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    studentsBox.Items.Add(line);
                    students.Add(line);
                }
            }
        }



        List<string> students = new List<string>();
        Random rnd = new Random();

        void getStudents()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                getStudentsFile();
            }
        }
        void getStudentsFile()
        {
            try
            {
                using (StreamReader sReader = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while (true)
                    {
                        line = sReader.ReadLine();
                        if (line != null)
                        {
                            studentsBox.Items.Add(line);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void shuffleStudents()
        {
            students.Clear();
            foreach (string item in studentsBox.Items)
            {
                students.Add(item);
            }

            for (int i = 0; i < students.Count; i++)
            {
                int rnum = rnd.Next(0, students.Count);
                string temp = students[i];
                students[i] = students[rnum];
                students[rnum] = temp;
            }
            shuffledBox.Items.Clear();
            foreach (string item in students)
            {
                shuffledBox.Items.Add((students.IndexOf(item) + 1) + " - " + item);
                //Console.WriteLine(item);
            }
        }

        private void addBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void generatePlan_Click(object sender, EventArgs e)
        {
            shuffleStudents();
        }

        private void importStudents_Click(object sender, EventArgs e)
        {
            getStudents();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            studentsBox.Items.Add(addBox.Text);
            addBox.Text = "";
        }

        private void clearStudents_Click(object sender, EventArgs e)
        {
            students.Clear();
            shuffledBox.Items.Clear();
            studentsBox.Items.Clear();
        }

        private void addBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                studentsBox.Items.Add(addBox.Text);
                addBox.Text = "";
            }
        }

        private void studentsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = studentsBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                studentsBox.Items.RemoveAt(index);
            }
        }
    }
}
