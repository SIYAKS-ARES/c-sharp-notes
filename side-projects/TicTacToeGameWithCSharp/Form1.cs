using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGameWithCSharp
{
    public partial class Form1 : Form
    {
        // Oyuncu sınıfı aşağıda belirtilmiştir. X ve O değerleri vardır.
        // Bu şekilde oyuncu ve yapay zeka sembollerini kontrol edebiliriz.
        public enum Oyuncu
        {
            X, O
        }

        Oyuncu suankiOyuncu; // Oyuncu sınıfını çağırıyoruz
        List<Button> buttons; // Butonları liste (array) olarak oluşturuyoruz
        Random random = new Random(); // Rastgele sayı üreteci sınıfını kullanıyoruz
        int oyuncuKazanma = 0; // Oyuncu kazanma sayısı sıfır olarak ayarlanır
        int bilgisayarKazanma = 0; // Bilgisayar kazanma sayısı sıfır olarak ayarlanır
        Timer yapayZekaHamleleri; // Yapay zekâ hamleleri için bir zamanlayıcı (timer)

        public Form1()
        {
            InitializeComponent();
            OyunuTekrarBaslat(); // Oyunu başlatan fonksiyonu çağırır
            YapayZekaZamanlayicisiniAyarla(); // Zamanlayıcıyı ayarla
        }

        private void YapayZekaZamanlayicisiniAyarla()
        {
            yapayZekaHamleleri = new Timer
            {
                Interval = 1000 // 1 saniyelik zamanlayıcı
            };
            yapayZekaHamleleri.Tick += BilgisayarOynar; // Tick olayında BilgisayarOynar metodunu çağırır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OyuncuTiklamaButonu(object sender, EventArgs e)
        {
            var button = (Button)sender; // Hangi butona tıklandığını bulur
            suankiOyuncu = Oyuncu.X; // Oyuncuyu X olarak ayarlar
            button.Text = suankiOyuncu.ToString(); // Butonun metnini X olarak değiştirir
            button.Enabled = false; // Butonu devre dışı bırakır
            button.BackColor = System.Drawing.Color.Cyan; // Oyuncunun rengini Mavi olarak değiştirir
            buttons.Remove(button); // Butonu listeden kaldırarak yapay zekânın seçememesini sağlar
            OyunuKontrolEt(); // Oyuncunun kazanıp kazanmadığını kontrol eder
            yapayZekaHamleleri.Start(); // Yapay zekâ zamanlayıcısını başlatır
        }

        private void BilgisayarOynar(object sender, EventArgs e)
        {
            // Yapay zekâ, buton listesinden rastgele bir seçim yapacak.
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count); // Mevcut buton sayısı içinde rastgele bir sayı üretir
                buttons[index].Enabled = false; // Üretilen sayıya göre butonu seçer
                suankiOyuncu = Oyuncu.O; // Yapay zekâyı O olarak ayarlar
                buttons[index].Text = suankiOyuncu.ToString(); // Butona O yazar
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // Butonun rengini Koyu Somon yapar
                buttons.RemoveAt(index); // O butonu listeden çıkarır
                OyunuKontrolEt(); // Yapay zekânın kazanıp kazanmadığını kontrol eder
                yapayZekaHamleleri.Stop(); // Yapay zekâ zamanlayıcısını durdurur
            }
        }

        private void OyunuBastanBaslat(object sender, EventArgs e)
        {
            // Bu fonksiyon sıfırla butonuna bağlıdır.
            OyunuTekrarBaslat();
        }

        private void ButonlariYukle()
        {
            // Bu özel fonksiyon formdaki butonları butonlar listesine yükler
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }

        private void OyunuTekrarBaslat()
        {
            // 'oyna' etiketi olan tüm butonları kontrol eder
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "oyna")
                {
                    ((Button)X).Enabled = true; // Tüm butonları etkinleştirir
                    //((Button)X).Text = "?"; // Butonun metnini soru işaretine çevirir
                    ((Button)X).BackColor = default; // Buton rengini varsayılana çevirir
                }
            }
            ButonlariYukle(); // Butonları listeye yeniden ekler
        }

        private void OyunuKontrolEt()
        {
            // Bu fonksiyon oyuncunun ya da yapay zekânın kazanıp kazanmadığını kontrol eder
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                yapayZekaHamleleri.Stop(); // Zamanlayıcıyı durdurur
                MessageBox.Show("Oyuncu Kazandı"); // Oyuncunun kazandığını gösterir
                oyuncuKazanma++; // Oyuncunun kazandığı oyun sayısını artırır
                label1.Text = "Oyuncu Kazanma: " + oyuncuKazanma; // Oyuncu kazançlarını günceller
                OyunuTekrarBaslat(); // Oyunu sıfırlar
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                  || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                  || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
                  || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                  || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                  || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                  || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                  || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                yapayZekaHamleleri.Stop(); // Zamanlayıcıyı durdurur
                MessageBox.Show("Bilgisayar Kazandı"); // Bilgisayarın kazandığını gösterir
                bilgisayarKazanma++; // Bilgisayarın kazandığı oyun sayısını artırır
                label2.Text = "Bilgisayar Kazanma: " + bilgisayarKazanma; // Bilgisayar kazançlarını günceller
                OyunuTekrarBaslat(); // Oyunu sıfırlar
            }
        }
    }
}
