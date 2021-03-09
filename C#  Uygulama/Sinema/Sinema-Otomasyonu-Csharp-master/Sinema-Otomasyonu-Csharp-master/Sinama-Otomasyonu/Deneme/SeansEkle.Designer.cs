namespace Deneme
{
    partial class SeansEkle
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
            this.components = new System.ComponentModel.Container();
            this.btnekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpbaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpbitis = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbfilmadi = new System.Windows.Forms.ComboBox();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet2 = new Deneme.Deneme1DataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbsalonadi = new System.Windows.Forms.ComboBox();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet3 = new Deneme.Deneme1DataSet3();
            this.filmTableAdapter = new Deneme.Deneme1DataSet2TableAdapters.FilmTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.salonTableAdapter = new Deneme.Deneme1DataSet3TableAdapters.SalonTableAdapter();
            this.mskdsaat = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(260, 306);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(109, 33);
            this.btnekle.TabIndex = 15;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(241, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Samsun 19 Sinema Sistemi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Seans Başlangıç Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "Seans Saati :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Seans Bitiş Tarihi :";
            // 
            // dtpbaslangic
            // 
            this.dtpbaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbaslangic.Location = new System.Drawing.Point(249, 210);
            this.dtpbaslangic.Name = "dtpbaslangic";
            this.dtpbaslangic.Size = new System.Drawing.Size(238, 30);
            this.dtpbaslangic.TabIndex = 22;
            this.dtpbaslangic.Value = new System.DateTime(2019, 3, 6, 12, 50, 7, 0);
            // 
            // dtpbitis
            // 
            this.dtpbitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbitis.Location = new System.Drawing.Point(249, 259);
            this.dtpbitis.Name = "dtpbitis";
            this.dtpbitis.Size = new System.Drawing.Size(238, 30);
            this.dtpbitis.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Film Adı :";
            // 
            // cmbfilmadi
            // 
            this.cmbfilmadi.DataSource = this.filmBindingSource;
            this.cmbfilmadi.DisplayMember = "Filmadi";
            this.cmbfilmadi.FormattingEnabled = true;
            this.cmbfilmadi.Location = new System.Drawing.Point(249, 76);
            this.cmbfilmadi.Name = "cmbfilmadi";
            this.cmbfilmadi.Size = new System.Drawing.Size(299, 32);
            this.cmbfilmadi.TabIndex = 25;
            this.cmbfilmadi.ValueMember = "Filmadi";
            this.cmbfilmadi.SelectedIndexChanged += new System.EventHandler(this.cmbfilmadi_SelectedIndexChanged);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.deneme1DataSet2;
            // 
            // deneme1DataSet2
            // 
            this.deneme1DataSet2.DataSetName = "Deneme1DataSet2";
            this.deneme1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Salon Adı :";
            // 
            // cmbsalonadi
            // 
            this.cmbsalonadi.DataSource = this.salonBindingSource;
            this.cmbsalonadi.DisplayMember = "Salonno";
            this.cmbsalonadi.FormattingEnabled = true;
            this.cmbsalonadi.Location = new System.Drawing.Point(249, 114);
            this.cmbsalonadi.Name = "cmbsalonadi";
            this.cmbsalonadi.Size = new System.Drawing.Size(299, 32);
            this.cmbsalonadi.TabIndex = 27;
            this.cmbsalonadi.ValueMember = "Salonno";
            this.cmbsalonadi.SelectedIndexChanged += new System.EventHandler(this.cmbsalonadi_SelectedIndexChanged);
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "Salon";
            this.salonBindingSource.DataSource = this.deneme1DataSet3;
            // 
            // deneme1DataSet3
            // 
            this.deneme1DataSet3.DataSetName = "Deneme1DataSet3";
            this.deneme1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "0";
            this.label8.Visible = false;
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // mskdsaat
            // 
            this.mskdsaat.Location = new System.Drawing.Point(249, 162);
            this.mskdsaat.Mask = "00:00";
            this.mskdsaat.Name = "mskdsaat";
            this.mskdsaat.Size = new System.Drawing.Size(238, 30);
            this.mskdsaat.TabIndex = 30;
            this.mskdsaat.ValidatingType = typeof(System.DateTime);
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 462);
            this.Controls.Add(this.mskdsaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbsalonadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbfilmadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpbitis);
            this.Controls.Add(this.dtpbaslangic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SeansEkle";
            this.Text = "SeansEkle";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpbaslangic;
        private System.Windows.Forms.DateTimePicker dtpbitis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbfilmadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbsalonadi;
        private Deneme1DataSet2 deneme1DataSet2;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Deneme1DataSet2TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Deneme1DataSet3 deneme1DataSet3;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private Deneme1DataSet3TableAdapters.SalonTableAdapter salonTableAdapter;
        private System.Windows.Forms.MaskedTextBox mskdsaat;
    }
}