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

namespace Train_Ticket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBox.Items.ToString() = string.Empty;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveWindow = new SaveFileDialog();
            SaveWindow.Filter = "txt files (.txt)|.txt|All files(.)|*.*";
            SaveWindow.FilterIndex = 1;
            SaveWindow.RestoreDirectory = true;
            if (SaveWindow.ShowDialog() != DialogResult.OK)
            {   
                return;
            }
            

            String strLines = "";
            foreach (string s in ListBox.Items)
            {
                if (!strLines.Equals(""))
                {
                    strLines += Environment.NewLine;
                }
                strLines += s;
            }
            StreamWriter wFile = new StreamWriter(SaveWindow.FileName, false, Encoding.Unicode);
            wFile.Write(strLines);
            wFile.Close();
        }

    }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            OpenFileDialog OpenWindow = new OpenFileDialog();
            if (OpenWindow.ShowDialog() == DialogResult.OK)
            {
                text = FileEdit.open(OpenWindow.FileName);
                ListBox.Items.ToString() = text;
            }
            else
            {
                MessageBox.Show("Not good File!"); 
            }
        }



        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo = 0;

            try
            {
                kilo = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("enter the value of kilo meter with number !");
            }
            int summury = 0;

            int added = 0;
            int reduced = 0;
            int h = kilo / 50;
            summury = h * 10;
            if (comboBox1.SelectedIndex == 0)
            {
                added = (20 * summury) / 100;

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                added = (10 * summury) / 100;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                added = 0;
            }
            summury += added;
            if (radioButton1.Checked)
            {
                reduced = (summury * 50) / 100;


            }
            else if (radioButton2.Checked)
            {
                reduced = (summury * 20) / 100;
            }
            else if (radioButton3.Checked)
            {
                reduced = 0;
            }
            summury -= reduced;

            textBox2.Text = Convert.ToString(summury);
        }
    }
}
