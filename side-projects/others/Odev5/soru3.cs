using System;
using System.Collections.Generic;

class Tekerlek
{
    public string Tip { get; set; }

    public Tekerlek(string tip)
    {
        Tip = tip;
    }
}

class Araba
{
    public string Model { get; set; }
    public List<Tekerlek> Tekerlekler { get; set; }

    public Araba(string model)
    {
        Model = model;
        Tekerlekler = new List<Tekerlek>();
    }

    public void TekerlekEkle(Tekerlek tekerlek)
    {
        Tekerlekler.Add(tekerlek);
    }

    public void TekerlekleriListele()
    {
        Console.WriteLine($"{Model} model arabanın tekerlekleri:");
        foreach (var tekerlek in Tekerlekler)
        {
            Console.WriteLine($"- {tekerlek.Tip}");
        }
    }
}

// Kullanım
class Program
{
    static void Main()
    {
        Araba araba = new Araba("Toyota Corolla");
        araba.TekerlekEkle(new Tekerlek("Kış Lastiği"));
        araba.TekerlekEkle(new Tekerlek("Yaz Lastiği"));

        araba.TekerlekleriListele();
    }
}