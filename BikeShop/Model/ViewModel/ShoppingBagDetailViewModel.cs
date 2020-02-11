using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.ViewModel
{
    public class ShoppingBagDetailViewModel
    {
        public ShoppingBag ShoppingBag{ get; set; }
        public List<ShoppingItem> ShoppingItems { get; set; }
        public int TotaalAantal { get; set; }
        [Display(Name = "Subtotaal")]
        public double SubTotaal { get; set; }
        public double Totaal { get; set; }
        public double Korting { get; set; }
        
    }
}
