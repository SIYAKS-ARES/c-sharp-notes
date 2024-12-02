using System;

class Kalp
{
    public int KanBasinci { get; set; }
    public int Nabiz { get; set; }

    public Kalp(int kanBasinci, int nabiz)
    {
        KanBasinci = kanBasinci;
        Nabiz = nabiz;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"Kan Basıncı: {KanBasinci}, Nabız: {Nabiz}");
    }
}

class Insan
{
    public string Ad { get; set; }
    public Kalp Kalp { get; set; }

    public Insan(string ad)
    {
        Ad = ad;
        Kalp = new Kalp(120, 70);
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"{Ad} adlı kişinin kalp bilgileri:");
        Kalp.BilgiGoster();
    }
}

// Kullanım
class Program
{
    static void Main()
    {
        Insan insan = new Insan("Ayşe");
        insan.BilgiGoster();
    }
}