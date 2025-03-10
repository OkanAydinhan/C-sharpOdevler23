class Program
{
    public static void Main(string[] args)
    {
        int yas = 0;
        string sonuc = yasDondur(yas);
        Console.WriteLine(sonuc);
    }

    public static string yasDondur(int yas) 
    {
        if (yas >= 0 && yas < 18)
        {
            return "Küçüksünüz";
        }
        else if (yas >= 18 && yas < 35)
        {
            return "Gençsiniz";
        }
        else if (yas >= 35 && yas < 55)
        {
            return "Yetişkinsiniz";
        }
        else if (yas >= 55 && yas < 75)
        {
            return "Yaşlısınız";
        }
        else if (yas >= 75 && yas < 99)
        {
            return "Çok yaşlısınız";
        }
        else
        {
            return "Ya hiç doğmadınız ya da çoktan öldünüz";
        }
    }
}
