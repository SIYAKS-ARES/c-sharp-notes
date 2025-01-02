using System;

// Soyut sınıf - Şekil
public abstract class Sekil
{
    public string Ad { get; set; }
    public string Renk { get; set; }

    // Soyut metot
    public abstract void Ciz();

    // Genel şekil bilgisi yazdırma metodu
    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Şekil Adı: {Ad}");
        Console.WriteLine($"Renk: {Renk}");
    }
}

// Daire sınıfı, Şekil sınıfından türetilmiştir
public class Daire : Sekil
{
    public int YariCap { get; set; }

    // Ciz() metodunun uygulanması
    public override void Ciz()
    {
        Console.WriteLine($"{Ad} adlı daire, {Renk} renkli olarak çiziliyor. Yarıçap: {YariCap}");
    }
}

// Dikdortgen sınıfı, Şekil sınıfından türetilmiştir
public class Dikdortgen : Sekil
{
    public int Uzunluk { get; set; }
    public int Genislik { get; set; }

    // Ciz() metodunun uygulanması
    public override void Ciz()
    {
        Console.WriteLine($"{Ad} adlı dikdörtgen, {Renk} renkli olarak çiziliyor. Uzunluk: {Uzunluk}, Genişlik: {Genislik}");
    }
}

// Program sınıfı
public class Program
{
    public static void Main()
    {
        // Kullanıcıdan seçim alalım
        Console.WriteLine("Şekil Seçin (1: Daire, 2: Dikdörtgen): ");
        int secim = int.Parse(Console.ReadLine());

        Sekil sekil = null;

        // Kullanıcı seçimine göre nesne oluşturuluyor
        if (secim == 1)
        {
            sekil = new Daire();
            Console.Write("Daire Adı: ");
            sekil.Ad = Console.ReadLine();
            Console.Write("Daire Rengi: ");
            sekil.Renk = Console.ReadLine();
            Console.Write("Daire Yarıçapı: ");
            ((Daire)sekil).YariCap = int.Parse(Console.ReadLine());
        }
        else if (secim == 2)
        {
            sekil = new Dikdortgen();
            Console.Write("Dikdörtgen Adı: ");
            sekil.Ad = Console.ReadLine();
            Console.Write("Dikdörtgen Rengi: ");
            sekil.Renk = Console.ReadLine();
            Console.Write("Dikdörtgen Uzunluğu: ");
            ((Dikdortgen)sekil).Uzunluk = int.Parse(Console.ReadLine());
            Console.Write("Dikdörtgen Genişliği: ");
            ((Dikdortgen)sekil).Genislik = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Geçersiz seçim!");
            return;
        }

        // Şekil bilgisini yazdırıyoruz
        sekil.BilgiYazdir();
        // Şekil çizme işlemi
        sekil.Ciz();
    }
}