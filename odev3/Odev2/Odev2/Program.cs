

class Program
{
    public static void Main(string[] args)
    {
        int yas = 92; 
        string sonuc = arabaYas(yas);
        string sonuc2 = arabaYasSwitchCase(yas);
        Console.WriteLine(sonuc);
        Console.WriteLine(sonuc2);


    }

    public static string arabaYas(int yas)
    {
        if (yas < 0 || yas > 30)
        {
            return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
        }
        else if (yas < 10)
        {
            return "Arabanız yeni";
        }
        else if (yas < 20)
        {
            return "Servise götürmeniz gerekebilir";
        }
        else
        {
            return "Arabanız hurdaya çıkabilir";
        }
    }
    public static string arabaYasSwitchCase(int yas)
    {
        switch (yas)
        {
            case < 0:  
            case > 30:  
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            case < 10:
                return "Arabanız yeni";
            case < 20:
                return "Servise götürmeniz gerekebilir";
            case < 30:
                return "Arabanız hurdaya çıkabilir";
            default:
                return "Bilinmeyen durum";
        }
    }
}
