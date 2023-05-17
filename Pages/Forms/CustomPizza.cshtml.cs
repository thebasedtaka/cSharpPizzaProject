using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using cPizza.Models;

namespace cPizza.Pages.Forms
{
    public class CustomPizza : PageModel
    {
        // private readonly ILogger<CustomPizza> _logger;

        // public CustomPizza(ILogger<CustomPizza> logger)
        // {
        //     _logger = logger;
        // }
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce)PizzaPrice += 1;
            if (Pizza.Cheese)PizzaPrice += 1;
            if (Pizza.GroundBeef)PizzaPrice += 1;
            if (Pizza.Chicken)PizzaPrice += 1;
            if (Pizza.Cheese)PizzaPrice += 1;
            if (Pizza.Pineapple)PizzaPrice += 1;
            if (Pizza.Mushrooms)PizzaPrice += 1;
            if (Pizza.GreenPeppers)PizzaPrice += 1;
            if (Pizza.RedPeppers)PizzaPrice += 1;
            
            return RedirectToPage("/Checkout/Checkout",new {Pizza.PizzaName,PizzaPrice});
        }
        public void OnGet()
        {
        }
    }
}