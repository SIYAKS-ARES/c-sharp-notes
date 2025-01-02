using System;
using System.Collections.Generic;

// Abstract temel sınıf - Ürün
public abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    public abstract decimal HesaplaOdeme();

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad}, Fiyat: {Fiyat}");
    }
}

// Türetilmiş sınıf - Kitap
public class Kitap : Urun
{
    public string Yazar { get; set; }
    public string ISBN { get; set; }
    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.10m; // %10 vergi
    }
    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Yazar: {Yazar}, ISBN: {ISBN}");
    }
}

// Türetilmiş sınıf - Elektronik
public class Elektronik : Urun
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public override decimal HesaplaOdeme()
    {
        return Fiyat * 1.25m; // %25 vergi
    }
    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Marka: {Marka}, Model: {Model}");
    }
}
public class Program
{
    public static void Main()
    {
        List<Urun> urunler = new List<Urun>();
        urunler.Add(new Kitap { Ad = "Clean Code", Fiyat = 50, Yazar = "Robert C. Martin", ISBN = "ISBN-123" });
        urunler.Add(new Elektronik { Ad = "Laptop", Fiyat = 1000, Marka = "X", Model = "Y" });
        urunler.Add(new Elektronik { Ad = "Telefon", Fiyat = 800, Marka = "A", Model = "B" });
        foreach (var item in urunler)
        {
            item.BilgiYazdir();
            Console.WriteLine($"Ödenecek Tutar: {item.HesaplaOdeme()}");
            Console.WriteLine();
        }
    }
}