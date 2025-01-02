using System;
using System.Collections.Generic;

public class OgrenciNotSistemi
{
    private Dictionary<string, int> notlar = new Dictionary<string, int>();

    public int this[string dersAdi]
    {
        get
        {
            if (notlar.ContainsKey(dersAdi))
            {
                return notlar[dersAdi];
            }
            return -1;  // Ders bulunamazsa -1 döndür
        }
        set
        {
            notlar[dersAdi] = value;
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        OgrenciNotSistemi notSistemi = new OgrenciNotSistemi();
        notSistemi["Matematik"] = 90;
        notSistemi["Fen"] = 85;
        notSistemi["Tarih"] = 78;

        Console.WriteLine(notSistemi["Matematik"]);  // Output: 90
        Console.WriteLine(notSistemi["Fen"]);        // Output: 85
        Console.WriteLine(notSistemi["Coğrafya"]);   // Output: -1
                                                     // Set or update course grades
        notSistemi["Fizik"] = 92;
        notSistemi["Fen"] = 92; // Update Science Grade
        Console.WriteLine(notSistemi["Fizik"]);   // Output: 92
        Console.WriteLine(notSistemi["Fen"]);    // Output: 92
    }
}