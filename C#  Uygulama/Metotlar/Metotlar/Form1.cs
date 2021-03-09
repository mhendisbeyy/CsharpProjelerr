using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metotlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
        int sayac = 0;
        private void renklendir()
        {
            sayac++;
          if (sayac%2==0)
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Green;
                textBox4.BackColor = Color.Blue;
            }
            else
            {
                textBox1.BackColor = Color.Orange;
                textBox2.BackColor = Color.Pink;
                textBox3.BackColor = Color.SlateBlue;
                textBox4.BackColor = Color.LawnGreen;
            }
        }
        int topla (int s1,int s2)
        {
            int s3 = s1 + s2;
            return s3 ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            renklendir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = topla(4, 6).ToString();
            label2.Text = topla(5, 7).ToString();
            label3.Text = topla(17, 23).ToString();

        }
    }
}
