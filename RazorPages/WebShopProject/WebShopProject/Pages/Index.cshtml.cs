using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopProject.Models;
using WebShopProject.Data;

namespace WebShopProject.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProductModel> Products { get; set; }


        public void OnGet()
        {
            
            Data.ProductManager productManager = new Data.ProductManager();
            productManager.GetProducts();
            productManager.FindAll();


        }

        public void OnPost()
        {
            Products = ProductManager.GetProducts(); //Något är fel objekt-referensen här och returnerar därför null.
                                                     //Försökt grubbla på detta och kollat gamla videos med Mikaels lektioner men fungerade ändå inte
                                                     //Säkert enklare än förväntat; men för disträ för att komma på det för tillfället
                                                     //Har utvecklat HTML sidan, förberedande för c# koden
                                                     //Lagt till lite fler grejer i Products med
                                                     //Löser vi denna del så borde det fungera, tror det är sista strået!
        }
    }
}
