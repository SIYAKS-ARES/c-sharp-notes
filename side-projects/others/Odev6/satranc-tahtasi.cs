using System;

public class SatrancTahtasi
{
    private string[,] tahta = new string[8, 8];

    public string this[int satir, int sutun]
    {
        get
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
                return "Geçersiz konum!";
            return tahta[satir, sutun] ?? "Boş";
        }
        set
        {
            if (satir < 0 || satir >= 8 || sutun < 0 || sutun >= 8)
            {
                Console.WriteLine("Geçersiz konum!");
            }
            else
            {
                tahta[satir, sutun] = value;
            }

        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SatrancTahtasi satranc = new SatrancTahtasi();
        satranc[0, 0] = "Kale";
        satranc[1, 2] = "At";
        Console.WriteLine(satranc[0, 0]);   // Output: Kale
        Console.WriteLine(satranc[1, 2]);   // Output: At
        Console.WriteLine(satranc[5, 5]); //Output: Boş
        Console.WriteLine(satranc[10, 1]);   // Output: Geçersiz konum!
    }
}