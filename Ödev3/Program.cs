using System;

class Program
{

    static void Main()
    {
        // Kullanıcıdan alınması gereken bilgi
        Console.Write("Birinci kenarın uzunluğunu girin: ");
        int kenar1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci kenarın uzunluğnu girin: ");
        int kenar2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Üçüncü kenarın uzunluğunu girin: ");
        int kenar3 = Convert.ToInt32(Console.ReadLine());

        // Çevreyi hesapla
        int cevre = kenar1 + kenar2 + kenar3;

        // Sonucu ekrana yazdır
        Console.WriteLine($"Üçgenin Çevresi: {cevre}");

    }
}


