using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cPizza.Data;
using cPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cPizza.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class Checkout : PageModel
    {
        // private readonly ILogger<Checkout> _logger;

        // public Checkout(ILogger<Checkout> logger)
        // {
        //     _logger = logger;
        // }

        public string PizzaName {get;set;}
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }


        private readonly ApplicationDbContext _context;
        public Checkout(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();

        }

    }
}