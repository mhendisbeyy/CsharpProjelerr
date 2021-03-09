using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 's';
            rb.YIL = 2018;
            rb.MARKASI = "Golf";
            rb.muayene = 2019;
            rb.sahip = "Ali ATALAY";
            rb.Plaka = "46 Ali 620";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();
            label5.Text = rb.durum.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.Plaka;
            pictureBox1.BackColor = Color.CadetBlue;
        }
    }
}
