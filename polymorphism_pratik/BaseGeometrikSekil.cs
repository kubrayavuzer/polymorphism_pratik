using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_pratik
{
    internal class BaseGeometrik
    {
        public class BaseGeometrikSekil
        {
            
            public double Genislik { get; set; }
            public double Yukseklik { get; set; }

            
            public virtual double AlanHesapla()
            {
                return Genislik * Yukseklik;
            }
        }

        public class Kare : BaseGeometrikSekil;
        public class Dikdortgen : BaseGeometrikSekil;
        public class DikUcgen : BaseGeometrikSekil
        {
       
            public override double AlanHesapla()
            {
                return (Genislik * Yukseklik) / 2;
            }
        }

    }
}
