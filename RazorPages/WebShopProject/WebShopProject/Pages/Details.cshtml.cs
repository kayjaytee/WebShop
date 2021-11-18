using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using WebShopProject.Data;
using WebShopProject.Models;

namespace WebShopProject.Pages
{
    public class DetailsModel : PageModel
    {

        public IEnumerable<ProductModel> Products { get; set; }

        public List<ProductModel> ShoppingCart { get; set; }

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public string Description { get; set; }
        [BindProperty] public decimal Cost { get; set; }
        [BindProperty] public string Warning { get; set; }
        [BindProperty] public float Height { get; set; }
        [BindProperty] public float Width { get; set; }
        [BindProperty] public float Weight { get; set; }
        [BindProperty] public string Ingredients { get; set; }
        public void OnGet(string productid) //Skickar c# kod
        {
            

            Products = ProductManager.GetProducts(); //Hämtar listan, sen returnerar
            if (productid != null)
            {
                Products = Products.Where(x => x.ID == productid);
                //cartManager.AddToShoppingCart(product);
            }
        }

        public void OnPost() //Returnerar kod
        {
            
            Products = ProductManager.FindAll(); //returnerar bara

            Console.WriteLine("Returning List:");
            foreach (var item in ShoppingCart)
            {
                Console.WriteLine(item.ID);
            }
        }
    }

}

