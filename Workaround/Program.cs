using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //Degiskenler();

        Vatandas vatandas = new Vatandas();

        SelamVer("Mücahid");
        SelamVer("Ahmet");
        SelamVer("Muhsin");
        SelamVer();

        int sonuc = Topla(6, 58);

        string ogrenci1 = "Mücahid";
        string ogrenci2 = "Ahmet";
        string ogrenci3 = "Muhsin";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Mücahid";
        ogrenciler[1] = "Ahmet";
        ogrenciler[2] = "Muhsin";

        ogrenciler = new string[4];
        ogrenciler[3] = "İlker";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[0]);
        }

        string[] sehirler1 = new[]
        {
            "Ankara",
            "İstanbul",
            "İzmir"
        };
        string[] sehirler2 = new[]
        {
            "Bursa",
            "Antalya",
            "Muş"
        };

        sehirler2 = sehirler1;
        sehirler1[0] = "Adana";

        Console.WriteLine(sehirler2[0]);

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);
        }

        List<string> yeniSehirler1 = new List<string> 
        {
            "Ankara 1",
            "İstanbul 1",
            "İzmir 1" 
        };
        yeniSehirler1.Add("Muş");

        foreach (var sehir in yeniSehirler1)
        {
            Console.WriteLine(sehir);
        }

        Person person1 = new Person();
        person1.FirstName = "MÜCAHİD";
        person1.LastName = "UYGUN";
        person1.DateOfBirthYear = 1998;
        person1.NationalIdentity = 1234567890;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person:person1);

        Console.ReadLine();

    }

    static void SelamVer(string isim = "isimsiz")
    {
        Console.WriteLine("Merhaba" + isim);
    }

    static int Topla(int sayi1 = 5, int sayi2 = 10)
    {
        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam: " + sonuc);
        return sonuc;
    }

    private static void Degiskenler()
    {
        string mesaj = "Merhaba";
        double tutar = 10000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Mücahid";
        string soyad = "Uygun";
        int dogumYili = 1985;
        long tcNo = 12345678901;

        Console.WriteLine(tutar * 1.18);

        Console.WriteLine(tutar * 1.18);
    }
}

public class Vatandas
{
    public string Ad { get; set; }
    public string SoyAd { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}
