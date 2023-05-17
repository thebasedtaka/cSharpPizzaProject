using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cPizza.Data;
using cPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace cPizza.Pages
{
    public class Orders : PageModel
    {
        // private readonly ILogger<Orders> _logger;

        // public Orders(ILogger<Orders> logger)
        // {
        //     _logger = logger;
        // }
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

        private readonly ApplicationDbContext _context;
        public Orders(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}