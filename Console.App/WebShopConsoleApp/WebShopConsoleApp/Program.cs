using System;
using System.Collections.Generic;

namespace WebShopConsoleApp
{

    class Product //Superclass; Models
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Warning { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            
 
            List<Product> products = new List<Product>();

            products.Add(new Product(
            "id",
            "Name",
            "description",
            100,
            "Warning"
            ));


            foreach (var item in products) // för varje > föremål > i listan "products>
                                            // IFALL > föremålet är "Furniture" >
                                            // Kör koden nedan (alltså alla meddelanden)
            {
                if (item is Product)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(item);
                    Console.WriteLine(item).ID);
                    Console.WriteLine(item).Name);
                    Console.WriteLine(item).Description);
                    Console.WriteLine(item).Cost);
                    Console.WriteLine(item).Warning);
                    Console.WriteLine();
                }
            }

        }
    }
}