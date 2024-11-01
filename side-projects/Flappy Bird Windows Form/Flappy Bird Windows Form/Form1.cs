using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
// using System.Media; // Ses eklemek için gerekli kütüphane
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {
        // Değişkenler burada başlar
        int boruHizi = 8; // Varsayılan boru hızı
        int yercekimi = 15; // Varsayılan yerçekimi
        int puan = 0; // Varsayılan puan
        bool oyunBasladi = false; // Oyunun başlangıç durumu kontrolü

        /*
        SoundPlayer kanatSesi = new SoundPlayer("flap.wav"); // Kanat sesi
        SoundPlayer carpismaSesi = new SoundPlayer("hit.wav"); // Çarpma sesi
        SoundPlayer puanSesi = new SoundPlayer("score.wav"); // Puan alma sesi
        SoundPlayer oyunBittiSesi = new SoundPlayer("gameover.wav"); // Oyun sonu sesi

         */
        public Form1()
        {
            InitializeComponent();
            oyunZamani.Stop(); // Oyun başlangıçta durdurulmuş olacak
            BaslangicEkrani(); // Başlangıç ekranını göster
        }

        private void tusBasildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && oyunBasladi)
            {
                yercekimi = -15; // Kuş yukarı çıkmaya başlar
                //kanatSesi.Play(); // Kanat sesini çal
            }

            if (e.KeyCode == Keys.Space && !oyunBasladi)
            {
                OyunuBaslat(); // Oyun henüz başlamamışsa başlat
            }
        }

        private void tusBirakildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yercekimi = 15; // Kuş tekrar aşağı düşer
            }
        }

        private void BaslangicEkrani()
        {
            // Başlangıç ekranı ayarları
            puanMetni.Text = "Başlamak için BOŞLUK tuşuna basın";
            kus.Visible = false;
            altBoru.Visible = false;
            ustBoru.Visible = false;
            zemin.Visible = false;
        }

        private void OyunuBaslat()
        {
            // Oyunu başlat
            oyunBasladi = true;
            puan = 0;
            yercekimi = 15;
            boruHizi = 8;
            kus.Top = 228;
            altBoru.Left = 800;
            ustBoru.Left = 950;
            oyunZamani.Start();
            kus.Visible = true;
            altBoru.Visible = true;
            ustBoru.Visible = true;
            zemin.Visible = true;
            puanMetni.Text = "Puan: 0";
        }

        private void OyunuBitir()
        {
            oyunZamani.Stop(); // Zamanlayıcı durur
            //oyunBittiSesi.Play(); // Oyun sonu sesi çal
            puanMetni.Text += " Oyun bitti!!! Yeniden başlatmak için r'ye bas"; // Oyun bitti mesajı
        }

        private void oyunZamaniEtkinlik(object sender, EventArgs e)
        {
            kus.Top += yercekimi; // Kuşun hareketi
            altBoru.Left -= boruHizi; // Boruların hareketi
            ustBoru.Left -= boruHizi;

            // Puanı göster
            puanMetni.Text = "Puan: " + puan;

            // Borular ekrandan çıkarsa
            if (altBoru.Left < -150)
            {
                altBoru.Left = 800;
                puan++;
                // puanSesi.Play(); // Puan sesi çal
            }
            if (ustBoru.Left < -180)
            {
                ustBoru.Left = 950;
                puan++;
                //puanSesi.Play();
            }

            // Çarpışma kontrolü
            if (kus.Bounds.IntersectsWith(altBoru.Bounds) ||
                kus.Bounds.IntersectsWith(ustBoru.Bounds) ||
                kus.Bounds.IntersectsWith(zemin.Bounds) ||
                kus.Top < -25)
            {
                //carpismaSesi.Play(); // Çarpma sesi çal
                OyunuBitir(); // Oyunu bitir
            }

            // Puan 5'i geçerse boru hızı artar
            if (puan > 5)
            {
                boruHizi = 15;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' && !oyunBasladi)
            {
                OyunuBaslat(); // 'a' tuşuna basılırsa oyun yeniden başlar
            }
        }
    }
}
