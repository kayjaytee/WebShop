using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Enitity;

namespace WebShopProject.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("test")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CartModel> ShoppingCartItems { get; set; }
    }
}
