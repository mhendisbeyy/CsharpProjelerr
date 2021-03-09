using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kup_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        int kup_hesapla(int s1)
        {
            int sonuc = s1 * s1 * s1;
            return sonuc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = kup_hesapla(Convert.ToInt16(textBox1.Text)).ToString();
        }
    }
}
