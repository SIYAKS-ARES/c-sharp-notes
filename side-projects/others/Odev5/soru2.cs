using System;

class Departman
{
    public string Ad { get; set; }

    public Departman(string ad)
    {
        Ad = ad;
    }
}

class Calisan
{
    public string Ad { get; set; }
    public Departman Departmani { get; set; }

    public Calisan(string ad)
    {
        Ad = ad;
    }

    public void DepartmanAta(Departman departman)
    {
        Departmani = departman;
    }

    public void BilgiGoster()
    {
        Console.WriteLine($"{Ad}, {Departmani.Ad} departmanında çalışıyor.");
    }
}

// Kullanım
class Program
{
    static void Main()
    {
        Departman yazilim = new Departman("Yazılım");
        Calisan calisan = new Calisan("Ahmet Yılmaz");
        calisan.DepartmanAta(yazilim);

        calisan.BilgiGoster();
    }
}