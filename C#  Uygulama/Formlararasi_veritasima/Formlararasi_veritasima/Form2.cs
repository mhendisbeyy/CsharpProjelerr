﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlararasi_veritasima
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         public string mesaj;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
