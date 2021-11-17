using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using WebShopProject.Data;
using WebShopProject.Models;

namespace WebShopProject.Pages
{
    public class DetailsModel : PageModel
    {

        public List<ProductModel> Products { get; set; }

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
