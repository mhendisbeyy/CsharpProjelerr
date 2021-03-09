using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            int faktoriyel = 1;
            int sayi = Convert.ToInt32(textBox1.Text.ToString());
            for (int i=1;i<sayi+1;i++)
            {
                faktoriyel = i * faktoriyel;

            }
            LblSonuc.Text = faktoriyel.ToString();


        }
    }
}
