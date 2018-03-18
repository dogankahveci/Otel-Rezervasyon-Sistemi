namespace OtelRezarvasyon.WinFormUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.odaEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomerListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaİşlemleriToolStripMenuItem1,
            this.musteriIslemleriToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.ayarlarToolStripMenuItem.Text = "KAYIT İŞLEMLERİ";
            // 
            // odaİşlemleriToolStripMenuItem1
            // 
            this.odaİşlemleriToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaEkleToolStripMenuItem,
            this.odaGörüntüleToolStripMenuItem});
            this.odaİşlemleriToolStripMenuItem1.Name = "odaİşlemleriToolStripMenuItem1";
            this.odaİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.odaİşlemleriToolStripMenuItem1.Text = "Oda İşlemleri";
            // 
            // odaEkleToolStripMenuItem
            // 
            this.odaEkleToolStripMenuItem.Name = "odaEkleToolStripMenuItem";
            this.odaEkleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.odaEkleToolStripMenuItem.Text = "Oda Ekle";
            this.odaEkleToolStripMenuItem.Click += new System.EventHandler(this.odaEkleToolStripMenuItem_Click);
            // 
            // odaGörüntüleToolStripMenuItem
            // 
            this.odaGörüntüleToolStripMenuItem.Name = "odaGörüntüleToolStripMenuItem";
            this.odaGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.odaGörüntüleToolStripMenuItem.Text = "Oda Listele";
            this.odaGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.odaGörüntüleToolStripMenuItem_Click);
            // 
            // musteriIslemleriToolStripMenuItem
            // 
            this.musteriIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CustomerAddToolStripMenuItem,
            this.CustomerListToolStripMenuItem});
            this.musteriIslemleriToolStripMenuItem.Name = "musteriIslemleriToolStripMenuItem";
            this.musteriIslemleriToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.musteriIslemleriToolStripMenuItem.Text = "MusteriIslemleri";
            this.musteriIslemleriToolStripMenuItem.Click += new System.EventHandler(this.üyeEkleToolStripMenuItem_Click);
            // 
            // CustomerAddToolStripMenuItem
            // 
            this.CustomerAddToolStripMenuItem.Name = "CustomerAddToolStripMenuItem";
            this.CustomerAddToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CustomerAddToolStripMenuItem.Text = "Müşteri Ekle";
            this.CustomerAddToolStripMenuItem.Click += new System.EventHandler(this.CustomerAddToolStripMenuItem_Click);
            // 
            // CustomerListToolStripMenuItem
            // 
            this.CustomerListToolStripMenuItem.Name = "CustomerListToolStripMenuItem";
            this.CustomerListToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.CustomerListToolStripMenuItem.Text = "Müşteri Listele";
            this.CustomerListToolStripMenuItem.Click += new System.EventHandler(this.CustomerListToolStripMenuItem_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonYapToolStripMenuItem,
            this.rezervasyonGörüntüleToolStripMenuItem});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.satışİşlemleriToolStripMenuItem.Text = "SATIŞ İŞLEMLERİ";
            // 
            // rezervasyonYapToolStripMenuItem
            // 
            this.rezervasyonYapToolStripMenuItem.Name = "rezervasyonYapToolStripMenuItem";
            this.rezervasyonYapToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rezervasyonYapToolStripMenuItem.Text = "Rezervasyon Yap";
            this.rezervasyonYapToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonYapToolStripMenuItem_Click);
            // 
            // rezervasyonGörüntüleToolStripMenuItem
            // 
            this.rezervasyonGörüntüleToolStripMenuItem.Name = "rezervasyonGörüntüleToolStripMenuItem";
            this.rezervasyonGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rezervasyonGörüntüleToolStripMenuItem.Text = "Rezervasyon Görüntüle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 424);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "OTEL REZARVASYON ANASAYFA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaİşlemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem odaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CustomerListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonGörüntüleToolStripMenuItem;
    }
}

