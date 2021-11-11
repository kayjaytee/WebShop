using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class ProductModel
    {

        private List<Product> Products;

        //jag har lagt till productmodels med alla kategorier, behövs bara förtydligande av olika föremål och det går att lägga
        //till om man så önskar. Jag la de ny-genererade produkterna i #regioner bara för att förtydliga ordningen
        //Nedanför har jag försökt skapa metoder för att kunna söka på olika prylar, men behöver arbeta lite mer på det (och nu är jag trött)

        //Metoderna ska kunna hänvisas till pages senare

        public ProductModel()
        {
            Products = new List<Product>()
            {
                #region Furniture
                new Furniture()
                {
                    ID = "f01",
                    Name = "Lergoblin",
                    Image = "image here",
                    Description = "En liten figur som sjunger tvåstämmigt den kända ”Kloaksonaten” – inte särskilt vacker melodi, men underhållande!",
                    Cost = 50,
                    Height = 0.3d,
                    Width = 0.3d,
                    Weight = 0.2d,
                    Warning = "Varning: Avsaknad av avstängingsläge förekommer."
                },

                new Furniture()
                {
                    ID = "f02",
                    Name = "Varma Muggen",
                    Image = "image here",
                    Description = "Är du inte trött på att behöva värma kaffet varje gång du glömt av att dricka den sista slurpen? "
                                  + "Oroa dig inte, denna magiska mugg är förtrollad med värmande magi och du behöver nu aldrig stressa dig i kaffet!",
                    Cost = 750,
                    Height = 0.5f,
                    Width = 0.5f,
                    Weight = 1,
                    Warning = "Vi ansvarar inte för eventuella för brända tungor under kaffe incidenter."
                },

                new Furniture()
                {
                    ID = "f03",
                    Name = "Svävande Bärstol",
                    Image = "image here",
                    Description = "Vill du kunna sväva utan större ansträngning upp till femton meter över marken?"
                                  + "Denna lyxiga bärstol av ädelträ styrs med dina tankar och kan flyga upp till 100 kilometer i timmen!",
                    Cost = 55000,
                    Height = 2.5f,
                    Width = 1.5f,
                    Weight = 300,
                    Warning = "En explosiv ökning av fart kan bidra till en väldigt flygande åktur - även ur stolen!"
                },
                
                new Furniture()
                {
                    ID = "f04",
                    Name = "Magisk Självfejande Sopkvast",
                    Image = "image here",
                    Description = "Trött på städa? Eller kanske sugen på en snabb flygtur?"
                                  + "Denna magiska kvast är självfejande och städar åt dig i samtliga rum och är samt kapabel för en snabb flygresa. Ett populärt föremål i Häxornas' Krokryggsförening.",
                    Cost = 4000,
                    Height = 1.5f,
                    Width = 0.10f,
                    Weight = 2,
                    Warning = "Säkerhetsbälte ingår inte för flygturer."
                },
                
                new Furniture()
                {
                    ID = "f05",
                    Name = "BESTÄM NI",
                    Image = "image here",
                    Description = "BESTÄM NI"
                                  + "Plusset är är endast för att skapa utrymme när du skriver, så man slipper eviga rader som går utanför skärmen, typ som nu.",
                    Cost = 0,
                    Height = 0f,
                    Width = 0f,
                    Weight = 0,
                    Warning = "Hitta på nåt kul"
                },
                
                new Furniture()
                {
                    ID = "f05",
                    Name = "BESTÄM NI",
                    Image = "image here",
                    Description = "BESTÄM NI"
                                  + "Plusset är är endast för att skapa utrymme när du skriver, så man slipper eviga rader som går utanför skärmen, typ som nu.",
                    Cost = 0,
                    Height = 0f,
                    Width = 0f,
                    Weight = 0,
                    Warning = "Hitta på nåt kul"
                },
                #endregion Furniture
                #region Potion
                new Potion()
                {
                    ID = "p06",
                    Name = "Blyfot",
                    Image = "image here",
                    Description = "En passande brygd för någon som känner sig busig! Den som får i sig denna brygd kommer göra ena foten 20 kilo tyngre än den andra.",
                    Cost = 500,
                    Ingredients = "Stortån från ett grinigt troll, hårväxt från en skallig dvärg prästinnas fötter",
                    Warning = "Biverkningar kan förekomma: Dålig balansförmåga, svårt att prova skor."
                },

                new Potion()
                {
                    ID = "p07",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Potion()
                {
                    ID = "p08",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Potion()
                {
                    ID = "p09",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Potion()
                {
                    ID = "p10",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },
                #endregion Potion
                #region Tobacco
                new Tobacco()
                {
                    ID = "t11",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Tobacco()
                {
                    ID = "t12",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Tobacco()
                {
                    ID = "t13",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Tobacco()
                {
                    ID = "t14",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },

                new Tobacco()
                {
                    ID = "t15",
                    Name = "",
                    Image = "image here",
                    Description = "",
                    Cost = 0,
                    Ingredients = "",
                    Warning = ""
                },
                #endregion Tobacco
            };
        }

        public List<Product> FindAll()
        {
            return Products;
        }

        public Product FindID(string id)
        {
            return Products.Where(p => p.ID == id).FirstOrDefault;
        }
    }

}
}
