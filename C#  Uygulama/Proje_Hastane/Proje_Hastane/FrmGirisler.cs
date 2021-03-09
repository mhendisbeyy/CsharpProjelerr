using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frh = new FrmHastaGiris();
            frh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frd = new FrmDoktorGiris();
            frd.Show();
        }
    }
}
