using System;
using System.Collections.Generic;

namespace WebShopConsoleApp
{

    class Product //Superclass; Models
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

    }



    class Furniture : Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Warning { get; set; }

        public Furniture(int id, string name, string description, decimal cost,
        double width, double height, double weight, string warning)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            Width = width;
            Height = height;
            Weight = weight;
            Warning = warning;
        }


    }

    class Elixir : Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Elixir(int id, string name, string description, decimal cost,
        string[] ingredients, string warning)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }

    }

    class Tobacco : Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

        public Tobacco(int id, string name, string description, decimal cost,
        string[] ingredients, string warning)
        {
            ID = id;
            Name = name;
            Description = description;
            Cost = cost;
            Ingredients = ingredients;
            Warning = warning;
        }

    }


    class Program
    {


        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Furniture(
            0,
            "Lergoblin",
            "En liten figur som sjunger tv�st�mmigt den k�nda �Kloaksonaten� � inte s�rskilt vacker melodi, men underh�llande!",
            50,
            0.3d,
            0.3d,
            0.2d,
            "Varning: En tyst l�ge inkluderas inte i produkten."
            ));

            string[] array = { "En krossad t�nagel fr�n ett troll", "tre nypor troll�rt", "svett fr�n en j�tte" };
            products.Add(new Elixir(
                1,
                "Blyfot",
                "Detta magiska brygd vid konsumption kommer g�ra ena foten tjugo kilo tyngre.",
                100,
                array,
                "Biverkningar kan f�rekomma: Sv�righeter att springa, f�rs�mrad balansf�rm�ga, en.. tung fot."
            ));


            foreach (var item in products)
            {
                if(item is Elixir)
                {
                Console.WriteLine(((Elixir)item));
                Console.WriteLine(((Elixir)item).ID);
                Console.WriteLine(((Elixir)item).Name);
                Console.WriteLine(((Elixir)item).Description);
                Console.WriteLine(((Elixir)item).Cost);
                Console.WriteLine(((Elixir)item).Ingredients); //F�rs�ker komma p� en l�sning f�r hantera arrays
                Console.WriteLine(((Elixir)item).Warning);
                }
            }

        }
    }
}

/*      ID = id;
        Name = name;
        Description = description;
        Cost = cost;
        Ingredients = ingredients;
        Warning = warning;*/
