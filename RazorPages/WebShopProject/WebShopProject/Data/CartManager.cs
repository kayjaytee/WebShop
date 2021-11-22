using System.Collections.Generic;
using WebShopProject.Models;

namespace WebShopProject.Data
{
    public static class CartManager
    {
        public static List<ProductModel> ShoppingCart { get; set; } = new List<ProductModel>();

        public static List<ProductModel> GetShoppingCart()
        {
            return ShoppingCart;
        }

        public static List<ProductModel> AddToShoppingCart(ProductModel shoppingcart)
        {
            ShoppingCart.Add(shoppingcart);
            return ShoppingCart;
        }

        public static List<ProductModel> ClearShoppingCart() //Körs automatiskt på "ThankYou"
        {                                                    

            ShoppingCart.Clear();

            return ShoppingCart;
        }

    }
}
