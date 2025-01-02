using System;
using System.Collections.Generic;

// Interface - IPublisher
public interface IYayinlayici
{
    void AboneEkle(IAbone abone);
    void AboneCikar(IAbone abone);
    void Bildir(string mesaj);
}

// Interface - ISubscriber
public interface IAbone
{
    void BilgiAl(string mesaj);
}

// Concrete Publisher Class - Yayinlayici
public class Yayinlayici : IYayinlayici
{
    private List<IAbone> aboneler = new List<IAbone>();

    public void AboneEkle(IAbone abone)
    {
        aboneler.Add(abone);
    }

    public void AboneCikar(IAbone abone)
    {
        aboneler.Remove(abone);
    }

    public void Bildir(string mesaj)
    {
        foreach (var abone in aboneler)
        {
            abone.BilgiAl(mesaj);
        }
    }
}

// Concrete Subscriber Class - Abone
public class Abone : IAbone
{
    public string Ad { get; set; }

    public Abone(string ad)
    {
        Ad = ad;
    }

    public void BilgiAl(string mesaj)
    {
        Console.WriteLine($"{Ad} adlı abone mesaj aldı: {mesaj}");
    }
}

public class Program
{
    public static void Main()
    {
        Yayinlayici yayinlayici = new Yayinlayici();

        Abone abone1 = new Abone("Abone 1");
        Abone abone2 = new Abone("Abone 2");
        Abone abone3 = new Abone("Abone 3");

        yayinlayici.AboneEkle(abone1);
        yayinlayici.AboneEkle(abone2);
        yayinlayici.AboneEkle(abone3);

        yayinlayici.Bildir("Yeni bir ürün eklendi.");
        yayinlayici.AboneCikar(abone3);
        yayinlayici.Bildir("Kampanya başladı.");
    }
}