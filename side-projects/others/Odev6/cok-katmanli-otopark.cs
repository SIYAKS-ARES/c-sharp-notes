using System;

public class OtoparkSistemi
{
    private string[][,] parkYerleri;
    private int toplamKat;
    private int toplamParkYeriPerKat;
    public OtoparkSistemi(int katlar, int parkYeriPerKat)
    {
        toplamKat = katlar;
        toplamParkYeriPerKat = parkYeriPerKat;
        parkYerleri = new string[katlar][,];
        for (int i = 0; i < katlar; i++)
        {
            parkYerleri[i] = new string[1, parkYeriPerKat];
        }
    }

    public string this[int kat, int parkYeri]
    {
        get
        {
            if (kat < 0 || kat >= toplamKat || parkYeri < 0 || parkYeri >= toplamParkYeriPerKat)
                return "Geçersiz konum!";
            return parkYerleri[kat][0, parkYeri] ?? "Boş";
        }
        set
        {
            if (kat < 0 || kat >= toplamKat || parkYeri < 0 || parkYeri >= toplamParkYeriPerKat)
            {
                Console.WriteLine("Geçersiz konum!");
            }
            else
            {
                parkYerleri[kat][0, parkYeri] = value;
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        OtoparkSistemi otopark = new OtoparkSistemi(3, 10); // 3 kat 10 park yeri

        otopark[0, 5] = "ABC-123"; // 0. katta 5. park yerine araç plaka "ABC-123" yerleştir
        otopark[1, 2] = "XYZ-456"; // 1. katta 2. park yerine araç plaka "XYZ-456" yerleştir

        Console.WriteLine(otopark[0, 5]);    // Output: ABC-123
        Console.WriteLine(otopark[1, 2]);   // Output: XYZ-456
        Console.WriteLine(otopark[2, 7]);   // Output: Boş
        Console.WriteLine(otopark[5, 12]);  // Output: Geçersiz konum!
    }
}