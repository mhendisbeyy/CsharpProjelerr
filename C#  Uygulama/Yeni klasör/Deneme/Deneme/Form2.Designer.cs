namespace Deneme
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnseansara = new System.Windows.Forms.Button();
            this.cmbfilmadi = new System.Windows.Forms.ComboBox();
            this.deneme1DataSet13 = new Deneme.Deneme1DataSet13();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new Deneme.Deneme1DataSet13TableAdapters.FilmTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(126, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(593, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film adi :";
            // 
            // btnseansara
            // 
            this.btnseansara.Location = new System.Drawing.Point(245, 113);
            this.btnseansara.Name = "btnseansara";
            this.btnseansara.Size = new System.Drawing.Size(200, 39);
            this.btnseansara.TabIndex = 3;
            this.btnseansara.Text = "Seans Ara";
            this.btnseansara.UseVisualStyleBackColor = true;
            this.btnseansara.Click += new System.EventHandler(this.btnseansara_Click);
            // 
            // cmbfilmadi
            // 
            this.cmbfilmadi.DataSource = this.filmBindingSource;
            this.cmbfilmadi.DisplayMember = "Filmadi";
            this.cmbfilmadi.FormattingEnabled = true;
            this.cmbfilmadi.Location = new System.Drawing.Point(245, 62);
            this.cmbfilmadi.Name = "cmbfilmadi";
            this.cmbfilmadi.Size = new System.Drawing.Size(200, 21);
            this.cmbfilmadi.TabIndex = 4;
            this.cmbfilmadi.ValueMember = "Filmadi";
            // 
            // deneme1DataSet13
            // 
            this.deneme1DataSet13.DataSetName = "Deneme1DataSet13";
            this.deneme1DataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.deneme1DataSet13;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbfilmadi);
            this.Controls.Add(this.btnseansara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnseansara;
        private System.Windows.Forms.ComboBox cmbfilmadi;
        private Deneme1DataSet13 deneme1DataSet13;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Deneme1DataSet13TableAdapters.FilmTableAdapter filmTableAdapter;
    }
}