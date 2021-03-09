namespace Deneme
{
    partial class FilmSalon
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
            this.label5 = new System.Windows.Forms.Label();
            this.Btngetir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mttarih = new System.Windows.Forms.MaskedTextBox();
            this.txtkoltuksayisi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsalon = new System.Windows.Forms.TextBox();
            this.txtsaat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbKoltuk = new System.Windows.Forms.GroupBox();
            this.lblfilm = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Btngetir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mttarih);
            this.groupBox1.Controls.Add(this.txtkoltuksayisi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsalon);
            this.groupBox1.Controls.Add(this.txtsaat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1238, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(669, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "8";
            this.label5.Visible = false;
            // 
            // Btngetir
            // 
            this.Btngetir.Location = new System.Drawing.Point(371, 97);
            this.Btngetir.Name = "Btngetir";
            this.Btngetir.Size = new System.Drawing.Size(124, 38);
            this.Btngetir.TabIndex = 8;
            this.Btngetir.Text = "Ara";
            this.Btngetir.UseVisualStyleBackColor = true;
            this.Btngetir.Click += new System.EventHandler(this.Btngetir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Seans Tarihi :";
            // 
            // mttarih
            // 
            this.mttarih.Location = new System.Drawing.Point(401, 51);
            this.mttarih.Mask = "00/00/0000";
            this.mttarih.Name = "mttarih";
            this.mttarih.Size = new System.Drawing.Size(147, 30);
            this.mttarih.TabIndex = 6;
            this.mttarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtkoltuksayisi
            // 
            this.txtkoltuksayisi.Location = new System.Drawing.Point(1024, 51);
            this.txtkoltuksayisi.Multiline = true;
            this.txtkoltuksayisi.Name = "txtkoltuksayisi";
            this.txtkoltuksayisi.Size = new System.Drawing.Size(63, 36);
            this.txtkoltuksayisi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(880, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Koltuk Sayısı :";
            // 
            // txtsalon
            // 
            this.txtsalon.Location = new System.Drawing.Point(686, 51);
            this.txtsalon.Multiline = true;
            this.txtsalon.Name = "txtsalon";
            this.txtsalon.Size = new System.Drawing.Size(178, 36);
            this.txtsalon.TabIndex = 3;
            // 
            // txtsaat
            // 
            this.txtsaat.Location = new System.Drawing.Point(123, 51);
            this.txtsaat.Multiline = true;
            this.txtsaat.Name = "txtsaat";
            this.txtsaat.Size = new System.Drawing.Size(127, 36);
            this.txtsaat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seans Saat :";
            // 
            // gbKoltuk
            // 
            this.gbKoltuk.BackgroundImage = global::Deneme.Properties.Resources._1230_seaport_theater;
            this.gbKoltuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbKoltuk.Location = new System.Drawing.Point(90, 197);
            this.gbKoltuk.Name = "gbKoltuk";
            this.gbKoltuk.Size = new System.Drawing.Size(1238, 522);
            this.gbKoltuk.TabIndex = 1;
            this.gbKoltuk.TabStop = false;
            this.gbKoltuk.Text = "Koltuk Bilgisi";
            // 
            // lblfilm
            // 
            this.lblfilm.AutoSize = true;
            this.lblfilm.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfilm.Location = new System.Drawing.Point(653, 9);
            this.lblfilm.Name = "lblfilm";
            this.lblfilm.Size = new System.Drawing.Size(196, 28);
            this.lblfilm.TabIndex = 2;
            this.lblfilm.Text = "-----------------------";
            // 
            // FilmSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Deneme.Properties.Resources.images__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblfilm);
            this.Controls.Add(this.gbKoltuk);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FilmSalon";
            this.Text = "FilmSalon";
            this.Load += new System.EventHandler(this.FilmSalon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsalon;
        private System.Windows.Forms.TextBox txtsaat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbKoltuk;
        private System.Windows.Forms.Label lblfilm;
        private System.Windows.Forms.TextBox txtkoltuksayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btngetir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mttarih;
        private System.Windows.Forms.Label label5;
    }
}