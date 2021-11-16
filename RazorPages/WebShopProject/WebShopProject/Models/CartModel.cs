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

        public int Quanitity { get; set; }



    }
}
