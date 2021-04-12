using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuricevicNevenSystemNiOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:testNiOP.txt");
            richTextBox2.SaveFile(@"C:testNiOP.txt");
            richTextBox3.SaveFile(@"C:testNiOP.txt");
            richTextBox4.SaveFile(@"C:testNiOP.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"C:testNiOP.txt");
            richTextBox2.LoadFile(@"C:testNiOP.txt");
            richTextBox3.LoadFile(@"C:testNiOP.txt");
            richTextBox4.LoadFile(@"C:testNiOP.txt");
        }
    }
}
