using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    class Calisan
    {
        public string Ad = null;
        public string Soyad= null;
        public string Meslek = null;
        public int Maas = 0;
        public string Departman = null;

       
        public void BilgiYazdir()
        {
            Console.WriteLine("Ad : "+Ad+" Soyad: "+Soyad+" Meslek : "+Meslek+" Maas : "+Maas+" Departman : "+Departman);
        }
    }
}

