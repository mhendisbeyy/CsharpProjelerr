using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] kisiler = { "Ali", "Ünsal", "Yasin", "Ahmet" };
            foreach (string k in kisiler)
                {
                listBox1.Items.Add(k);
            }
        }
        int toplam = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            toplam = 0;
            int[] sinavlar = {70,60,84,96};
            foreach (int x in sinavlar)
            {
                toplam = toplam + x;
                listBox1.Items.Add(x.ToString());
            }
            label3.Text = toplam.ToString();
            int ortalama = toplam / sinavlar.Length;
            label4.Text = ortalama.ToString();
        }
    }
}
