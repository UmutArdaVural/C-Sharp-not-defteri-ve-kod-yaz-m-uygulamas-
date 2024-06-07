namespace Ödev1_ndp
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            menuStrip1 = new MenuStrip();
            düzenleToolStripMenuItem = new ToolStripMenuItem();
            dosyaAçToolStripMenuItem = new ToolStripMenuItem();
            dosyaKaydetToolStripMenuItem = new ToolStripMenuItem();
            yeniDosyaAçToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem1 = new ToolStripMenuItem();
            yazıBoyutuToolStripMenuItem = new ToolStripMenuItem();
            yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            arkaPlanRengiToolStripMenuItem = new ToolStripMenuItem();
            metinBiçimiToolStripMenuItem = new ToolStripMenuItem();
            yazıBüyüklüğüToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            açılcakDosyaTürüToolStripMenuItem = new ToolStripMenuItem();
            notDefteritxtToolStripMenuItem = new ToolStripMenuItem();
            cKoducppToolStripMenuItem = new ToolStripMenuItem();
            cKoducsharpToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem1 = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            richTextBox1 = new RichTextBox();
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { düzenleToolStripMenuItem, ayarlarToolStripMenuItem, metinBiçimiToolStripMenuItem, açılcakDosyaTürüToolStripMenuItem, çıkışToolStripMenuItem, çıkışToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1114, 41);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // düzenleToolStripMenuItem
            // 
            düzenleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dosyaAçToolStripMenuItem, dosyaKaydetToolStripMenuItem, yeniDosyaAçToolStripMenuItem, yeniToolStripMenuItem });
            düzenleToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            düzenleToolStripMenuItem.Image = (Image)resources.GetObject("düzenleToolStripMenuItem.Image");
            düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            düzenleToolStripMenuItem.Size = new Size(85, 37);
            düzenleToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaAçToolStripMenuItem
            // 
            dosyaAçToolStripMenuItem.Image = (Image)resources.GetObject("dosyaAçToolStripMenuItem.Image");
            dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            dosyaAçToolStripMenuItem.Size = new Size(184, 26);
            dosyaAçToolStripMenuItem.Text = "Dosya Aç";
            dosyaAçToolStripMenuItem.Click += dosyaAçToolStripMenuItem_Click;
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            dosyaKaydetToolStripMenuItem.Image = (Image)resources.GetObject("dosyaKaydetToolStripMenuItem.Image");
            dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            dosyaKaydetToolStripMenuItem.Size = new Size(184, 26);
            dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            dosyaKaydetToolStripMenuItem.Click += dosyaKaydetToolStripMenuItem_Click;
            // 
            // yeniDosyaAçToolStripMenuItem
            // 
            yeniDosyaAçToolStripMenuItem.Image = (Image)resources.GetObject("yeniDosyaAçToolStripMenuItem.Image");
            yeniDosyaAçToolStripMenuItem.Name = "yeniDosyaAçToolStripMenuItem";
            yeniDosyaAçToolStripMenuItem.Size = new Size(184, 26);
            yeniDosyaAçToolStripMenuItem.Text = "Farklı Kaydet";
            yeniDosyaAçToolStripMenuItem.Click += yeniDosyaAçToolStripMenuItem_Click;
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Image = (Image)resources.GetObject("yeniToolStripMenuItem.Image");
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(184, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renkToolStripMenuItem1, yazıBoyutuToolStripMenuItem, yazıRengiToolStripMenuItem, arkaPlanRengiToolStripMenuItem });
            ayarlarToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ayarlarToolStripMenuItem.Image = (Image)resources.GetObject("ayarlarToolStripMenuItem.Image");
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(92, 37);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem1
            // 
            renkToolStripMenuItem1.Image = (Image)resources.GetObject("renkToolStripMenuItem1.Image");
            renkToolStripMenuItem1.Name = "renkToolStripMenuItem1";
            renkToolStripMenuItem1.Size = new Size(230, 26);
            renkToolStripMenuItem1.Text = "Font Ve Menü Rengi";
            renkToolStripMenuItem1.Click += renkToolStripMenuItem1_Click;
            // 
            // yazıBoyutuToolStripMenuItem
            // 
            yazıBoyutuToolStripMenuItem.Image = (Image)resources.GetObject("yazıBoyutuToolStripMenuItem.Image");
            yazıBoyutuToolStripMenuItem.Name = "yazıBoyutuToolStripMenuItem";
            yazıBoyutuToolStripMenuItem.Size = new Size(230, 26);
            yazıBoyutuToolStripMenuItem.Text = "Yazı Boyutu ve Biçimi";
            yazıBoyutuToolStripMenuItem.Click += yazıBoyutuToolStripMenuItem_Click;
            // 
            // yazıRengiToolStripMenuItem
            // 
            yazıRengiToolStripMenuItem.Image = (Image)resources.GetObject("yazıRengiToolStripMenuItem.Image");
            yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            yazıRengiToolStripMenuItem.Size = new Size(230, 26);
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            yazıRengiToolStripMenuItem.Click += yazıRengiToolStripMenuItem_Click;
            // 
            // arkaPlanRengiToolStripMenuItem
            // 
            arkaPlanRengiToolStripMenuItem.Image = (Image)resources.GetObject("arkaPlanRengiToolStripMenuItem.Image");
            arkaPlanRengiToolStripMenuItem.Name = "arkaPlanRengiToolStripMenuItem";
            arkaPlanRengiToolStripMenuItem.Size = new Size(230, 26);
            arkaPlanRengiToolStripMenuItem.Text = "Arka Plan Rengi";
            arkaPlanRengiToolStripMenuItem.Click += arkaPlanRengiToolStripMenuItem_Click;
            // 
            // metinBiçimiToolStripMenuItem
            // 
            metinBiçimiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıBüyüklüğüToolStripMenuItem, renkToolStripMenuItem, kesToolStripMenuItem });
            metinBiçimiToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            metinBiçimiToolStripMenuItem.Image = (Image)resources.GetObject("metinBiçimiToolStripMenuItem.Image");
            metinBiçimiToolStripMenuItem.Name = "metinBiçimiToolStripMenuItem";
            metinBiçimiToolStripMenuItem.Size = new Size(84, 37);
            metinBiçimiToolStripMenuItem.Text = " Biçim";
            metinBiçimiToolStripMenuItem.Click += metinBiçimiToolStripMenuItem_Click;
            // 
            // yazıBüyüklüğüToolStripMenuItem
            // 
            yazıBüyüklüğüToolStripMenuItem.Image = (Image)resources.GetObject("yazıBüyüklüğüToolStripMenuItem.Image");
            yazıBüyüklüğüToolStripMenuItem.Name = "yazıBüyüklüğüToolStripMenuItem";
            yazıBüyüklüğüToolStripMenuItem.Size = new Size(184, 26);
            yazıBüyüklüğüToolStripMenuItem.Text = "Kopyala";
            yazıBüyüklüğüToolStripMenuItem.Click += KopyalaToolStripMenuItem_Click;
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.Image = (Image)resources.GetObject("renkToolStripMenuItem.Image");
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(184, 26);
            renkToolStripMenuItem.Text = "Yapıştır";
            renkToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Image = (Image)resources.GetObject("kesToolStripMenuItem.Image");
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(184, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // açılcakDosyaTürüToolStripMenuItem
            // 
            açılcakDosyaTürüToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notDefteritxtToolStripMenuItem, cKoducppToolStripMenuItem, cKoducsharpToolStripMenuItem });
            açılcakDosyaTürüToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            açılcakDosyaTürüToolStripMenuItem.Image = (Image)resources.GetObject("açılcakDosyaTürüToolStripMenuItem.Image");
            açılcakDosyaTürüToolStripMenuItem.Name = "açılcakDosyaTürüToolStripMenuItem";
            açılcakDosyaTürüToolStripMenuItem.Size = new Size(173, 37);
            açılcakDosyaTürüToolStripMenuItem.Text = "Açılcak Dosya Türü";
            // 
            // notDefteritxtToolStripMenuItem
            // 
            notDefteritxtToolStripMenuItem.Image = (Image)resources.GetObject("notDefteritxtToolStripMenuItem.Image");
            notDefteritxtToolStripMenuItem.Name = "notDefteritxtToolStripMenuItem";
            notDefteritxtToolStripMenuItem.Size = new Size(197, 26);
            notDefteritxtToolStripMenuItem.Text = "Not Defteri (.txt)";
            notDefteritxtToolStripMenuItem.Click += notDefteritxtToolStripMenuItem_Click;
            // 
            // cKoducppToolStripMenuItem
            // 
            cKoducppToolStripMenuItem.Image = (Image)resources.GetObject("cKoducppToolStripMenuItem.Image");
            cKoducppToolStripMenuItem.Name = "cKoducppToolStripMenuItem";
            cKoducppToolStripMenuItem.Size = new Size(197, 26);
            cKoducppToolStripMenuItem.Text = "C++ kodu (.cpp)";
            cKoducppToolStripMenuItem.Click += cKoducppToolStripMenuItem_Click;
            // 
            // cKoducsharpToolStripMenuItem
            // 
            cKoducsharpToolStripMenuItem.Image = (Image)resources.GetObject("cKoducsharpToolStripMenuItem.Image");
            cKoducsharpToolStripMenuItem.Name = "cKoducsharpToolStripMenuItem";
            cKoducsharpToolStripMenuItem.Size = new Size(197, 26);
            cKoducsharpToolStripMenuItem.Text = "C# Kodu (.cs)";
            cKoducsharpToolStripMenuItem.Click += cKoducsharpToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            çıkışToolStripMenuItem.Image = (Image)resources.GetObject("çıkışToolStripMenuItem.Image");
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(75, 37);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem1
            // 
            çıkışToolStripMenuItem1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            çıkışToolStripMenuItem1.Image = (Image)resources.GetObject("çıkışToolStripMenuItem1.Image");
            çıkışToolStripMenuItem1.Name = "çıkışToolStripMenuItem1";
            çıkışToolStripMenuItem1.Size = new Size(135, 37);
            çıkışToolStripMenuItem1.Text = "Kaydet ve Çık";
            çıkışToolStripMenuItem1.Click += çıkışToolStripMenuItem1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Info;
            richTextBox1.Location = new Point(12, 52);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1084, 537);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(945, 591);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 3;
            label1.Text = "şeçili dosya türü";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1114, 618);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Y";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem düzenleToolStripMenuItem;
        private ToolStripMenuItem dosyaAçToolStripMenuItem;
        private ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private ToolStripMenuItem yeniDosyaAçToolStripMenuItem;
        private ToolStripMenuItem metinBiçimiToolStripMenuItem;
        private ToolStripMenuItem yazıBüyüklüğüToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem1;
        private ToolStripMenuItem yazıBoyutuToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox richTextBox1;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem çıkışToolStripMenuItem1;
        private ToolStripMenuItem açılcakDosyaTürüToolStripMenuItem;
        private ToolStripMenuItem notDefteritxtToolStripMenuItem;
        private ToolStripMenuItem cKoducppToolStripMenuItem;
        private ToolStripMenuItem cKoducsharpToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripMenuItem arkaPlanRengiToolStripMenuItem;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem yeniToolStripMenuItem;
    }
}