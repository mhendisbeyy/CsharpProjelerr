namespace Deneme
{
    partial class SeansSil
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
            this.mskdsaat = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnekle = new System.Windows.Forms.Button();
            this.deneme1DataSet11 = new Deneme.Deneme1DataSet11();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new Deneme.Deneme1DataSet11TableAdapters.FilmTableAdapter();
            this.deneme1DataSet10 = new Deneme.Deneme1DataSet10();
            this.deneme1DataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deneme1DataSet12 = new Deneme.Deneme1DataSet12();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonTableAdapter = new Deneme.Deneme1DataSet12TableAdapters.SalonTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtfilmadi = new System.Windows.Forms.TextBox();
            this.txtsalonadi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mskdsaat
            // 
            this.mskdsaat.Location = new System.Drawing.Point(140, 151);
            this.mskdsaat.Mask = "00:00";
            this.mskdsaat.Name = "mskdsaat";
            this.mskdsaat.Size = new System.Drawing.Size(238, 30);
            this.mskdsaat.TabIndex = 43;
            this.mskdsaat.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 42;
            this.label8.Text = "0";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 39;
            this.label6.Text = "Salon Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Film Adı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Seans Saati :";
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(173, 216);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(109, 33);
            this.btnekle.TabIndex = 32;
            this.btnekle.Text = "Sil";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // deneme1DataSet11
            // 
            this.deneme1DataSet11.DataSetName = "Deneme1DataSet11";
            this.deneme1DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.deneme1DataSet11;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // deneme1DataSet10
            // 
            this.deneme1DataSet10.DataSetName = "Deneme1DataSet10";
            this.deneme1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deneme1DataSet10BindingSource
            // 
            this.deneme1DataSet10BindingSource.DataSource = this.deneme1DataSet10;
            this.deneme1DataSet10BindingSource.Position = 0;
            // 
            // deneme1DataSet12
            // 
            this.deneme1DataSet12.DataSetName = "Deneme1DataSet12";
            this.deneme1DataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "Salon";
            this.salonBindingSource.DataSource = this.deneme1DataSet12;
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(547, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 275);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtfilmadi
            // 
            this.txtfilmadi.Location = new System.Drawing.Point(140, 65);
            this.txtfilmadi.Multiline = true;
            this.txtfilmadi.Name = "txtfilmadi";
            this.txtfilmadi.Size = new System.Drawing.Size(238, 30);
            this.txtfilmadi.TabIndex = 45;
            this.txtfilmadi.TextChanged += new System.EventHandler(this.txtfilmadi_TextChanged);
            // 
            // txtsalonadi
            // 
            this.txtsalonadi.Location = new System.Drawing.Point(140, 108);
            this.txtsalonadi.Multiline = true;
            this.txtsalonadi.Name = "txtsalonadi";
            this.txtsalonadi.Size = new System.Drawing.Size(238, 30);
            this.txtsalonadi.TabIndex = 46;
            this.txtsalonadi.TextChanged += new System.EventHandler(this.txtsalonadi_TextChanged);
            // 
            // SeansSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 394);
            this.Controls.Add(this.txtsalonadi);
            this.Controls.Add(this.txtfilmadi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mskdsaat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnekle);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SeansSil";
            this.Text = "SeansSil";
            this.Load += new System.EventHandler(this.SeansSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskdsaat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnekle;
        private Deneme1DataSet11 deneme1DataSet11;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private Deneme1DataSet11TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource deneme1DataSet10BindingSource;
        private Deneme1DataSet10 deneme1DataSet10;
        private Deneme1DataSet12 deneme1DataSet12;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private Deneme1DataSet12TableAdapters.SalonTableAdapter salonTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtfilmadi;
        private System.Windows.Forms.TextBox txtsalonadi;
    }
}