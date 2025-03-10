using Odev5;

class Program
{
    static void Main(string[] args)
    {
       
        Araba[] arabalar = new Araba[3];

       
        arabalar[0] = new Araba();
        arabalar[0].Marka = "Toyota";
        arabalar[0].BenzinTuketimiPerKm = 0.07;  
        arabalar[0].Mesafe = 500;  

        arabalar[1] = new Araba();
        arabalar[1].Marka = "Mercedes";
        arabalar[1].BenzinTuketimiPerKm = 0.05;  
        arabalar[1].Mesafe = 300;  

        arabalar[2] = new Araba();
        arabalar[2].Marka = "BMW";
        arabalar[2].BenzinTuketimiPerKm = 0.09;  
        arabalar[2].Mesafe = 800;

       
        double toplamBenzinTuketimi = 0;

        
        Console.WriteLine("Arabaların Benzin Tüketimleri:");
        

        for (int i = 0; i < arabalar.Length; i++)
        {
            double benzinTuketimi = arabalar[i].BenzinTuketimiPerKm * arabalar[i].Mesafe;
            Console.WriteLine(arabalar[i].Marka + ": " + benzinTuketimi + " litre benzin tüketti.");
            toplamBenzinTuketimi += benzinTuketimi;  
        }

        
        Console.WriteLine("Toplam Benzin Tüketimi: " + toplamBenzinTuketimi + " litre");
    }
}