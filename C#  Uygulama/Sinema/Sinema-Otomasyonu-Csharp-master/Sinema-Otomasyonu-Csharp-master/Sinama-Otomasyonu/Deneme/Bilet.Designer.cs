namespace Deneme
{
    partial class Bilet
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
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnbiletal = new System.Windows.Forms.Button();
            this.txtkoltukno = new System.Windows.Forms.TextBox();
            this.txtsalonadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtseanssaat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfilmadi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mtseanstarihi = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Koltuk No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(202, 149);
            this.txtad.Multiline = true;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(176, 36);
            this.txtad.TabIndex = 3;
            // 
            // btnbiletal
            // 
            this.btnbiletal.Location = new System.Drawing.Point(289, 235);
            this.btnbiletal.Name = "btnbiletal";
            this.btnbiletal.Size = new System.Drawing.Size(350, 46);
            this.btnbiletal.TabIndex = 5;
            this.btnbiletal.Text = "Bilet Al";
            this.btnbiletal.UseVisualStyleBackColor = true;
            this.btnbiletal.Click += new System.EventHandler(this.btnbiletal_Click);
            // 
            // txtkoltukno
            // 
            this.txtkoltukno.Location = new System.Drawing.Point(587, 102);
            this.txtkoltukno.Multiline = true;
            this.txtkoltukno.Name = "txtkoltukno";
            this.txtkoltukno.Size = new System.Drawing.Size(177, 36);
            this.txtkoltukno.TabIndex = 6;
            // 
            // txtsalonadi
            // 
            this.txtsalonadi.Location = new System.Drawing.Point(202, 102);
            this.txtsalonadi.Multiline = true;
            this.txtsalonadi.Name = "txtsalonadi";
            this.txtsalonadi.Size = new System.Drawing.Size(176, 36);
            this.txtsalonadi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Salon No :";
            // 
            // txtseanssaat
            // 
            this.txtseanssaat.Location = new System.Drawing.Point(587, 55);
            this.txtseanssaat.Multiline = true;
            this.txtseanssaat.Name = "txtseanssaat";
            this.txtseanssaat.Size = new System.Drawing.Size(177, 36);
            this.txtseanssaat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seans Saati :";
            // 
            // txtfilmadi
            // 
            this.txtfilmadi.Location = new System.Drawing.Point(202, 55);
            this.txtfilmadi.Multiline = true;
            this.txtfilmadi.Name = "txtfilmadi";
            this.txtfilmadi.Size = new System.Drawing.Size(176, 36);
            this.txtfilmadi.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Film Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Seans Tarihi :";
            // 
            // mtseanstarihi
            // 
            this.mtseanstarihi.Location = new System.Drawing.Point(587, 149);
            this.mtseanstarihi.Mask = "00/00/0000";
            this.mtseanstarihi.Name = "mtseanstarihi";
            this.mtseanstarihi.Size = new System.Drawing.Size(177, 30);
            this.mtseanstarihi.TabIndex = 15;
            this.mtseanstarihi.ValidatingType = typeof(System.DateTime);
            // 
            // Bilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 413);
            this.Controls.Add(this.mtseanstarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtfilmadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtseanssaat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsalonadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkoltukno);
            this.Controls.Add(this.btnbiletal);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Bilet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bilet";
            this.Load += new System.EventHandler(this.Bilet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnbiletal;
        private System.Windows.Forms.TextBox txtkoltukno;
        private System.Windows.Forms.TextBox txtsalonadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtseanssaat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtfilmadi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtseanstarihi;
    }
}