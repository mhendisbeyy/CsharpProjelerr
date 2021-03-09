namespace Proje_Hastane
{
    partial class FrmHastaDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LlBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.BtnRandevu = new System.Windows.Forms.Button();
            this.RtbSikayet = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbDoktor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bilgi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.ForeColor = System.Drawing.Color.Red;
            this.LblAdSoyad.Location = new System.Drawing.Point(120, 73);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(146, 23);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Mihrap Hastanesi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad Soyad :";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.ForeColor = System.Drawing.Color.Red;
            this.LblTC.Location = new System.Drawing.Point(120, 40);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(120, 23);
            this.LblTC.TabIndex = 1;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "T.C :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LlBilgiDuzenle);
            this.groupBox2.Controls.Add(this.BtnRandevu);
            this.groupBox2.Controls.Add(this.RtbSikayet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CbDoktor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CbBrans);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // LlBilgiDuzenle
            // 
            this.LlBilgiDuzenle.AutoSize = true;
            this.LlBilgiDuzenle.LinkColor = System.Drawing.Color.Red;
            this.LlBilgiDuzenle.Location = new System.Drawing.Point(6, 254);
            this.LlBilgiDuzenle.Name = "LlBilgiDuzenle";
            this.LlBilgiDuzenle.Size = new System.Drawing.Size(147, 23);
            this.LlBilgiDuzenle.TabIndex = 4;
            this.LlBilgiDuzenle.TabStop = true;
            this.LlBilgiDuzenle.Text = "Bilgilerini Düzenle";
            this.LlBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlBilgiDuzenle_LinkClicked);
            // 
            // BtnRandevu
            // 
            this.BtnRandevu.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRandevu.Location = new System.Drawing.Point(167, 236);
            this.BtnRandevu.Name = "BtnRandevu";
            this.BtnRandevu.Size = new System.Drawing.Size(124, 43);
            this.BtnRandevu.TabIndex = 2;
            this.BtnRandevu.Text = "Randevu Al";
            this.BtnRandevu.UseVisualStyleBackColor = true;
            // 
            // RtbSikayet
            // 
            this.RtbSikayet.Location = new System.Drawing.Point(90, 129);
            this.RtbSikayet.Name = "RtbSikayet";
            this.RtbSikayet.Size = new System.Drawing.Size(201, 101);
            this.RtbSikayet.TabIndex = 3;
            this.RtbSikayet.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(8, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(10, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Doktor :";
            // 
            // CbDoktor
            // 
            this.CbDoktor.FormattingEnabled = true;
            this.CbDoktor.Location = new System.Drawing.Point(90, 89);
            this.CbDoktor.Name = "CbDoktor";
            this.CbDoktor.Size = new System.Drawing.Size(203, 31);
            this.CbDoktor.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(21, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş :";
            // 
            // CbBrans
            // 
            this.CbBrans.FormattingEnabled = true;
            this.CbBrans.Location = new System.Drawing.Point(90, 52);
            this.CbBrans.Name = "CbBrans";
            this.CbBrans.Size = new System.Drawing.Size(203, 31);
            this.CbBrans.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(354, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(354, 226);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(426, 222);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(420, 192);
            this.dataGridView2.TabIndex = 0;
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(819, 460);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHastaDetay";
            this.Text = "FrmHastaDetay";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnRandevu;
        private System.Windows.Forms.RichTextBox RtbSikayet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CbDoktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel LlBilgiDuzenle;
    }
}