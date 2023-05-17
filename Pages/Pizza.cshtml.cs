using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using cPizza.Models;

namespace cPizza.Pages
{
    public class Pizza : PageModel
    {
        private readonly ILogger<Pizza> _logger;

        public Pizza(ILogger<Pizza> logger)
        {
            _logger = logger;
        }
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita", PizzaName="Magerita",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=4},
            new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian",BasePrice=2,TomatoSauce=true,Cheese=true,Chicken=true,GreenPeppers=true,FinalPrice=8},
            new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara",BasePrice=2,Mushrooms=true,TomatoSauce=true,Cheese=true,FinalPrice=6},
            new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast",BasePrice=2,TomatoSauce=true,Cheese=true,Chicken=true,GroundBeef=true,FinalPrice=9},
            new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom",BasePrice=2,TomatoSauce=true,Cheese=true,Mushrooms=true,Pineapple=true,FinalPrice=6},
        };

        public void OnGet()
        {
        }
    }
}