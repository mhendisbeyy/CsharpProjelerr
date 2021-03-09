namespace Deneme
{
    partial class YoneticiAnasayfa
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
            this.Lblkullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmyonetmenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet7 = new Deneme.Deneme1DataSet7();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet = new Deneme.Deneme1DataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.filmTableAdapter = new Deneme.Deneme1DataSetTableAdapters.FilmTableAdapter();
            this.filmTableAdapter1 = new Deneme.Deneme1DataSet7TableAdapters.FilmTableAdapter();
            this.btnSeanssil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lblkullanici);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı";
            // 
            // Lblkullanici
            // 
            this.Lblkullanici.AutoSize = true;
            this.Lblkullanici.Location = new System.Drawing.Point(158, 38);
            this.Lblkullanici.Name = "Lblkullanici";
            this.Lblkullanici.Size = new System.Drawing.Size(62, 24);
            this.Lblkullanici.TabIndex = 1;
            this.Lblkullanici.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(336, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 342);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vizyondaki Filmler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmadiDataGridViewTextBoxColumn,
            this.filmturuDataGridViewTextBoxColumn,
            this.filmyonetmenDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridView1.DataSource = this.filmBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "Filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "Filmid";
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmadiDataGridViewTextBoxColumn
            // 
            this.filmadiDataGridViewTextBoxColumn.DataPropertyName = "Filmadi";
            this.filmadiDataGridViewTextBoxColumn.HeaderText = "Filmadi";
            this.filmadiDataGridViewTextBoxColumn.Name = "filmadiDataGridViewTextBoxColumn";
            this.filmadiDataGridViewTextBoxColumn.Width = 200;
            // 
            // filmturuDataGridViewTextBoxColumn
            // 
            this.filmturuDataGridViewTextBoxColumn.DataPropertyName = "Filmturu";
            this.filmturuDataGridViewTextBoxColumn.HeaderText = "Filmturu";
            this.filmturuDataGridViewTextBoxColumn.Name = "filmturuDataGridViewTextBoxColumn";
            // 
            // filmyonetmenDataGridViewTextBoxColumn
            // 
            this.filmyonetmenDataGridViewTextBoxColumn.DataPropertyName = "Filmyonetmen";
            this.filmyonetmenDataGridViewTextBoxColumn.HeaderText = "Filmyonetmen";
            this.filmyonetmenDataGridViewTextBoxColumn.Name = "filmyonetmenDataGridViewTextBoxColumn";
            this.filmyonetmenDataGridViewTextBoxColumn.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Filmid";
            this.Column1.HeaderText = "Seç";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Seç";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Filmid";
            this.Column2.HeaderText = "Düzenle";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Düzenle";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "Film";
            this.filmBindingSource1.DataSource = this.deneme1DataSet7;
            // 
            // deneme1DataSet7
            // 
            this.deneme1DataSet7.DataSetName = "Deneme1DataSet7";
            this.deneme1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.deneme1DataSet;
            // 
            // deneme1DataSet
            // 
            this.deneme1DataSet.DataSetName = "Deneme1DataSet";
            this.deneme1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSeanssil);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(15, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 254);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekle";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(153, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 51);
            this.button4.TabIndex = 3;
            this.button4.Text = "Kullanıcı  Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(159, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 51);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salon Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sens Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Film Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(239, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Samsun 19 Sinema Sistemi";
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter1
            // 
            this.filmTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSeanssil
            // 
            this.btnSeanssil.Location = new System.Drawing.Point(95, 184);
            this.btnSeanssil.Name = "btnSeanssil";
            this.btnSeanssil.Size = new System.Drawing.Size(132, 51);
            this.btnSeanssil.TabIndex = 4;
            this.btnSeanssil.Text = "Seans Sil";
            this.btnSeanssil.UseVisualStyleBackColor = true;
            this.btnSeanssil.Click += new System.EventHandler(this.btnSeanssil_Click);
            // 
            // YoneticiAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 530);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "YoneticiAnasayfa";
            this.Text = "YoneticiAnasayfa";
            this.Load += new System.EventHandler(this.YoneticiAnasayfa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lblkullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Deneme1DataSet deneme1DataSet;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Deneme1DataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmyonetmenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private Deneme1DataSet7 deneme1DataSet7;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private Deneme1DataSet7TableAdapters.FilmTableAdapter filmTableAdapter1;
        private System.Windows.Forms.Button btnSeanssil;
    }
}