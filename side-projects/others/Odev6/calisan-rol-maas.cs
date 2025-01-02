using System;

// Hava durumu tiplerini temsil eden enum
public enum HavaDurumu
{
    Guney,
    Yagmurlu,
    Bulutlu,
    Firtinali
}

public class HavaDurumuTavsiye
{
    public HavaDurumu MevcutHavaDurumu { get; set; }

    public string TavsiyeVer()
    {
        switch (MevcutHavaDurumu)
        {
            case HavaDurumu.Guney:
                return "Hava güneşli, güneş kremi kullanmayı unutma!";
            case HavaDurumu.Yagmurlu:
                return "Hava yağmurlu, şemsiyeni yanına al!";
            case HavaDurumu.Bulutlu:
                return "Hava bulutlu, yanına bir hırka alabilirsin.";
            case HavaDurumu.Firtinali:
                return "Hava fırtınalı, mümkünse dışarı çıkma!";
            default:
                return "Geçersiz hava durumu!";
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        HavaDurumuTavsiye tavsiye = new HavaDurumuTavsiye();
        tavsiye.MevcutHavaDurumu = HavaDurumu.Yagmurlu;
        Console.WriteLine(tavsiye.TavsiyeVer());     // Output: Hava yağmurlu, şemsiyeni yanına al!
        tavsiye.MevcutHavaDurumu = HavaDurumu.Guney;
        Console.WriteLine(tavsiye.TavsiyeVer());    // Output: Hava güneşli, güneş kremi kullanmayı unutma!
    }
}