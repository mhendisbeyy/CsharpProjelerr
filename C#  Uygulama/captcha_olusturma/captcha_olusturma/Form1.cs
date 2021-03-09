using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha_olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string [] sembol = { "a", "b", "c", "d", "e", "f", "g", "h" };
            string [] sembol2 = { "+", "-", "*", "/", "<", ">","#" };
            
            Random rnd = new Random();
            int s1, s2, s3;
            s1 = rnd.Next(0, sembol.Length);
            s2 = rnd.Next(0, sembol2.Length);
            s3 = rnd.Next(0, 10);
            label1.Text = sembol[s1] + sembol2[s2] + s3.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }
    }
}
