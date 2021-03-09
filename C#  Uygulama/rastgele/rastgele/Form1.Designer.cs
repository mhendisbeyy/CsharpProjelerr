namespace rastgele
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtaralik1 = new System.Windows.Forms.TextBox();
            this.txtaralik2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnata = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aralık 1:";
            // 
            // txtaralik1
            // 
            this.txtaralik1.Location = new System.Drawing.Point(207, 47);
            this.txtaralik1.Name = "txtaralik1";
            this.txtaralik1.Size = new System.Drawing.Size(100, 26);
            this.txtaralik1.TabIndex = 1;
            // 
            // txtaralik2
            // 
            this.txtaralik2.Location = new System.Drawing.Point(207, 79);
            this.txtaralik2.Name = "txtaralik2";
            this.txtaralik2.Size = new System.Drawing.Size(100, 26);
            this.txtaralik2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aralık 2:";
            // 
            // btnata
            // 
            this.btnata.Location = new System.Drawing.Point(207, 164);
            this.btnata.Name = "btnata";
            this.btnata.Size = new System.Drawing.Size(100, 31);
            this.btnata.TabIndex = 4;
            this.btnata.Text = "Oluştur";
            this.btnata.UseVisualStyleBackColor = true;
            this.btnata.Click += new System.EventHandler(this.btnata_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(359, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 144);
            this.listBox1.TabIndex = 5;
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(86, 164);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(100, 31);
            this.btntemizle.TabIndex = 6;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 351);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnata);
            this.Controls.Add(this.txtaralik2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaralik1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaralik1;
        private System.Windows.Forms.TextBox txtaralik2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnata;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btntemizle;
    }
}

