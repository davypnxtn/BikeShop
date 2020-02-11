using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FirstName { get; set; }
        public ICollection<ShoppingBag> ShoppingBags { get; set; }
    }
}
