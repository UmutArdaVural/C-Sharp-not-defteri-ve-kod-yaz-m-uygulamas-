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
// animasyonlu  açılış ekranı yaptım onun kodları //  ödevin kodları form2 de  başlıyor 

using Ödev1_ndp;

namespace ödev1_çalışan

    // animasyonlu  açılış ekranı yaptım onun kodları //  ödevin kodları form2 de  başlıyor 
{
    public partial class Form1 : Form
    { // burda uygulamaya açılış ekranı koymak için ayarlama yaptım timer kullanarak //
        int sayaç = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayaç++;
            if (sayaç == 2)
            {
                pictureBox1.Enabled = false;

                Form2 form2aç = new Form2();
                form2aç.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
