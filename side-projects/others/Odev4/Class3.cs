using System;

public class KiralikArac
{
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; } = true;

    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
    }

    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"Araç {Plaka} kiralandı.");
        }
        else
        {
            Console.WriteLine($"Araç {Plaka} zaten kirada.");
        }
    }

    public void AraciTeslimEt()
    {
        MusaitMi = true;
        Console.WriteLine($"Araç {Plaka} teslim alındı.");
    }
}