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

        //private readonly Data.ProductManager _context;

        //public IndexModel(Data.ProductManager context)
        //{
        //    _context = context;
        //}

        public List<ProductModel> Products { get; set; }
        //[BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        //public SelectList SelectListProducts { get; set; }
        //[BindProperty(SupportsGet = true)]

        public List<ProductModel> ShoppingCart { get; set; }

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public decimal Cost { get; set; }

        //public async Task OnGetASync()
        //{

        //    IQueryable<string> productQuery = from p in _context.GetProducts();
        //                                      orderby p.Name
        //                                      select p.Name;


        //    var products = from prod in _context.GetProducts()
        //                   select prod;

        //    if (!string.IsNullOrEmpty(SearchString))
        //    {
        //        products = products.Where(s => s.Name.Contains(SearchString));
        //    }
        //    if (!string.IsNullOrEmpty(prod.Name))
        //    {
        //        products = products.Where(x => x.Name == prod.Name);
        //    }
        //    Name = new List<SelectList>(await )
        //}


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
            foreach(var item in ShoppingCart)
            {
                Console.WriteLine(item.ID);
            }


        }

    }
}
