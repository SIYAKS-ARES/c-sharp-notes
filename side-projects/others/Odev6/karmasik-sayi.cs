using System;

public struct KarmasikSayi
{
    public double Gercek;
    public double Sanal;

    public KarmasikSayi(double gercek, double sanal)
    {
        Gercek = gercek;
        Sanal = sanal;
    }

    public KarmasikSayi Topla(KarmasikSayi diger)
    {
        return new KarmasikSayi(Gercek + diger.Gercek, Sanal + diger.Sanal);
    }

    public KarmasikSayi Cikar(KarmasikSayi diger)
    {
        return new KarmasikSayi(Gercek - diger.Gercek, Sanal - diger.Sanal);
    }

    public override string ToString()
    {
        return $"{Gercek} + {Sanal}i";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KarmasikSayi sayi1 = new KarmasikSayi(3, 2);
        KarmasikSayi sayi2 = new KarmasikSayi(1, 4);

        KarmasikSayi toplam = sayi1.Topla(sayi2);
        KarmasikSayi fark = sayi1.Cikar(sayi2);

        Console.WriteLine($"Karmaşık Sayı 1: {sayi1.ToString()}");    // Output: Karmaşık Sayı 1: 3 + 2i
        Console.WriteLine($"Karmaşık Sayı 2: {sayi2.ToString()}"); // Output: Karmaşık Sayı 2: 1 + 4i
        Console.WriteLine($"Toplam: {toplam.ToString()}");           // Output: Toplam: 4 + 6i
        Console.WriteLine($"Fark: {fark.ToString()}");             // Output: Fark: 2 + -2i
    }
}