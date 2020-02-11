using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Product
    {
        public int ProductID { get; set; }
        [Display(Name = "Product")]
        public string Name { get; set; }
        [Display(Name = "Prijs")]
        public decimal Price { get; set; }
        public IEnumerable<ShoppingItem> ShoppingItems { get; set; }
    }
}
