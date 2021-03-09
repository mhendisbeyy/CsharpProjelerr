using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void btn_B_Click(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            label5.Text = btn_B.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                picbox_true.Visible = true;
               
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                picbox_false.Visible = true;
              
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            label5.Text = btn_C.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                picbox_true.Visible = true;
              
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                picbox_false.Visible = true;
              
            }
        }

        private void btn_D_Click(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            label5.Text = btn_D.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                picbox_true.Visible = true;
               
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                picbox_false.Visible = true;
              
            }
        }

        private void btn_A_Click(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = true;
            btn_A.Enabled = false;
            btn_B.Enabled = false;
            btn_C.Enabled = false;
            btn_D.Enabled = false;
            label5.Text = btn_A.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                lbl_dogru.Text = dogru.ToString();
                picbox_true.Visible = true;
               
            }
            else
            {
                yanlis++;
                lbl_yanlis.Text = yanlis.ToString();
                picbox_false.Visible = true;
               
            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            btn_sonraki.Enabled = false;
            ricbox.Enabled = false;
            btn_A.Enabled = true;
            btn_B.Enabled = true;
            btn_C.Enabled = true;
            btn_D.Enabled = true;
            picbox_false.Visible = false;
            picbox_true.Visible = false;
            soruno++;
            lbl_soru.Text = soruno.ToString();
            if (soruno == 1)
            {
                ricbox.Text = "Cumhuriyet Kaç yılında ilan edilmiştir?";
                btn_A.Text = "1920";
                btn_B.Text = "1919";
                btn_C.Text = "1923";
                btn_D.Text = "1938";
                label4.Text = "1923";
            }
            if(soruno==2)
            {
                ricbox.Text = "Hangi Şehir Akdeniz Bölgesi'nde bulunmaz?";
                btn_A.Text = "Kahramanmaraş";
                btn_B.Text = "Muğla";
                btn_C.Text = "Karaman";
                btn_D.Text = "Burdur";
                label4.Text = "Muğla";
            }
            if (soruno == 3)
            {
                ricbox.Text = "Son Kuşlar kitabının yazarı kimdir?";
                btn_A.Text = "Atilla İlhan";
                btn_B.Text = "Cemal Süreyya";
                btn_C.Text = "Ahmet Telli";
                btn_D.Text = "Sait Faik Abasıyanık";
                label4.Text = "Sait Faik Abasıyanık";
            }
            if (soruno == 4) 
            {
                lbl_soru.Text = 3.ToString();
                btn_A.Enabled = false;
                btn_B.Enabled = false;
                btn_C.Enabled = false;
                btn_D.Enabled = false;
                btn_sonraki.Text = "Sonuçlar";
                MessageBox.Show("Bütün Sorulara Cevap Verdiniz." +"\n" + "Doğru Sayınız : " + dogru + "\n" + "Yanlış Sayınız :" +yanlis );
            }
        }
    }
}
