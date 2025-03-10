using odev4;

class Program
{
    static void Main(string[] args)
    {
        
        Calisan[] calisanlar = new Calisan[4];

        
        calisanlar[0] = new Calisan();
        calisanlar[0].Ad = "Ahmet";
        calisanlar[0].Soyad = "Yılmaz";
        calisanlar[0].Meslek = "Genel Müdür (GM)";
        calisanlar[0].Maas = 50000;
        calisanlar[0].Departman = "Yönetim";

        calisanlar[1] = new Calisan();
        calisanlar[1].Ad = "Mehmet";
        calisanlar[1].Soyad = "Demir";
        calisanlar[1].Meslek = "Müdür (MU)";
        calisanlar[1].Maas = 30000;
        calisanlar[1].Departman = "Satış";

        calisanlar[2] = new Calisan();
        calisanlar[2].Ad = "Ayşe";
        calisanlar[2].Soyad = "Kaya";
        calisanlar[2].Meslek = "Programcı (PR)";
        calisanlar[2].Maas = 25000;
        calisanlar[2].Departman = "Yazılım";

        calisanlar[3] = new Calisan();
        calisanlar[3].Ad = "Elif";
        calisanlar[3].Soyad = "Öztürk";
        calisanlar[3].Meslek = "Stajyer (S)";
        calisanlar[3].Maas = 10000;
        calisanlar[3].Departman = "Destek";

       
        int toplamMaas = 0;

        
        Console.WriteLine("Çalışan Listesi:");
        

        for (int i = 0; i < calisanlar.Length; i++)
        {
            calisanlar[i].BilgiYazdir();
            toplamMaas += calisanlar[i].Maas; 
        }

        Console.WriteLine("Toplam Maaş: "+toplamMaas+" TL");
    }
}