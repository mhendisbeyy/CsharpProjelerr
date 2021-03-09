namespace Bilgi_Yarisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ricbox = new System.Windows.Forms.RichTextBox();
            this.btn_A = new System.Windows.Forms.Button();
            this.btn_B = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_D = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_soru = new System.Windows.Forms.Label();
            this.lbl_dogru = new System.Windows.Forms.Label();
            this.lbl_yanlis = new System.Windows.Forms.Label();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.picbox_false = new System.Windows.Forms.PictureBox();
            this.picbox_true = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_false)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_true)).BeginInit();
            this.SuspendLayout();
            // 
            // ricbox
            // 
            this.ricbox.Location = new System.Drawing.Point(21, 21);
            this.ricbox.Name = "ricbox";
            this.ricbox.Size = new System.Drawing.Size(492, 147);
            this.ricbox.TabIndex = 0;
            this.ricbox.Text = "";
            // 
            // btn_A
            // 
            this.btn_A.Location = new System.Drawing.Point(12, 202);
            this.btn_A.Name = "btn_A";
            this.btn_A.Size = new System.Drawing.Size(224, 62);
            this.btn_A.TabIndex = 1;
            this.btn_A.Text = "A";
            this.btn_A.UseVisualStyleBackColor = true;
            this.btn_A.Click += new System.EventHandler(this.btn_A_Click);
            // 
            // btn_B
            // 
            this.btn_B.Location = new System.Drawing.Point(289, 202);
            this.btn_B.Name = "btn_B";
            this.btn_B.Size = new System.Drawing.Size(224, 62);
            this.btn_B.TabIndex = 2;
            this.btn_B.Text = "B";
            this.btn_B.UseVisualStyleBackColor = true;
            this.btn_B.Click += new System.EventHandler(this.btn_B_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(12, 279);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(224, 62);
            this.btn_C.TabIndex = 3;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_D
            // 
            this.btn_D.Location = new System.Drawing.Point(289, 279);
            this.btn_D.Name = "btn_D";
            this.btn_D.Size = new System.Drawing.Size(224, 62);
            this.btn_D.TabIndex = 4;
            this.btn_D.Text = "D";
            this.btn_D.UseVisualStyleBackColor = true;
            this.btn_D.Click += new System.EventHandler(this.btn_D_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(538, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(555, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Doğru :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(556, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yanlış :";
            // 
            // lbl_soru
            // 
            this.lbl_soru.AutoSize = true;
            this.lbl_soru.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_soru.Location = new System.Drawing.Point(632, 32);
            this.lbl_soru.Name = "lbl_soru";
            this.lbl_soru.Size = new System.Drawing.Size(23, 26);
            this.lbl_soru.TabIndex = 8;
            this.lbl_soru.Text = "0";
            // 
            // lbl_dogru
            // 
            this.lbl_dogru.AutoSize = true;
            this.lbl_dogru.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dogru.Location = new System.Drawing.Point(632, 73);
            this.lbl_dogru.Name = "lbl_dogru";
            this.lbl_dogru.Size = new System.Drawing.Size(23, 26);
            this.lbl_dogru.TabIndex = 9;
            this.lbl_dogru.Text = "0";
            // 
            // lbl_yanlis
            // 
            this.lbl_yanlis.AutoSize = true;
            this.lbl_yanlis.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yanlis.Location = new System.Drawing.Point(632, 114);
            this.lbl_yanlis.Name = "lbl_yanlis";
            this.lbl_yanlis.Size = new System.Drawing.Size(23, 26);
            this.lbl_yanlis.TabIndex = 10;
            this.lbl_yanlis.Text = "0";
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Location = new System.Drawing.Point(573, 167);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(159, 43);
            this.btn_sonraki.TabIndex = 11;
            this.btn_sonraki.Text = "Sonraki Soru >>";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // picbox_false
            // 
            this.picbox_false.Image = ((System.Drawing.Image)(resources.GetObject("picbox_false.Image")));
            this.picbox_false.Location = new System.Drawing.Point(642, 242);
            this.picbox_false.Name = "picbox_false";
            this.picbox_false.Size = new System.Drawing.Size(90, 85);
            this.picbox_false.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_false.TabIndex = 12;
            this.picbox_false.TabStop = false;
            this.picbox_false.Visible = false;
            // 
            // picbox_true
            // 
            this.picbox_true.Image = ((System.Drawing.Image)(resources.GetObject("picbox_true.Image")));
            this.picbox_true.Location = new System.Drawing.Point(542, 242);
            this.picbox_true.Name = "picbox_true";
            this.picbox_true.Size = new System.Drawing.Size(90, 85);
            this.picbox_true.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_true.TabIndex = 13;
            this.picbox_true.TabStop = false;
            this.picbox_true.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 402);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picbox_true);
            this.Controls.Add(this.picbox_false);
            this.Controls.Add(this.btn_sonraki);
            this.Controls.Add(this.lbl_yanlis);
            this.Controls.Add(this.lbl_dogru);
            this.Controls.Add(this.lbl_soru);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_D);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_B);
            this.Controls.Add(this.btn_A);
            this.Controls.Add(this.ricbox);
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbox_false)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_true)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ricbox;
        private System.Windows.Forms.Button btn_A;
        private System.Windows.Forms.Button btn_B;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_D;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_soru;
        private System.Windows.Forms.Label lbl_dogru;
        private System.Windows.Forms.Label lbl_yanlis;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.PictureBox picbox_false;
        private System.Windows.Forms.PictureBox picbox_true;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

