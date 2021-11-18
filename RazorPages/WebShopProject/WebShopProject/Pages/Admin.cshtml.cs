using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebShopProject.Data;
using WebShopProject.Models;

namespace WebShopProject.Pages
{
    public class AdminModel : PageModel
    {

        public List<ProductModel> Products { get; set; }

        [BindProperty] public string ID { get; set; }
        [BindProperty] public string Name { get; set; }
        [BindProperty] public string Image { get; set; }
        [BindProperty] public string Description { get; set; }
        [BindProperty] public decimal Cost { get; set; }
        [BindProperty] public string Warning { get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
           
            ProductManager.GenerateNewProduct(ID, Name, Image, Description, Cost, Warning);
            Console.WriteLine("Return successful");
        }
    }
}
