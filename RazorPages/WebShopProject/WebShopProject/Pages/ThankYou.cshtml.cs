using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShopProject.Data;

namespace WebShopProject.Pages
{
    public class ThankYouModel : PageModel
    {
        public void OnGet()
        {
            CartManager.ClearShoppingCart();
        }
    }
}
