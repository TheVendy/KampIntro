using System;

namespace BDAilesi
{
    class Program
    {
        static void Main(string[] args)
        {
            BDAilesi bd1 = new BDAilesi();
            bd1.UyeIsmi = "Vendy";
            bd1.UyeYas = 21;
            bd1.UyeRenk = "Siyah";

            BDAilesi bd2 = new BDAilesi();
            bd2.UyeIsmi = "ssumo";
            bd2.UyeYas = 19;
            bd2.UyeRenk = "Pembe";

            BDAilesi bd3 = new BDAilesi();
            bd3.UyeIsmi = "Medusa";
            bd3.UyeYas = 18;
            bd3.UyeRenk = "Kirmizi";

            BDAilesi bd4 = new BDAilesi();
            bd4.UyeIsmi = "BaeTull";
            bd4.UyeYas = 21;
            bd4.UyeRenk = "Kirmizi";

            BDAilesi[] uyeler = new BDAilesi[] { bd1, bd2, bd3, bd4 };

            foreach (var bd in uyeler)
            {
                Console.WriteLine(bd.UyeIsmi + ": " + bd.UyeYas + " " + bd.UyeRenk);
            }


        }
    }


    class BDAilesi
    {
        public string UyeIsmi { get; set; }
        public int UyeYas { get; set; }
        public string UyeRenk { get; set; }

    }


}
