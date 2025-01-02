using System;

public class ZamanFarkHesaplayici
{
    // Farkı gün cinsinden döndürür
    public TimeSpan ZamanFarkiHesapla(DateTime tarih1, DateTime tarih2)
    {
        return tarih2 - tarih1;
    }

    // Farkı saat cinsinden döndürür
    public double ZamanFarkiHesapla(DateTime tarih1, DateTime tarih2, string zamanBrimi)
    {
        if (zamanBrimi.ToLower() == "saat")
        {
            return (tarih2 - tarih1).TotalHours;
        }
        return 0;
    }
    public string ZamanFarkiHesapla(DateTime tarih1, DateTime tarih2, string yil, string ay, string gun)
    {
        TimeSpan fark = tarih2 - tarih1;
        return $"Fark: {fark.Days / 365} yıl, {fark.Days % 365 / 30} ay, {fark.Days % 30} gün";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ZamanFarkHesaplayici hesaplayici = new ZamanFarkHesaplayici();
        DateTime tarih1 = new DateTime(2023, 1, 1);
        DateTime tarih2 = new DateTime(2023, 1, 10);
        Console.WriteLine(hesaplayici.ZamanFarkiHesapla(tarih1, tarih2));             // Output: 9.00:00:00
        Console.WriteLine(hesaplayici.ZamanFarkiHesapla(tarih1, tarih2, "saat"));    // Output: 216
        Console.WriteLine(hesaplayici.ZamanFarkiHesapla(tarih1, tarih2, "yil", "ay", "gun")); //Output: Fark: 0 yıl, 0 ay, 9 gün
    }
}