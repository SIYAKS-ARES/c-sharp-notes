using System;

public class Kitaplik
{
    private string[] kitaplar = new string[5];

    public string this[int index]
    {
        get
        {
            if (index < 0 || index >= kitaplar.Length)
                return "Geçersiz indeks!";
            return kitaplar[index];
        }
        set
        {
            if (index < 0 || index >= kitaplar.Length)
                Console.WriteLine("Geçersiz indeks!");
            else
                kitaplar[index] = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Kitaplik kitaplik = new Kitaplik();
        kitaplik[0] = "C# Temelleri";
        kitaplik[1] = "İleri C#";

        Console.WriteLine(kitaplik[0]);  // Output: C# Temelleri
        Console.WriteLine(kitaplik[1]);  // Output: İleri C#
        Console.WriteLine(kitaplik[10]); // Output: Geçersiz indeks!
    }
}