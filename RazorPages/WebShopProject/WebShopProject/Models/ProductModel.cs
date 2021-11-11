using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class ProductModel
    {

        private List<Product> Products;


        public ProductModel()
        {
            Products = new List<Product>()
            {
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
            };
        }

        public List<ProductModel> FindAll()
        {
            return Products;
        }

        public ProductModel FindID(string id)
        {
            return Products.Where(p => p.ID == id).FirstOrDefault;
        }
    }

}
}
