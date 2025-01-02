using System;

// Trafik ışığı durumlarını temsil eden enum
public enum TrafikIsigiDurumu
{
    Kirmizi,
    Sari,
    Yesil
}

public class TrafikIsigi
{
    public TrafikIsigiDurumu MevcutDurum { get; set; }

    public string HangiDurumdaNeYapilmali()
    {
        switch (MevcutDurum)
        {
            case TrafikIsigiDurumu.Kirmizi:
                return "Kırmızı ışık, dur!";
            case TrafikIsigiDurumu.Sari:
                return "Sarı ışık, hazırlan veya dikkatli ol!";
            case TrafikIsigiDurumu.Yesil:
                return "Yeşil ışık, geçebilirsin.";
            default:
                return "Geçersiz ışık durumu!";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TrafikIsigi isik = new TrafikIsigi();
        isik.MevcutDurum = TrafikIsigiDurumu.Kirmizi;
        Console.WriteLine(isik.HangiDurumdaNeYapilmali());  // Output: Kırmızı ışık, dur!

        isik.MevcutDurum = TrafikIsigiDurumu.Sari;
        Console.WriteLine(isik.HangiDurumdaNeYapilmali());  // Output: Sarı ışık, hazırlan veya dikkatli ol!

        isik.MevcutDurum = TrafikIsigiDurumu.Yesil;
        Console.WriteLine(isik.HangiDurumdaNeYapilmali()); // Output: Yeşil ışık, geçebilirsin.
    }
}