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

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Mentés\\" + textBox1.Text + ".txt");
            sw.WriteLine(label1.Text + " " + textBox1.Text);
            sw.WriteLine(label2.Text + " " + textBox2.Text);
            if (radioButton1.Checked == true)
            {
                sw.WriteLine("Neme: Férfi");
            }
            else if (radioButton2.Checked == true)
            {
                sw.WriteLine("Neme: Nő");
            }

            sw.WriteLine(label4.Text + " " + listBox1.Text);
            sw.Close();

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Mentés\\" + textBox1.Text + ".txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();

        }
    }
}
