using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tersten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] dizi = { "S", "A", "M", "S", "U", "N" };
            string[] yeni = new string[6];
            for (int i = 5; i >= 0; i--)
            {
                yeni[5 - i] = dizi[i];
            }
            label1.Text = dizi[0] + " " + dizi[1] + " " + dizi[2] + " " + dizi[3] + " " + dizi[4] + " " + dizi[5];
            label2.Text = yeni[0] + " " + yeni[1] + " " + yeni[2] + " " + yeni[3] + " " + yeni[4] + " " + yeni[5];
        }
    }
}
