using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax

        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name + " / ID: " + product.Id + " / Details: "
            + product.Details + " / Price: " + product.Price + " / Stock: " + product.Stock);
        }

        public void Add2(string productName, string details, double price, double stock)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productName);
        }

    }

}
