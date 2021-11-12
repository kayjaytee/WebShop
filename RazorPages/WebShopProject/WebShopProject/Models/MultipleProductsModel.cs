using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopProject.Models
{
    public class MultipleProductsModel //En extra Modelklass för att eventuella dubbel-eller multiköp av samma product, psuedokod
    {
        public ProductModel ProductModel { get; set; }

        public int Quantity { get; set; }
    }
}
