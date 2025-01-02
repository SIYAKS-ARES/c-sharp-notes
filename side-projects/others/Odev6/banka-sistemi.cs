using System;

public class Hesap
{
    public int HesapNo { get; set; }
    public double Bakiye { get; set; }
    public string HesapSahibi { get; set; }

    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Hesap No: {HesapNo}, Bakiye: {Bakiye}, Hesap Sahibi: {HesapSahibi}");
    }

    public virtual void ParaYatır(decimal miktar)
    {
        Bakiye += (double)miktar;
    }
    public virtual void ParaCek(decimal miktar)
    {
        if (Bakiye >= (double)miktar)
        {
            Bakiye -= (double)miktar;
        }
        else
        {
            Console.WriteLine("Yetersiz Bakiye");
        }
    }
}

public class VadesizHesap : Hesap
{
    public double EkHesapLimiti { get; set; }
    public override void ParaCek(decimal miktar)
    {
        if (Bakiye + EkHesapLimiti >= (double)miktar)
        {
            Bakiye -= (double)miktar;
            Console.WriteLine("Para Çekme İşlemi Başarılı");
        }
        else
        {
            Console.WriteLine("Yetersiz Bakiye veya Ek Hesap Limitiniz Yetersiz");
        }
    }
}

public class VadeliHesap : Hesap
{
    public int VadeSuresi { get; set; }
    public double FaizOrani { get; set; }
    public override void ParaCek(decimal miktar)
    {
        Console.WriteLine("Vadeli hesapta vade dolmadan para çekme yapılamaz.");

    }
    public override void ParaYatır(decimal miktar)
    {
        Bakiye += (double)miktar;
        Bakiye += Bakiye * (FaizOrani / 100);
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hesap türünü seçin (1: Vadesiz Hesap, 2: Vadeli Hesap): ");
        int secim = int.Parse(Console.ReadLine());
        Hesap hesap = null;
        if (secim == 1)
        {
            hesap = new VadesizHesap();
            Console.Write("Hesap No: ");
            hesap.HesapNo = int.Parse(Console.ReadLine());
            Console.Write("Bakiye: ");
            hesap.Bakiye = double.Parse(Console.ReadLine());
            Console.Write("Hesap Sahibi: ");
            hesap.HesapSahibi = Console.ReadLine();
            Console.Write("Ek Hesap Limiti: ");
            ((VadesizHesap)hesap).EkHesapLimiti = double.Parse(Console.ReadLine());


        }
        else if (secim == 2)
        {
            hesap = new VadeliHesap();
            Console.Write("Hesap No: ");
            hesap.HesapNo = int.Parse(Console.ReadLine());
            Console.Write("Bakiye: ");
            hesap.Bakiye = double.Parse(Console.ReadLine());
            Console.Write("Hesap Sahibi: ");
            hesap.HesapSahibi = Console.ReadLine();
            Console.Write("Vade Süresi: ");
            ((VadeliHesap)hesap).VadeSuresi = int.Parse(Console.ReadLine());
            Console.Write("Faiz Oranı: ");
            ((VadeliHesap)hesap).FaizOrani = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Geçersiz Seçim");
            return;
        }

        while (true)
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz: 1-Para Yatır 2-Para Çek 3-Hesap Bilgileri 4-Çıkış");
            int islem = int.Parse(Console.ReadLine());
            if (islem == 1)
            {
                Console.Write("Yatırılacak Miktarı Giriniz: ");
                decimal miktar = decimal.Parse(Console.ReadLine());
                hesap.ParaYatır(miktar);
            }
            else if (islem == 2)
            {
                Console.Write("Çekilecek Miktarı Giriniz: ");
                decimal miktar = decimal.Parse(Console.ReadLine());
                hesap.ParaCek(miktar);
            }
            else if (islem == 3)
            {
                hesap.BilgiYazdir();
            }
            else if (islem == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz Seçim");
            }
        }
    }
}