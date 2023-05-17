using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cPizza.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2;
        public float FinalPrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Chicken { get; set; }
        public bool GroundBeef { get; set; }
        public bool Pineapple { get; set; }
        public bool Mushrooms { get; set; }
        public bool GreenPeppers {get;set;}
        public bool RedPeppers { get; set; }

    }
}