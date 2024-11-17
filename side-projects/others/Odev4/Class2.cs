using System;

public class Urun
{
    public string Ad { get; private set; }
    public decimal Fiyat { get; private set; }
    private decimal indirim;

    public decimal Indirim
    {
        get { return indirim; }
        set
        {
            if (value >= 0 && value <= 50)
                indirim = value;
            else
                throw new ArgumentException("İndirim %0 ile %50 arasında olmalıdır.");
        }
    }

    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    public decimal IndirimliFiyat()
    {
        return Fiyat - (Fiyat * Indirim / 100);
    }
}