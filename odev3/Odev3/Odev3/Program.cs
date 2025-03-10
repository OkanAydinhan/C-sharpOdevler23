class Program
{
    public static void Main(string[] args)
    {
        int sayi1 = 0;

        while (sayi1 < 10)
        {
            Console.WriteLine(sayi1);
            sayi1++; //for da bunu döngü içinde veriyorduk while da burda
        }

        int sayi2 = 20;

        do //do while koşul yanlış olsa da bir defa döngüyü çalıştırır sonra koşula bakar
        {
            Console.WriteLine(sayi2);

        }while(sayi2<10); //koşul kısmı burası
    }
}