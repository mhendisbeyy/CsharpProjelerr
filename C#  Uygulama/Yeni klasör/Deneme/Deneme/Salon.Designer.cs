namespace Deneme
{
    partial class Salon
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalonekle = new System.Windows.Forms.Button();
            this.txtsalon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnduzenle = new System.Windows.Forms.Button();
            this.txtkoltuksayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deneme1DataSet10 = new Deneme.Deneme1DataSet10();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonTableAdapter = new Deneme.Deneme1DataSet10TableAdapters.SalonTableAdapter();
            this.salonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonkoltuksayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(300, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Samsun 19 Sinema Sistemi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtkoltuksayisi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnduzenle);
            this.groupBox1.Controls.Add(this.btnsalonekle);
            this.groupBox1.Controls.Add(this.txtsalon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(73, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon Ekle";
            // 
            // btnsalonekle
            // 
            this.btnsalonekle.Location = new System.Drawing.Point(168, 200);
            this.btnsalonekle.Name = "btnsalonekle";
            this.btnsalonekle.Size = new System.Drawing.Size(123, 35);
            this.btnsalonekle.TabIndex = 2;
            this.btnsalonekle.Text = "Salon Ekle";
            this.btnsalonekle.UseVisualStyleBackColor = true;
            this.btnsalonekle.Click += new System.EventHandler(this.btnsalonekle_Click);
            // 
            // txtsalon
            // 
            this.txtsalon.Location = new System.Drawing.Point(168, 90);
            this.txtsalon.Multiline = true;
            this.txtsalon.Name = "txtsalon";
            this.txtsalon.Size = new System.Drawing.Size(177, 34);
            this.txtsalon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon Adı :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(470, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 211);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salonlar";
            // 
            // btnduzenle
            // 
            this.btnduzenle.Location = new System.Drawing.Point(21, 200);
            this.btnduzenle.Name = "btnduzenle";
            this.btnduzenle.Size = new System.Drawing.Size(123, 35);
            this.btnduzenle.TabIndex = 3;
            this.btnduzenle.Text = "Düzenle";
            this.btnduzenle.UseVisualStyleBackColor = true;
            this.btnduzenle.Click += new System.EventHandler(this.btnduzenle_Click);
            // 
            // txtkoltuksayisi
            // 
            this.txtkoltuksayisi.Location = new System.Drawing.Point(168, 139);
            this.txtkoltuksayisi.Multiline = true;
            this.txtkoltuksayisi.Name = "txtkoltuksayisi";
            this.txtkoltuksayisi.Size = new System.Drawing.Size(177, 34);
            this.txtkoltuksayisi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koltuk Sayısı :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salonidDataGridViewTextBoxColumn,
            this.salonnoDataGridViewTextBoxColumn,
            this.salonkoltuksayisiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salonBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // deneme1DataSet10
            // 
            this.deneme1DataSet10.DataSetName = "Deneme1DataSet10";
            this.deneme1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "Salon";
            this.salonBindingSource.DataSource = this.deneme1DataSet10;
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // salonidDataGridViewTextBoxColumn
            // 
            this.salonidDataGridViewTextBoxColumn.DataPropertyName = "Salonid";
            this.salonidDataGridViewTextBoxColumn.HeaderText = "Salonid";
            this.salonidDataGridViewTextBoxColumn.Name = "salonidDataGridViewTextBoxColumn";
            this.salonidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonnoDataGridViewTextBoxColumn
            // 
            this.salonnoDataGridViewTextBoxColumn.DataPropertyName = "Salonno";
            this.salonnoDataGridViewTextBoxColumn.HeaderText = "Salonno";
            this.salonnoDataGridViewTextBoxColumn.Name = "salonnoDataGridViewTextBoxColumn";
            this.salonnoDataGridViewTextBoxColumn.Width = 150;
            // 
            // salonkoltuksayisiDataGridViewTextBoxColumn
            // 
            this.salonkoltuksayisiDataGridViewTextBoxColumn.DataPropertyName = "Salonkoltuksayisi";
            this.salonkoltuksayisiDataGridViewTextBoxColumn.HeaderText = "Koltuk Sayısı";
            this.salonkoltuksayisiDataGridViewTextBoxColumn.Name = "salonkoltuksayisiDataGridViewTextBoxColumn";
            this.salonkoltuksayisiDataGridViewTextBoxColumn.Width = 150;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(168, 50);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(177, 34);
            this.txtid.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salon ID :";
            // 
            // Salon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Salon";
            this.Text = "Salon";
            this.Load += new System.EventHandler(this.Salon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deneme1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalonekle;
        private System.Windows.Forms.TextBox txtsalon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtkoltuksayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnduzenle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Deneme1DataSet10 deneme1DataSet10;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private Deneme1DataSet10TableAdapters.SalonTableAdapter salonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonkoltuksayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
    }
}