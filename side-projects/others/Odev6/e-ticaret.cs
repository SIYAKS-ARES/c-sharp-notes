using System;
using System.Collections.Generic;

// Ürün sınıfı (Temel sınıf)
public class Urun
{
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public decimal Fiyat { get; set; }
    public bool Satilabilir { get; set; }

    public virtual void BilgileriYazdir()
    {
        Console.WriteLine($"Ürün Adı: {Ad}");
        Console.WriteLine($"Açıklama: {Aciklama}");
        Console.WriteLine($"Fiyat: {Fiyat} TL");
        Console.WriteLine($"Satılabilir: {Satilabilir}");
    }
}

// Fiziksel Ürün sınıfı, Urun sınıfından türetilmiştir
public class FizikselUrun : Urun
{
    public double Ağırlık { get; set; }
    public string Boyutlar { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"Ağırlık: {Ağırlık} kg");
        Console.WriteLine($"Boyutlar: {Boyutlar}");
    }
}

// Dijital Ürün sınıfı, Urun sınıfından türetilmiştir
public class DijitalUrun : Urun
{
    public string DosyaFormat { get; set; }
    public string IndirmeLinki { get; set; }

    public override void BilgileriYazdir()
    {
        base.BilgileriYazdir();
        Console.WriteLine($"Dosya Formatı: {DosyaFormat}");
        Console.WriteLine($"İndirme Linki: {IndirmeLinki}");
    }
}

// Sipariş sınıfı
public class Siparis
{
    public int SiparisNo { get; set; }
    public List<Urun> Urunler { get; set; }
    public string Durum { get; set; }
    public decimal ToplamTutar { get; set; }

    public void SiparisHesapla()
    {
        ToplamTutar = 0;
        foreach (var urun in Urunler)
        {
            ToplamTutar += urun.Fiyat;
        }
    }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Sipariş Numarası: {SiparisNo}");
        Console.WriteLine($"Sipariş Durumu: {Durum}");
        Console.WriteLine($"Toplam Tutar: {ToplamTutar} TL");
        Console.WriteLine("Sipariş Ürünleri:");
        foreach (var urun in Urunler)
        {
            urun.BilgileriYazdir();
        }
    }
}

// Program sınıfı
public class Program
{
    public static void Main()
    {
        // Kullanıcıdan ürün türünü seçmesini isteyin
        Console.WriteLine("Ürün türünü seçin (1: Fiziksel Ürün, 2: Dijital Ürün): ");
        int secim = int.Parse(Console.ReadLine());

        Urun urun = null;

        if (secim == 1)
        {
            urun = new FizikselUrun();
            Console.Write("Ürün Adı: ");
            urun.Ad = Console.ReadLine();
            Console.Write("Açıklama: ");
            urun.Aciklama = Console.ReadLine();
            Console.Write("Fiyat: ");
            urun.Fiyat = decimal.Parse(Console.ReadLine());
            Console.Write("Satılabilir mi? (true/false): ");
            urun.Satilabilir = bool.Parse(Console.ReadLine());
            Console.Write("Ağırlık: ");
            ((FizikselUrun)urun).Ağırlık = double.Parse(Console.ReadLine());
            Console.Write("Boyutlar: ");
            ((FizikselUrun)urun).Boyutlar = Console.ReadLine();
        }
        else if (secim == 2)
        {
            urun = new DijitalUrun();
            Console.Write("Ürün Adı: ");
            urun.Ad = Console.ReadLine();
            Console.Write("Açıklama: ");
            urun.Aciklama = Console.ReadLine();
            Console.Write("Fiyat: ");
            urun.Fiyat = decimal.Parse(Console.ReadLine());
            Console.Write("Satılabilir mi? (true/false): ");
            urun.Satilabilir = bool.Parse(Console.ReadLine());
            Console.Write("Dosya Formatı: ");
            ((DijitalUrun)urun).DosyaFormat = Console.ReadLine();
            Console.Write("İndirme Linki: ");
            ((DijitalUrun)urun).IndirmeLinki = Console.ReadLine();
        }

        // Sipariş oluşturuluyor
        Console.WriteLine("Sipariş Oluşturuluyor...");

        var siparis = new Siparis
        {
            SiparisNo = new Random().Next(1000, 9999),
            Urunler = new List<Urun> { urun },
            Durum = "Hazırlanıyor"
        };

        siparis.SiparisHesapla();
        siparis.BilgileriYazdir();
    }
}