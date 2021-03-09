namespace Menu_Strip
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
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psILoveYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynıYıldızınAltındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuSeansıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzayYolcularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madMaxToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // madMaxToolStripMenuItem
            // 
            this.madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            this.madMaxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.madMaxToolStripMenuItem.Text = "Mad Max";
            this.madMaxToolStripMenuItem.Click += new System.EventHandler(this.madMaxToolStripMenuItem_Click);
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.psILoveYouToolStripMenuItem,
            this.aynıYıldızınAltındaToolStripMenuItem});
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // psILoveYouToolStripMenuItem
            // 
            this.psILoveYouToolStripMenuItem.Name = "psILoveYouToolStripMenuItem";
            this.psILoveYouToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.psILoveYouToolStripMenuItem.Text = "Ps: I love you";
            this.psILoveYouToolStripMenuItem.Click += new System.EventHandler(this.psILoveYouToolStripMenuItem_Click);
            // 
            // aynıYıldızınAltındaToolStripMenuItem
            // 
            this.aynıYıldızınAltındaToolStripMenuItem.Name = "aynıYıldızınAltındaToolStripMenuItem";
            this.aynıYıldızınAltındaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aynıYıldızınAltındaToolStripMenuItem.Text = "Aynı Yıldızın Altında";
            this.aynıYıldızınAltındaToolStripMenuItem.Click += new System.EventHandler(this.aynıYıldızınAltındaToolStripMenuItem_Click);
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korkuSeansıToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // korkuSeansıToolStripMenuItem
            // 
            this.korkuSeansıToolStripMenuItem.Name = "korkuSeansıToolStripMenuItem";
            this.korkuSeansıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.korkuSeansıToolStripMenuItem.Text = "Korku Seansı";
            this.korkuSeansıToolStripMenuItem.Click += new System.EventHandler(this.korkuSeansıToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uzayYolcularıToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // uzayYolcularıToolStripMenuItem
            // 
            this.uzayYolcularıToolStripMenuItem.Name = "uzayYolcularıToolStripMenuItem";
            this.uzayYolcularıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uzayYolcularıToolStripMenuItem.Text = "Uzay Yolcuları";
            this.uzayYolcularıToolStripMenuItem.Click += new System.EventHandler(this.uzayYolcularıToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.griToolStripMenuItem,
            this.turuncuToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.turuncuToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(593, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(25, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(506, 208);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 324);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psILoveYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynıYıldızınAltındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuSeansıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzayYolcularıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

