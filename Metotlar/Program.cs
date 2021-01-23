using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string producktName = "Elma";
            double price = 15;
            string details = "Amasya elmasi";

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Details = "Amasya elmasi";
            product1.Id = 256486;
            product1.Stock = 12;

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Details = "Diyarbakir karpuzu";
            product1.Id = 1212;
            product1.Stock = 8;

            Product[] products = new Product[] { product1, product2 };


            //type-safe
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Details);
                Console.WriteLine("------------------------");
            }


            Console.WriteLine("-------------------Metotlar------------------");
            //instance - ornek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Armut", "Yesil atmut", 12, 10);
            sepetManager.Add2("Elma", "Yesil elma", 15, 9);
            sepetManager.Add2("Karpuz", "Diyarbakir karpuzu", 13, 8);

            
        }
    }
}



//dont repeat yourself - DRY - Clean Code - Best Practice