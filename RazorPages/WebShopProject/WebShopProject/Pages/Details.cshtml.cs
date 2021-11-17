using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebShopProject.Pages
{
    public class DetailsModel : PageModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public string Warning { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Weight { get; set; }
        public string Ingredients { get; set; }
        public void OnGet()
        {
        }
    }
}
