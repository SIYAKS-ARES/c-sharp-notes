using System;

public class Hayvan
{
    public string Ad { get; set; }
    public string Tur { get; set; }
    public int Yas { get; set; }

    public virtual void SesCikar()
    {
        Console.WriteLine("Hayvan sesi çıkarıyor.");
    }
}

public class Memeli : Hayvan
{
    public string TuyRengi { get; set; }
    public override void SesCikar()
    {
        Console.WriteLine("Memeli sesi çıkarıyor.");
    }
}

public class Kus : Hayvan
{
    public double KanatGenisligi { get; set; }

    public override void SesCikar()
    {
        Console.WriteLine("Kuş sesi çıkarıyor.");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hayvan türünü seçin (1: Memeli, 2: Kuş): ");
        int secim = int.Parse(Console.ReadLine());

        Hayvan hayvan = null;

        if (secim == 1)
        {
            hayvan = new Memeli();
            Console.Write("Ad: ");
            hayvan.Ad = Console.ReadLine();
            Console.Write("Tür: ");
            hayvan.Tur = Console.ReadLine();
            Console.Write("Yaş: ");
            hayvan.Yas = int.Parse(Console.ReadLine());
            Console.Write("Tüy Rengi: ");
            ((Memeli)hayvan).TuyRengi = Console.ReadLine();

        }
        else if (secim == 2)
        {
            hayvan = new Kus();
            Console.Write("Ad: ");
            hayvan.Ad = Console.ReadLine();
            Console.Write("Tür: ");
            hayvan.Tur = Console.ReadLine();
            Console.Write("Yaş: ");
            hayvan.Yas = int.Parse(Console.ReadLine());
            Console.Write("Kanat Genişliği: ");
            ((Kus)hayvan).KanatGenisligi = double.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
            return;
        }

        Console.WriteLine("\nHayvan Bilgileri:");
        Console.WriteLine($"Ad: {hayvan.Ad}, Tür: {hayvan.Tur}, Yaş: {hayvan.Yas}");
        hayvan.SesCikar();
    }
}