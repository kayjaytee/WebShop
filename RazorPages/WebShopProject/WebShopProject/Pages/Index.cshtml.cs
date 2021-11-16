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

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public decimal Cost { get; set; }

        public void OnGetAddToShoppingCart(string id)
        {
        


        }


        public void OnGet() //Skickar c# kod
        {
            ProductManager productManager = new ProductManager();
            Products = productManager.GetProducts(); //Hämtar listan, sen returnerar

            
        }

        public void OnPost() //Returnerar kod
        {
            ProductManager productManager = new ProductManager();
            Products = productManager.FindAll(); //returnerar bara
        }

    }
}
