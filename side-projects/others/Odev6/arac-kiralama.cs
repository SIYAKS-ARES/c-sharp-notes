using System;

namespace AracKiralamaSistemi
{
    // Temel Araç Sınıfı
    class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public double GunlukKiraBedeli { get; set; }

        // Polimorfizm için sanal metot
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Günlük Kira Bedeli: {GunlukKiraBedeli} TL");
        }
    }

    // Otomobil Sınıfı (Araç sınıfından türetildi)
    class Otomobil : Arac
    {
        public int KapiSayisi { get; set; }

        // BilgiYazdir metodu eziliyor (override ediliyor)
        public override void BilgiYazdir()
        {
            base.BilgiYazdir(); // Temel sınıfın metodunu çağır
            Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
        }
    }

    // Motosiklet Sınıfı (Araç sınıfından türetildi)
    class Motosiklet : Arac
    {
        public bool KaskDahilMi { get; set; }

        // BilgiYazdir metodu eziliyor (override ediliyor)
        public override void BilgiYazdir()
        {
            base.BilgiYazdir(); // Temel sınıfın metodunu çağır
            Console.WriteLine($"Kask Dahil Mi: {(KaskDahilMi ? "Evet" : "Hayır")}");
        }
    }

    // Program Sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Araç türünü seçiniz (1: Otomobil, 2: Motosiklet): ");
            int secim = int.Parse(Console.ReadLine());

            Arac arac; // Polimorfizm için temel sınıf referansı

            if (secim == 1)
            {
                arac = new Otomobil();
                Console.Write("Marka: ");
                arac.Marka = Console.ReadLine();
                Console.Write("Model: ");
                arac.Model = Console.ReadLine();
                Console.Write("Yıl: ");
                arac.Yil = int.Parse(Console.ReadLine());
                Console.Write("Günlük Kira Bedeli: ");
                arac.GunlukKiraBedeli = double.Parse(Console.ReadLine());
                Console.Write("Kapı Sayısı: ");
                ((Otomobil)arac).KapiSayisi = int.Parse(Console.ReadLine());
            }
            else if (secim == 2)
            {
                arac = new Motosiklet();
                Console.Write("Marka: ");
                arac.Marka = Console.ReadLine();
                Console.Write("Model: ");
                arac.Model = Console.ReadLine();
                Console.Write("Yıl: ");
                arac.Yil = int.Parse(Console.ReadLine());
                Console.Write("Günlük Kira Bedeli: ");
                arac.GunlukKiraBedeli = double.Parse(Console.ReadLine());
                Console.Write("Kask Dahil Mi (Evet/Hayır): ");
                ((Motosiklet)arac).KaskDahilMi = Console.ReadLine().ToLower() == "evet";
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Program sonlandırılıyor.");
                return;
            }

            Console.WriteLine("\nAraç Bilgileri:");
            arac.BilgiYazdir();
        }
    }
}