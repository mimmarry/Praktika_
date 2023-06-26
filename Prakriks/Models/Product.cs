using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakriks.Products
{
    public class Product
    {
        [Key]

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Manufacturer { get; set; } 
        public bool Availability { get; set; }
        public int Price { get; set; }

       
    }
}
