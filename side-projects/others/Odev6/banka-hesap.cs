using System;

// Interface - IBankaHesabi
public interface IBankaHesabi
{
    DateTime HesapAcilisTarihi { get; set; }
    void HesapOzeti();
}

// Abstract temel sınıf - Hesap
public abstract class Hesap : IBankaHesabi
{
    public int HesapNo { get; set; }
    public decimal Bakiye { get; set; }
    public DateTime HesapAcilisTarihi { get; set; }

    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);
    public abstract void HesapOzeti();
}

// Türetilmiş sınıf - BirikimHesabi (Vadeli Hesap)
public class BirikimHesabi : Hesap
{
    public double FaizOrani { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar + miktar * (decimal)(FaizOrani / 100); // Faiz ekle
    }
    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= miktar;
        }
        else
        {
            Console.WriteLine("Yetersiz Bakiye");
        }
    }
    public override void HesapOzeti()
    {
        Console.WriteLine("Birikim Hesabı Özeti:");
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye}, Açılış Tarihi: {HesapAcilisTarihi}, Faiz Oranı: {FaizOrani}");
    }
}

// Türetilmiş sınıf - VadesizHesap (Vadesiz Hesap)
public class VadesizHesap : Hesap
{
    public decimal IslemUcreti { get; set; }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
    }
    public override void ParaCek(decimal miktar)
    {
        if (Bakiye >= miktar)
        {
            Bakiye -= (miktar + IslemUcreti);
        }
        else
        {
            Console.WriteLine("Yetersiz Bakiye");
        }
    }
    public override void HesapOzeti()
    {
        Console.WriteLine("Vadesiz Hesap Özeti:");
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye}, Açılış Tarihi: {HesapAcilisTarihi}, İşlem Ücreti: {IslemUcreti}");
    }
}

public class Program
{
    public static void Main()
    {
        BirikimHesabi birikimHesabi = new BirikimHesabi
        {
            HesapNo = 123,
            Bakiye = 1000,
            HesapAcilisTarihi = DateTime.Now,
            FaizOrani = 5
        };
        VadesizHesap vadesizHesap = new VadesizHesap
        {
            HesapNo = 345,
            Bakiye = 2000,
            HesapAcilisTarihi = DateTime.Now,
            IslemUcreti = 2
        };

        birikimHesabi.ParaYatir(500);
        vadesizHesap.ParaCek(500);
        birikimHesabi.HesapOzeti();
        vadesizHesap.HesapOzeti();
    }
}