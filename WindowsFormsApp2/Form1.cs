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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Open Training Data";
                ofd.Filter = "Text file |*.txt";
                ofd.ShowDialog();
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                string fline = sr.ReadLine();
                
                if (!fline.Contains("topology:"))
                {
                    MessageBox.Show("Training data file does not start with topology!"); // reads the first line
                }


                //if (File.ReadLines(ofd.FileName).Contains("topology: "))
                //{
                //    MessageBox.Show("correct File");
                //}
                string readFile = File.ReadAllText(ofd.FileName);
                string[] line = readFile.Split('\n');
                int count = 0;
                foreach(string str in line[0].Split(' '))
                {
                    count++;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }
    }
}
