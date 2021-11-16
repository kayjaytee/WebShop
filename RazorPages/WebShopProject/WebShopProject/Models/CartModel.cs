using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class CartModel
    {
        public virtual ProductModel Product { get; set; }
        public string ID { get; set; }
        public int Quantity { get; set; }

        public CartModel(ProductModel Product)
        {
            Product.ID =
        }

        public static List<CartModel> AddToShoppingCart()
        {
            List<CartModel> shoppingcart = new List<CartModel>();

            shoppingcart.Add(new CartModel());

            return shoppingcart;
        }

    }
}
