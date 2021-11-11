using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Weight { get; set; }
        public string[] Ingredients { get; set; }
        public string Warning { get; set; }

    }
}
