using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
   
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Bursa";
            comboBox1.Items.Add(label1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Öğretmen");
            listBox1.Items.Add("Doktor");
            listBox1.Items.Add("Memur");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }
    }
}
