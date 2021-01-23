using System;

namespace BDUyeleri
{
    class Program
    {
        static void Main(string[] args)
        {
            BDAilesi bd1 = new BDAilesi();
            bd1.bdNick = "ssumo";
            bd1.bdYas = 19;
            bd1.bdYil = '3';

            BDAilesi bd2 = new BDAilesi();
            bd2.bdNick = "BaeTull";
            bd2.bdYas = 21;
            bd2.bdYil = '3';

            BDAilesi bd3 = new BDAilesi();
            bd3.bdNick = "Agah";
            bd3.bdYas = 21;
            bd3.bdYil = '2';

            BDAilesi bd4 = new BDAilesi();
            bd4.bdNick = "Medusa";
            bd4.bdYas = 18;
            bd4.bdYil = '1';

            BDAilesi bd5 = new BDAilesi();
            bd5.bdNick = "Vendy";
            bd5.bdYas = 21;
            bd5.bdYil = '4';


            BDAilesi[] uyeler = new BDAilesi[] { bd1, bd2, bd3, bd4, bd5 };

        

            foreach (var bd in uyeler)
            {
                Console.ReadLine();

                Console.WriteLine(bd.bdNick + ": " + bd.bdYas + " " + bd.bdYil);
            }
        }
    }


    class BDAilesi
    {
        public string bdNick { get; set; }
        public int bdYas { get; set; }
        public char bdYil { get; set; }

    }
  
}
