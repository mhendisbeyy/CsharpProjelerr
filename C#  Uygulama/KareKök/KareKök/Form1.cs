using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KareKök
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                int sayi = Convert.ToInt32(textBox1.Text);
                double karekok = 1; int i = 0;
                Boolean m = true;
                while (m)
                {
                    i = i + 1;
                    karekok = (sayi / karekok + karekok) / 2;
                    if (i == sayi + 1) { m = false; }
                }
                lblsnc.Text = Convert.ToString(karekok);
            }

        }
    }
}
