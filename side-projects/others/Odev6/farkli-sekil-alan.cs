using System;

public class AlanHesaplayici
{
    // Karenin alanını hesaplar
    public double AlanHesapla(double kenar)
    {
        return kenar * kenar;
    }

    // Dikdörtgenin alanını hesaplar
    public double AlanHesapla(double uzunluk, double genislik)
    {
        return uzunluk * genislik;
    }

    // Dairenin alanını hesaplar
    public double AlanHesapla(double yaricap, string sekil)
    {
        if (sekil.ToLower() == "daire")
        {
            return Math.PI * yaricap * yaricap;
        }
        return 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        AlanHesaplayici hesaplayici = new AlanHesaplayici();
        Console.WriteLine(hesaplayici.AlanHesapla(5));                // Output: 25
        Console.WriteLine(hesaplayici.AlanHesapla(5, 10));             // Output: 50
        Console.WriteLine(hesaplayici.AlanHesapla(5, "daire"));     // Output: 78,539
    }
}