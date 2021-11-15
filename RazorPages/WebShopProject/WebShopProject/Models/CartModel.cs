using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class CartModel : PageModel
    {

        public List<CartModel> Cart { get; set; }
        public double Total { get; set; }
        public object Product { get; private set; }

        public void Onget()
        {
            var productModel = new ProductModel();
            if (Cart == null)
            {
                Cart = new List<CartModel>();
                Cart.Add(new CartModel
                {
                    Product = productModel.ID,
              
                });


            }
            foreach (var item in Cart)
            {
                Console.WriteLine(item.ViewData);
            }
        }





        /*
        [Key] public string ID { get; set; }
        public int Quanitity { get; set; }
        public virtual ProductModel Product { get; set; }

        */

    }
}
