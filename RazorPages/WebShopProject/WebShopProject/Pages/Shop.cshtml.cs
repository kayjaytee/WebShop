using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShopProject.Data;
using WebShopProject.Models;

namespace WebShopProject.Pages.Shared
{
    public class ShopModel : PageModel
    {
        public List<ProductModel> Products { get; set; }

        public string SearchString { get; set; }


        public List<ProductModel> ShoppingCart { get; set; }

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public decimal Cost { get; set; }

        public void OnGet(string cartid) //Skickar c# kod
        {
            ProductManager productManager = new ProductManager();
            CartManager cartManager = new CartManager();

            Products = productManager.GetProducts(); //Hämtar listan, sen returnerar
            ShoppingCart = cartManager.GetShoppingCart();
            if (cartid != null)
            {
                var product = Products.Where(x => x.ID == cartid).FirstOrDefault();
                cartManager.AddToShoppingCart(product);
            }
        }

        public void OnPost() //Returnerar kod
        {
            ProductManager productManager = new ProductManager();
            Products = productManager.FindAll(); //returnerar bara

            Console.WriteLine("Returning List:" + productManager);
            foreach (var item in ShoppingCart)
            {
                Console.WriteLine(item.ID);
            }


        }
    }
}
