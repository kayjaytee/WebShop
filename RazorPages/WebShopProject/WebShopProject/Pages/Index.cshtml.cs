using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    


        public List<ProductModel> ShoppingCart { get; set; }

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public decimal Cost { get; set; }

        public void OnGet(string cartid) //Skickar c# kod
        {

            Products = ProductManager.GetProducts(); //Hämtar listan, sen returnerar
            ShoppingCart = CartManager.GetShoppingCart();
            if (cartid != null)
            {
                var product = Products.Where(x => x.ID == cartid).LastOrDefault();
                CartManager.AddToShoppingCart(product);
            }
        }

        public void OnPost() //Returnerar kod
        {
            Products = ProductManager.FindAll(); //returnerar bara



        }

    }
}
