using System;

public class BankaHesabi
{
    public string HesapNumarasi { get; private set; }
    private decimal Bakiye;

    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    public void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
    }

    public void ParaCek(decimal miktar)
    {
        if (miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yetersiz bakiye!");
        }
    }

    public void BakiyeGoster()
    {
        Console.WriteLine($"Hesap Numarası: {HesapNumarasi}, Bakiye: {Bakiye} TL");
    }
}