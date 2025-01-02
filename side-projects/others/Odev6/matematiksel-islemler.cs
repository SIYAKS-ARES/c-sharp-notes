using System;

public class Hesaplayici
{
    // İki tam sayıyı toplar
    public int Topla(int a, int b)
    {
        return a + b;
    }

    // Üç tam sayıyı toplar
    public int Topla(int a, int b, int c)
    {
        return a + b + c;
    }

    // Bir dizi tam sayıyı toplar
    public int Topla(int[] sayilar)
    {
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        return toplam;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Hesaplayici hesaplayici = new Hesaplayici();
        Console.WriteLine(hesaplayici.Topla(5, 10));          // Output: 15
        Console.WriteLine(hesaplayici.Topla(5, 10, 15));       // Output: 30
        Console.WriteLine(hesaplayici.Topla(new int[] { 1, 2, 3, 4, 5 }));  // Output: 15
    }
}