using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox2.Clear();
            char[] chars = textBox1.Text.ToCharArray();
            foreach (char c in chars)
                textBox2.Text += Convert.ToChar(c ^ 5);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            char[] chars = textBox2.Text.ToCharArray();
            foreach (char c in chars)
                textBox1.Text += Convert.ToChar(c ^ 5);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();textBox1.Clear();
        }
    }
}
