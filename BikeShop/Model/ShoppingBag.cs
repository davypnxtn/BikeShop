using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ShoppingBag
    {
        public int ShoppingBagID { get; set; }
        public DateTime Date { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ShoppingItem> ShoppingItems { get; set; }
    }
}
