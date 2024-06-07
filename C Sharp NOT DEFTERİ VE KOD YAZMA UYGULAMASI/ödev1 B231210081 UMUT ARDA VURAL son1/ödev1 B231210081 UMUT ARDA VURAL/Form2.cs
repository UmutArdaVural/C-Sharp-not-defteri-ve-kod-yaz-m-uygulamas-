/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: UMUT ARDA VURAL
**				ÖĞRENCİ NUMARASI.......: B231210081
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/
// ödev hakkında !!!  kullanıcı hangi şablonu şeçtiyse o dosya türünü açabilir 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
// using static System.Net.Mime.MediaTypeNames; sistem kendi kendine eklemeiş hataverdiği için yorum satırı olarak kapattım 
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;


namespace Ödev1_ndp
{
    public partial class Form2 : Form
    {
        string kaydedilecek = "";
        bool txtdedoğrumu = true; // bu üçü  hangi dosya türü açıldığını filtrelemek için  ve c++ ve c# için hazır şablon kullanması için bool değeri oluşturdum bool değerlerine göre timer sağ altta hangi dosya türünde olduğunu göstericek 
        bool cplusdoğrumu = false;
        bool csharpdoğrumu = false;



        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("Başlangıç Dosya Türü metin dosyası (.txt)  seçilmiştir dosya türünden değiştirebilirsiniz ");
            timer1.Start(); // sağ altda hangi dosya türü olucağını kontrol eden bool değerli için timer kullandım kullanıcı hangi dosya türünde olduğunu bilmesi için 


        }


        private void metinBiçimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void dosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (txtdedoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "Metin Belgesi Açma";  // sol üsteki başlık kısmında gözükçek başlık        
                dosyaaç.Filter = "Metin Dosyaları |* .txt"; // sadece txt dosyayı açılsın hata ile karşı karşıya kalınmasın diye !!! soldakide sağ tarafta yazıcak yazı  

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }
            }
            if (cplusdoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "C++ Dosyaları "; // sol üsteki başlık kısmında gözükçek başlık 
                dosyaaç.Filter = "C++ Dosyaları |* .cpp"; // sadece cpp dosyayı açılsın hata ile karşı karşıya kalınmasın diye soldakide !!! sağ tarafta yazıcak yazı 

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }


            }
            if (csharpdoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "C# Dosyaları ";  // sol üsteki başlık kısmında gözükçek başlık 
                dosyaaç.Filter = "C# Dosyaları |* .cs"; // sadece .cs dosyayı açılsın hata ile karşı karşıya kalınmasın diye  soldakide sağ tarafta yazıcak yazı 

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }


            }
        }

        private void yazıBoyutuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontumuz = new FontDialog();
            if (fontumuz.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontumuz.Font; //// selection yaparak sonradan yazılcaklarfontu değişir ödev dosyasındaki örnek bu şekildeydi  
            }
        }

        private void renkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog rengimizyazı = new ColorDialog();

            if (rengimizyazı.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = rengimizyazı.Color;
                menuStrip1.BackColor = rengimizyazı.Color;

            }

        }


        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Kaydet();
        }


        private void FarklıKaydet()
        {
            SaveFileDialog DosyaKaydet = new SaveFileDialog();
            if (cplusdoğrumu == true)
            {
                DosyaKaydet.Filter = "cpp files |*.cpp";

                if (DosyaKaydet.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(DosyaKaydet.FileName, richTextBox1.Text);
                    kaydedilecek = DosyaKaydet.FileName;
                }
            }
            else if (txtdedoğrumu== true)
            {
                DosyaKaydet.Filter = "txt files |*.txt";
                if (DosyaKaydet.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(DosyaKaydet.FileName, richTextBox1.Text);
                    kaydedilecek = DosyaKaydet.FileName;
                }

            }
            else if (csharpdoğrumu==true)
            {
                DosyaKaydet.Filter = "c# files |*.cs";
                if (DosyaKaydet.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(DosyaKaydet.FileName, richTextBox1.Text);
                    kaydedilecek = DosyaKaydet.FileName;
                }
            }


        }
        private void Kaydet()
        {
            if (kaydedilecek == "")
            {
                FarklıKaydet();
            }
            else
            {
                File.WriteAllText(kaydedilecek, richTextBox1.Text);
            }
        }



        private void KopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();

        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void yeniDosyaAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarklıKaydet();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kaydedilecek == "" && richTextBox1.Text.Length > 0)
            {
                FarklıKaydet();
                Application.Exit();

            }
            else if (kaydedilecek != "")
            {
                File.WriteAllText(kaydedilecek, richTextBox1.Text);
                Application.Exit();

            }
            else
            {
                Application.Exit();
            }
        }

        private void notDefteritxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtdedoğrumu = true;
            cplusdoğrumu = false;
            csharpdoğrumu = false;
            richTextBox1.Text = "";
            kaydedilecek = "";
        }

        private void cKoducppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtdedoğrumu = false;
            cplusdoğrumu = true;
            csharpdoğrumu = false;
            richTextBox1.Text = "include<iostream>" + Environment.NewLine + "using namespace std ;" + Environment.NewLine + "int main () " + Environment.NewLine + "  {" + Environment.NewLine + " int yas= 18 ;" + Environment.NewLine + "  cout<<yas<<endl ; " + Environment.NewLine + "  }";
            kaydedilecek = "";
        }

        private void cKoducsharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtdedoğrumu = false;
            cplusdoğrumu = false;
            csharpdoğrumu = true;
            richTextBox1.Text = "using System;" + Environment.NewLine + "namespace basitornek" + Environment.NewLine + "{" + Environment.NewLine + " class Program  // sınıf tanımlaması" + Environment.NewLine + "  {" + Environment.NewLine + "   static void Main(string[] args)" + Environment.NewLine + "    {" + Environment.NewLine + "     Console.WriteLine(\" Merhaba Millet”);" + Environment.NewLine + "    }" + Environment.NewLine + "   }" + Environment.NewLine + "}";
            kaydedilecek = "";

        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog rengimiz = new ColorDialog();

            if (rengimiz.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = rengimiz.Color; // selection yaparak sonradan yazılcaklar rengi değişir ödev dosyasındaki örnek bu şekildeydi   
            }
        }

        private void arkaPlanRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog rengimiz = new ColorDialog();

            if (rengimiz.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = rengimiz.Color;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtdedoğrumu == true)
            {
                label1.Text = ".txt Dosya Türü Seçili ";
            }
            if (cplusdoğrumu == true)
            {
                label1.Text = ".cpp Dosya Türü Seçili ";
            }
            if (csharpdoğrumu == true)
            {
                label1.Text = ".cs Dosya Türü Seçili ";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (txtdedoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "Metin Belgesi Açma";  // sol üsteki başlık kısmında gözükçek başlık        
                dosyaaç.Filter = "Metin Dosyaları |* .txt"; // sadece txt dosyayı açılsın hata ile karşı karşıya kalınmasın diye !!! soldakide sağ tarafta yazıcak yazı  

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }
            }
            if (cplusdoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "C++ Dosyaları "; // sol üsteki başlık kısmında gözükçek başlık 
                dosyaaç.Filter = "C++ Dosyaları |* .cpp"; // sadece cpp dosyayı açılsın hata ile karşı karşıya kalınmasın diye soldakide !!! sağ tarafta yazıcak yazı 

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }


            }
            if (csharpdoğrumu == true)
            {
                OpenFileDialog dosyaaç = new OpenFileDialog();
                dosyaaç.Title = "C# Dosyaları ";  // sol üsteki başlık kısmında gözükçek başlık 
                dosyaaç.Filter = "C# Dosyaları |* .cs"; // sadece .cs dosyayı açılsın hata ile karşı karşıya kalınmasın diye  soldakide sağ tarafta yazıcak yazı 

                if (dosyaaç.ShowDialog() == DialogResult.OK)
                {
                    kaydedilecek = dosyaaç.FileName;
                    string dosyayıoku = File.ReadAllText(dosyaaç.FileName);
                    richTextBox1.Text = dosyayıoku;
                }


            }
        }
    }
}

