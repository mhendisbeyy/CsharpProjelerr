using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int adim = Convert.ToInt32(textBox3.Text);
            ArrayList dizi = new ArrayList();
            dizi.Add(sayi1);
            dizi.Add(sayi2);
            int sonuc;
            for (int i = 0; i < adim; i++)
            {

                sonuc = sayi1 + sayi2;
                sayi1 = sayi2;

                sayi2 = sonuc;
                dizi.Add(sonuc);
                listBox1.Items.Add(dizi[i]);


            }
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
