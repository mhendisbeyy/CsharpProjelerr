namespace Deneme
{
    partial class YoneticiGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkullaniciad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btngiris = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(171, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(392, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Samsun 19 Sinema Sistemi";
            // 
            // txtkullaniciad
            // 
            this.txtkullaniciad.Location = new System.Drawing.Point(188, 52);
            this.txtkullaniciad.Multiline = true;
            this.txtkullaniciad.Name = "txtkullaniciad";
            this.txtkullaniciad.Size = new System.Drawing.Size(163, 27);
            this.txtkullaniciad.TabIndex = 3;
            this.txtkullaniciad.Text = "Admin";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(186, 94);
            this.txtsifre.Multiline = true;
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(163, 27);
            this.txtsifre.TabIndex = 4;
            this.txtsifre.Text = "123456";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btngiris);
            this.groupBox1.Controls.Add(this.txtkullaniciad);
            this.groupBox1.Controls.Add(this.txtsifre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(165, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Btngiris
            // 
            this.Btngiris.Location = new System.Drawing.Point(186, 150);
            this.Btngiris.Name = "Btngiris";
            this.Btngiris.Size = new System.Drawing.Size(165, 34);
            this.Btngiris.TabIndex = 5;
            this.Btngiris.Text = "Giriş";
            this.Btngiris.UseVisualStyleBackColor = true;
            this.Btngiris.Click += new System.EventHandler(this.Btngiris_Click);
            // 
            // YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 351);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "YoneticiGiris";
            this.Text = "YoneticiGiris";
            this.Load += new System.EventHandler(this.YoneticiGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkullaniciad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btngiris;
    }
}