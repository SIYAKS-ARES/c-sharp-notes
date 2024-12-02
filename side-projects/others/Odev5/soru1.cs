using System;
using System.Collections.Generic;

class Yazar
{
    public string Ad { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    public Yazar(string ad)
    {
        Ad = ad;
        Kitaplar = new List<Kitap>();
    }

    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap);
    }

    public void KitaplariListele()
    {
        Console.WriteLine($"{Ad} adlı yazarın kitapları:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"- {kitap.Ad}");
        }
    }
}

class Kitap
{
    public string Ad { get; set; }

    public Kitap(string ad)
    {
        Ad = ad;
    }
}

// Kullanım
class Program
{
    static void Main()
    {
        Yazar yazar = new Yazar("Orhan Pamuk");
        yazar.KitapEkle(new Kitap("Kar"));
        yazar.KitapEkle(new Kitap("Benim Adım Kırmızı"));

        yazar.KitaplariListele();
    }
}