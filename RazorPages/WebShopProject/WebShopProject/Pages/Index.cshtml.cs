using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopProject.Models;

namespace WebShopProject.Pages
{
    public class IndexModel : PageModel
    {
        public List<ProductModel> Products { get; private set; }

        public void OnGet()
        {
            ProductModel productmodel = new ProductModel();
            Products = productmodel.FindAll();//kopplat till problem i Productmanager.cs -> PROBLEM: Returnerar null
        }
    }
}
