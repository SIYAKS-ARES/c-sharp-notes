using System;
using System.Collections.Generic;

public class Kitap
{
    public string Baslik { get; private set; }
    public string Yazar { get; private set; }

    public Kitap(string baslik, string yazar)
    {
        Baslik = baslik;
        Yazar = yazar;
    }
}

public class Kutuphane
{
    private List<Kitap> Kitaplar = new List<Kitap>();

    public void KitapEkle(Kitap yeniKitap)
    {
        Kitaplar.Add(yeniKitap);
        Console.WriteLine($"Kitap eklendi: {yeniKitap.Baslik}");
    }

    public void KitaplariListele()
    {
        Console.WriteLine("Kütüphanedeki kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine($"Başlık: {kitap.Baslik}, Yazar: {kitap.Yazar}");
        }
    }
}