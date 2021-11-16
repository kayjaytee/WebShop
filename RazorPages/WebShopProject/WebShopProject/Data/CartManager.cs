using System.Collections.Generic;
using WebShopProject.Models;

namespace WebShopProject.Data
{
    public class CartManager
    {
        public List<ProductModel> ShoppingCart { get; set; } = new List<ProductModel>();

        public List<ProductModel> GetShoppingCart()
        {
            return ShoppingCart;
        }

        public List<ProductModel> AddToShoppingCart(ProductModel shoppingcart)
        {
            ShoppingCart.Add(shoppingcart);
            return ShoppingCart;
        }

    }
}
