using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            YoneticiGiris fr = new YoneticiGiris();
            fr.Show();
           
        }

       
    }
}
