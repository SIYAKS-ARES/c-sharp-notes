using System;

public struct Zaman
{
    public int Saat;
    public int Dakika;

    public Zaman(int saat, int dakika)
    {
        Saat = saat >= 0 && saat <= 23 ? saat : 0;
        Dakika = dakika >= 0 && dakika <= 59 ? dakika : 0;
    }

    public int ToplamDakika()
    {
        return Saat * 60 + Dakika;
    }

    public int DakikaFarki(Zaman diger)
    {
        return Math.Abs(ToplamDakika() - diger.ToplamDakika());
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Zaman zaman1 = new Zaman(10, 30);
        Zaman zaman2 = new Zaman(12, 45);
        Zaman zaman3 = new Zaman(24, 80);

        Console.WriteLine($"Zaman 1 Toplam Dakika: {zaman1.ToplamDakika()}");    // Output: Zaman 1 Toplam Dakika: 630
        Console.WriteLine($"Zaman 2 Toplam Dakika: {zaman2.ToplamDakika()}");  // Output: Zaman 2 Toplam Dakika: 765
        Console.WriteLine($"Zaman 3 Toplam Dakika: {zaman3.ToplamDakika()}");  // Output: Zaman 3 Toplam Dakika: 0
        Console.WriteLine($"Zaman Farkı: {zaman1.DakikaFarki(zaman2)}");      // Output: Zaman Farkı: 135
    }
}