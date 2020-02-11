using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    public class ShoppingItem
    {
        public int ShoppingItemID { get; set; }
        [Display(Name = "Hoeveelheid")]
        public int Quantity { get; set; }
        public int ShoppingBagID { get; set; }
        public int ProductID { get; set; }
        public ShoppingBag ShoppingBag { get; set; }
        public Product Product { get; set; }
        [NotMapped]
        [Display(Name = "Subtotaal")]
        public double SubTotaal {
            get
            {
                return decimal.ToDouble(Product.Price) * Quantity;
            }
            private set { }
        }

    }
}
