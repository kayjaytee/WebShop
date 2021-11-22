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
        public IEnumerable<ProductModel> Products { get; set; } //Initierar Listan som IEnumerable för att göra den kompatibel med SearchString

        [BindProperty] public string SearchString { get; set; }

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
                var product = Products.Where(x => x.ID == cartid).FirstOrDefault();
                CartManager.AddToShoppingCart(product);
            }
        }

        public void OnPost() //Returnerar kod
        {
           
            Products = ProductManager.GetProducts(); //returnerar bara

            if (SearchString != null)
            {
                string search = SearchString.ToLower();
                Products = Products.Where(x => x.Name.ToLower().Contains(search));
            }





        }
    }
}
