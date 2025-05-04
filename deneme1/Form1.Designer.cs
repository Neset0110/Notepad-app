namespace deneme1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            richTextBox1 = new RichTextBox();
            panel2 = new Panel();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            dosyaToolStripMenuItem1 = new ToolStripMenuItem();
            açToolStripMenuItem = new ToolStripMenuItem();
            farklıKayderToolStripMenuItem = new ToolStripMenuItem();
            kaydetToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            yazdırToolStripMenuItem = new ToolStripMenuItem();
            çıkışYapToolStripMenuItem = new ToolStripMenuItem();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            kopyalToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            hepsiniSilToolStripMenuItem = new ToolStripMenuItem();
            hepsiniSeçToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tarihZamanToolStripMenuItem = new ToolStripMenuItem();
            yazıToolStripMenuItem = new ToolStripMenuItem();
            fontToolStripMenuItem = new ToolStripMenuItem();
            satırAtlamaToolStripMenuItem = new ToolStripMenuItem();
            açıkToolStripMenuItem = new ToolStripMenuItem();
            kapalıToolStripMenuItem = new ToolStripMenuItem();
            hakkındaToolStripMenuItem = new ToolStripMenuItem();
            görünümToolStripMenuItem = new ToolStripMenuItem();
            karanlıkTemaToolStripMenuItem = new ToolStripMenuItem();
            aydınlıkTemaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "‎ " });
            listBox1.Location = new Point(0, 94);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 1000);
            listBox1.TabIndex = 4;
            listBox1.MouseDoubleClick += listBox1_MouseDoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Window;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            richTextBox1.Location = new Point(213, 74);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            richTextBox1.Size = new Size(939, 1020);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuBar;
            panel2.Controls.Add(menuStrip1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(213, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 1091);
            panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 15F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, düzenleToolStripMenuItem, yazıToolStripMenuItem, hakkındaToolStripMenuItem, görünümToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(939, 43);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem1, açToolStripMenuItem, farklıKayderToolStripMenuItem, kaydetToolStripMenuItem, silToolStripMenuItem, güncelleToolStripMenuItem, toolStripSeparator1, yazdırToolStripMenuItem, çıkışYapToolStripMenuItem });
            dosyaToolStripMenuItem.Image = (Image)resources.GetObject("dosyaToolStripMenuItem.Image");
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(118, 39);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaToolStripMenuItem1
            // 
            dosyaToolStripMenuItem1.Image = (Image)resources.GetObject("dosyaToolStripMenuItem1.Image");
            dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            dosyaToolStripMenuItem1.Size = new Size(244, 40);
            dosyaToolStripMenuItem1.Text = "Yeni";
            dosyaToolStripMenuItem1.Click += dosyaToolStripMenuItem1_Click;
            // 
            // açToolStripMenuItem
            // 
            açToolStripMenuItem.Image = (Image)resources.GetObject("açToolStripMenuItem.Image");
            açToolStripMenuItem.Name = "açToolStripMenuItem";
            açToolStripMenuItem.Size = new Size(244, 40);
            açToolStripMenuItem.Text = "Aç";
            açToolStripMenuItem.Click += açToolStripMenuItem_Click;
            // 
            // farklıKayderToolStripMenuItem
            // 
            farklıKayderToolStripMenuItem.Image = (Image)resources.GetObject("farklıKayderToolStripMenuItem.Image");
            farklıKayderToolStripMenuItem.Name = "farklıKayderToolStripMenuItem";
            farklıKayderToolStripMenuItem.Size = new Size(244, 40);
            farklıKayderToolStripMenuItem.Text = "Farklı Kaydet";
            farklıKayderToolStripMenuItem.Click += farklıKayderToolStripMenuItem_Click;
            // 
            // kaydetToolStripMenuItem
            // 
            kaydetToolStripMenuItem.Image = (Image)resources.GetObject("kaydetToolStripMenuItem.Image");
            kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            kaydetToolStripMenuItem.Size = new Size(244, 40);
            kaydetToolStripMenuItem.Text = "Kaydet";
            kaydetToolStripMenuItem.Click += kaydetToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Image = (Image)resources.GetObject("silToolStripMenuItem.Image");
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(244, 40);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Image = (Image)resources.GetObject("güncelleToolStripMenuItem.Image");
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(244, 40);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(241, 6);
            // 
            // yazdırToolStripMenuItem
            // 
            yazdırToolStripMenuItem.Image = (Image)resources.GetObject("yazdırToolStripMenuItem.Image");
            yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            yazdırToolStripMenuItem.Size = new Size(244, 40);
            yazdırToolStripMenuItem.Text = "Yazdır";
            yazdırToolStripMenuItem.Click += yazdırToolStripMenuItem_Click;
            // 
            // çıkışYapToolStripMenuItem
            // 
            çıkışYapToolStripMenuItem.Image = (Image)resources.GetObject("çıkışYapToolStripMenuItem.Image");
            çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            çıkışYapToolStripMenuItem.Size = new Size(244, 40);
            çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            çıkışYapToolStripMenuItem.Click += çıkışYapToolStripMenuItem_Click;
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kopyalToolStripMenuItem, kesToolStripMenuItem, yapıştırToolStripMenuItem, toolStripSeparator2, hepsiniSilToolStripMenuItem, hepsiniSeçToolStripMenuItem, toolStripSeparator3, tarihZamanToolStripMenuItem });
            düzenleToolStripMenuItem.Image = (Image)resources.GetObject("düzenleToolStripMenuItem.Image");
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(138, 39);
            düzenleToolStripMenuItem.Text = "Düzenle";
            // 
            // kopyalToolStripMenuItem
            // 
            kopyalToolStripMenuItem.Image = (Image)resources.GetObject("kopyalToolStripMenuItem.Image");
            kopyalToolStripMenuItem.Name = "kopyalToolStripMenuItem";
            kopyalToolStripMenuItem.Size = new Size(242, 40);
            kopyalToolStripMenuItem.Text = "Kopyala";
            kopyalToolStripMenuItem.Click += kopyalToolStripMenuItem_Click;
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Image = (Image)resources.GetObject("kesToolStripMenuItem.Image");
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(242, 40);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Image = (Image)resources.GetObject("yapıştırToolStripMenuItem.Image");
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(242, 40);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(239, 6);
            // 
            // hepsiniSilToolStripMenuItem
            // 
            hepsiniSilToolStripMenuItem.Image = (Image)resources.GetObject("hepsiniSilToolStripMenuItem.Image");
            hepsiniSilToolStripMenuItem.Name = "hepsiniSilToolStripMenuItem";
            hepsiniSilToolStripMenuItem.Size = new Size(242, 40);
            hepsiniSilToolStripMenuItem.Text = "Hepsini Sil";
            hepsiniSilToolStripMenuItem.Click += hepsiniSilToolStripMenuItem_Click;
            // 
            // hepsiniSeçToolStripMenuItem
            // 
            hepsiniSeçToolStripMenuItem.Image = (Image)resources.GetObject("hepsiniSeçToolStripMenuItem.Image");
            hepsiniSeçToolStripMenuItem.Name = "hepsiniSeçToolStripMenuItem";
            hepsiniSeçToolStripMenuItem.Size = new Size(242, 40);
            hepsiniSeçToolStripMenuItem.Text = "Hepsini Seç";
            hepsiniSeçToolStripMenuItem.Click += hepsiniSeçToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(239, 6);
            // 
            // tarihZamanToolStripMenuItem
            // 
            tarihZamanToolStripMenuItem.Image = (Image)resources.GetObject("tarihZamanToolStripMenuItem.Image");
            tarihZamanToolStripMenuItem.Name = "tarihZamanToolStripMenuItem";
            tarihZamanToolStripMenuItem.Size = new Size(242, 40);
            tarihZamanToolStripMenuItem.Text = "Tarih/Zaman";
            tarihZamanToolStripMenuItem.Click += tarihZamanToolStripMenuItem_Click;
            // 
            // yazıToolStripMenuItem
            // 
            yazıToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fontToolStripMenuItem, satırAtlamaToolStripMenuItem });
            yazıToolStripMenuItem.Image = (Image)resources.GetObject("yazıToolStripMenuItem.Image");
            yazıToolStripMenuItem.Name = "yazıToolStripMenuItem";
            yazıToolStripMenuItem.Size = new Size(91, 39);
            yazıToolStripMenuItem.Text = "Yazı";
            // 
            // fontToolStripMenuItem
            // 
            fontToolStripMenuItem.Image = (Image)resources.GetObject("fontToolStripMenuItem.Image");
            fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            fontToolStripMenuItem.Size = new Size(238, 40);
            fontToolStripMenuItem.Text = "Font";
            fontToolStripMenuItem.Click += fontToolStripMenuItem_Click;
            // 
            // satırAtlamaToolStripMenuItem
            // 
            satırAtlamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { açıkToolStripMenuItem, kapalıToolStripMenuItem });
            satırAtlamaToolStripMenuItem.Image = (Image)resources.GetObject("satırAtlamaToolStripMenuItem.Image");
            satırAtlamaToolStripMenuItem.Name = "satırAtlamaToolStripMenuItem";
            satırAtlamaToolStripMenuItem.Size = new Size(238, 40);
            satırAtlamaToolStripMenuItem.Text = "Satır Atlama";
            // 
            // açıkToolStripMenuItem
            // 
            açıkToolStripMenuItem.Image = (Image)resources.GetObject("açıkToolStripMenuItem.Image");
            açıkToolStripMenuItem.Name = "açıkToolStripMenuItem";
            açıkToolStripMenuItem.Size = new Size(172, 40);
            açıkToolStripMenuItem.Text = "Açık";
            açıkToolStripMenuItem.Click += açıkToolStripMenuItem_Click;
            // 
            // kapalıToolStripMenuItem
            // 
            kapalıToolStripMenuItem.Image = (Image)resources.GetObject("kapalıToolStripMenuItem.Image");
            kapalıToolStripMenuItem.Name = "kapalıToolStripMenuItem";
            kapalıToolStripMenuItem.Size = new Size(172, 40);
            kapalıToolStripMenuItem.Text = "Kapalı";
            kapalıToolStripMenuItem.Click += kapalıToolStripMenuItem_Click;
            // 
            // hakkındaToolStripMenuItem
            // 
            hakkındaToolStripMenuItem.Image = (Image)resources.GetObject("hakkındaToolStripMenuItem.Image");
            hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            hakkındaToolStripMenuItem.Size = new Size(126, 39);
            hakkındaToolStripMenuItem.Text = "Yardım";
            hakkındaToolStripMenuItem.Click += hakkındaToolStripMenuItem_Click;
            // 
            // görünümToolStripMenuItem
            // 
            görünümToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { karanlıkTemaToolStripMenuItem, aydınlıkTemaToolStripMenuItem });
            görünümToolStripMenuItem.Image = (Image)resources.GetObject("görünümToolStripMenuItem.Image");
            görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            görünümToolStripMenuItem.Size = new Size(154, 39);
            görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // karanlıkTemaToolStripMenuItem
            // 
            karanlıkTemaToolStripMenuItem.Image = (Image)resources.GetObject("karanlıkTemaToolStripMenuItem.Image");
            karanlıkTemaToolStripMenuItem.Name = "karanlıkTemaToolStripMenuItem";
            karanlıkTemaToolStripMenuItem.Size = new Size(258, 40);
            karanlıkTemaToolStripMenuItem.Text = "Karanlık Tema";
            karanlıkTemaToolStripMenuItem.Click += karanlıkTemaToolStripMenuItem_Click;
            // 
            // aydınlıkTemaToolStripMenuItem
            // 
            aydınlıkTemaToolStripMenuItem.Image = (Image)resources.GetObject("aydınlıkTemaToolStripMenuItem.Image");
            aydınlıkTemaToolStripMenuItem.Name = "aydınlıkTemaToolStripMenuItem";
            aydınlıkTemaToolStripMenuItem.Size = new Size(258, 40);
            aydınlıkTemaToolStripMenuItem.Text = "Aydınlık Tema";
            aydınlıkTemaToolStripMenuItem.Click += aydınlıkTemaToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1152, 1091);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(1170, 1138);
            MinimumSize = new Size(1095, 601);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox pictureBox1;
        private ListBox listBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem dosyaToolStripMenuItem1;
        private ToolStripMenuItem açToolStripMenuItem;
        private ToolStripMenuItem farklıKayderToolStripMenuItem;
        private ToolStripMenuItem kaydetToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem yazdırToolStripMenuItem;
        private ToolStripMenuItem çıkışYapToolStripMenuItem;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem kopyalToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem hepsiniSilToolStripMenuItem;
        private ToolStripMenuItem hepsiniSeçToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tarihZamanToolStripMenuItem;
        private ToolStripMenuItem yazıToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem satırAtlamaToolStripMenuItem;
        private ToolStripMenuItem açıkToolStripMenuItem;
        private ToolStripMenuItem kapalıToolStripMenuItem;
        private ToolStripMenuItem hakkındaToolStripMenuItem;
        private ToolStripMenuItem görünümToolStripMenuItem;
        private ToolStripMenuItem karanlıkTemaToolStripMenuItem;
        private ToolStripMenuItem aydınlıkTemaToolStripMenuItem;
    }
}
