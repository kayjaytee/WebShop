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

        void Generate

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            products.Add(
            new Furniture
            {
            ID = 02,
            Name = "Lergoblin",
            Description = "En liten figur som sjunger tv�st�mmigt den k�nda �Kloaksonaten� � inte s�rskilt vacker melodi, men underh�llande!",
            Cost = 50,
            Width = 0.3d,
            Height = 0.3d,
            Weight = 0.2d,
            Warning = "Varning: En tyst l�ge inkluderas inte i produkten."
        });
            products.Add(
            new Elixir
            {
                ID = 01,
                Name = "Blyfot",
                Description = "Denn flaskan har just nu ingen best�mt text, men det kommer!",
                Cost = 100,
                Ingredients = ("En krossad t�nagel fr�n ett troll", "tre nypor troll�rt", "svett fr�n en j�tte"), //F�rs�ker komma p�  hur man ska implantera en array-l�sning h�r
                Warning = "Biverkningar kan f�rekomma: H�g aptit, f�rs�mrad balansf�rm�ga, en stor...fot"
            });




        }
    }
}

/*      ID = id;
        Name = name;
        Description = description;
        Cost = cost;
        Ingredients = ingredients;
        Warning = warning;*/
