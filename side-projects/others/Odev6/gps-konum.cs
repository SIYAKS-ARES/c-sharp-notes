using System;

public struct GPSKonum
{
    public double Enlem;
    public double Boylam;
    public GPSKonum(double enlem, double boylam)
    {
        Enlem = enlem;
        Boylam = boylam;
    }
    public double MesafeHesapla(GPSKonum diger)
    {
        double R = 6371; // Dünya yarıçapı (km)
        double lat1 = Enlem * Math.PI / 180;
        double lon1 = Boylam * Math.PI / 180;
        double lat2 = diger.Enlem * Math.PI / 180;
        double lon2 = diger.Boylam * Math.PI / 180;

        double dLat = lat2 - lat1;
        double dLon = lon2 - lon1;
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                  Math.Cos(lat1) * Math.Cos(lat2) *
                  Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return R * c;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        GPSKonum konum1 = new GPSKonum(40.7128, -74.0060); // New York
        GPSKonum konum2 = new GPSKonum(34.0522, -118.2437); // Los Angeles

        double mesafe = konum1.MesafeHesapla(konum2);
        Console.WriteLine($"Mesafe: {mesafe} km");  // Output: Mesafe: 3936.23 km
    }
}