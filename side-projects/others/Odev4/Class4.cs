using System;

public class Kisi
{
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    public string KisiBilgisi()
    {
        return $"Ad: {Ad} {Soyad}, Telefon: {TelefonNumarasi}";
    }
}