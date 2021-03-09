namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.CbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(84, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. Kimlik No :";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(229, 285);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(176, 31);
            this.TxtSifre.TabIndex = 7;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(229, 211);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(176, 31);
            this.MskTC.TabIndex = 6;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(115, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 44);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta Kayıt Paneli";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(83, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 44);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mihrap Özel Hastanesi";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(229, 137);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(176, 31);
            this.TxtAd.TabIndex = 15;
            this.TxtAd.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(180, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ad :";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(229, 174);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(176, 31);
            this.TxtSoyad.TabIndex = 17;
            this.TxtSoyad.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(150, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soyad :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(140, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefon :";
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(229, 248);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(176, 31);
            this.MskTelefon.TabIndex = 18;
            // 
            // CbCinsiyet
            // 
            this.CbCinsiyet.FormattingEnabled = true;
            this.CbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.CbCinsiyet.Location = new System.Drawing.Point(229, 322);
            this.CbCinsiyet.Name = "CbCinsiyet";
            this.CbCinsiyet.Size = new System.Drawing.Size(176, 31);
            this.CbCinsiyet.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(136, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 23);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cinsiyet :";
            // 
            // BtnKayit
            // 
            this.BtnKayit.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKayit.ForeColor = System.Drawing.Color.Red;
            this.BtnKayit.Location = new System.Drawing.Point(229, 359);
            this.BtnKayit.Name = "BtnKayit";
            this.BtnKayit.Size = new System.Drawing.Size(156, 33);
            this.BtnKayit.TabIndex = 22;
            this.BtnKayit.Text = "Kayıt Yap";
            this.BtnKayit.UseVisualStyleBackColor = true;
            // 
            // FrmHastaKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(651, 437);
            this.Controls.Add(this.BtnKayit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbCinsiyet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.ComboBox CbCinsiyet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnKayit;
    }
}