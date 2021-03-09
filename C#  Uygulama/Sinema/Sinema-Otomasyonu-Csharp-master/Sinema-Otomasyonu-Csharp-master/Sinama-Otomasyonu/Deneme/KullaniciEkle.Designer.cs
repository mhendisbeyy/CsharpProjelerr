namespace Deneme
{
    partial class KullaniciEkle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkullanici = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deneme1DataSet6 = new Deneme.Deneme1DataSet6();
            this.yoneticiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yoneticiTableAdapter = new Deneme.Deneme1DataSet6TableAdapters.YoneticiTableAdapter();
            this.yoneticiidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticiadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoneticisifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.txtkullanici);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre :";
            // 
            // txtkullanici
            // 
            this.txtkullanici.Location = new System.Drawing.Point(154, 54);
            this.txtkullanici.Multiline = true;
            this.txtkullanici.Name = "txtkullanici";
            this.txtkullanici.Size = new System.Drawing.Size(136, 31);
            this.txtkullanici.TabIndex = 1;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(154, 98);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(136, 31);
            this.txtsifre.TabIndex = 3;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(167, 151);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(87, 35);
            this.btnekle.TabIndex = 1;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(385, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kullanıcılar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yoneticiidDataGridViewTextBoxColumn,
            this.yoneticiadDataGridViewTextBoxColumn,
            this.yoneticisifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.yoneticiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // deneme1DataSet6
            // 
            this.deneme1DataSet6.DataSetName = "Deneme1DataSet6";
            this.deneme1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yoneticiBindingSource
            // 
            this.yoneticiBindingSource.DataMember = "Yonetici";
            this.yoneticiBindingSource.DataSource = this.deneme1DataSet6;
            // 
            // yoneticiTableAdapter
            // 
            this.yoneticiTableAdapter.ClearBeforeFill = true;
            // 
            // yoneticiidDataGridViewTextBoxColumn
            // 
            this.yoneticiidDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.HeaderText = "Yoneticiid";
            this.yoneticiidDataGridViewTextBoxColumn.Name = "yoneticiidDataGridViewTextBoxColumn";
            this.yoneticiidDataGridViewTextBoxColumn.ReadOnly = true;
            this.yoneticiidDataGridViewTextBoxColumn.Width = 200;
            // 
            // yoneticiadDataGridViewTextBoxColumn
            // 
            this.yoneticiadDataGridViewTextBoxColumn.DataPropertyName = "Yoneticiad";
            this.yoneticiadDataGridViewTextBoxColumn.HeaderText = "Yoneticiad";
            this.yoneticiadDataGridViewTextBoxColumn.Name = "yoneticiadDataGridViewTextBoxColumn";
            this.yoneticiadDataGridViewTextBoxColumn.Width = 200;
            // 
            // yoneticisifreDataGridViewTextBoxColumn
            // 
            this.yoneticisifreDataGridViewTextBoxColumn.DataPropertyName = "Yoneticisifre";
            this.yoneticisifreDataGridViewTextBoxColumn.HeaderText = "Yoneticisifre";
            this.yoneticisifreDataGridViewTextBoxColumn.Name = "yoneticisifreDataGridViewTextBoxColumn";
            this.yoneticisifreDataGridViewTextBoxColumn.Width = 200;
            // 
            // KullaniciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 349);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "KullaniciEkle";
            this.Text = "KullaniciEkle";
            this.Load += new System.EventHandler(this.KullaniciEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yoneticiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.TextBox txtkullanici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Deneme1DataSet6 deneme1DataSet6;
        private System.Windows.Forms.BindingSource yoneticiBindingSource;
        private Deneme1DataSet6TableAdapters.YoneticiTableAdapter yoneticiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticiadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoneticisifreDataGridViewTextBoxColumn;
    }
}