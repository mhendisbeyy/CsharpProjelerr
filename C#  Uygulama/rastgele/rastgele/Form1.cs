using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rastgele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnata_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtaralik1.Text);
            int b = Convert.ToInt32(txtaralik2.Text);
            int[] dizi = new int[10];
            int rastgele;
            int gecici;

            Random Rnd = new Random();

            for (int d = 0; d < 10; d++)

            {
                rastgele = Rnd.Next(a, b);
                dizi[d] = rastgele;
            }
            for (int i = 0; i < 10; i++)

            {

                for (int j = i + 1; j < 10; j++)

                {

                    if (dizi[j] < dizi[i])

                    {

                        gecici = dizi[i];

                        dizi[i] = dizi[j];

                        dizi[j] = gecici;

                    }



                }
            }
            foreach (int c in dizi)
            {
                listBox1.Items.Add(c);
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
