using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopProject.Models;
using System.Data
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShopProject.Data
{
    public class CartManager : PageModel
    {
      public List<Models.ProductModel> GetCart()
      {
            return Data.ProductManager.GetCartItems();
      }



    }
}
