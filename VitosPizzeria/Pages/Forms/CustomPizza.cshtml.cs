using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VitosPizzeria.Models;

namespace VitosPizzeria.Pages.Forms
{
	public class CustomPizzaModel : PageModel
	{ 
		[BindProperty]
		public PizzasModel Pizza { get; set; }
		public float PizzaPrice { get; set; }

		public void OnGet() {
		 }

		public IActionResult OnPost() {
			PizzaPrice = Pizza.BasePrice;
			if (Pizza.BellPepper) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Chicken) PizzaPrice += 2;
            if (Pizza.Mushroom) PizzaPrice += 1;
            if (Pizza.Onion) PizzaPrice += 1;
            if (Pizza.Pepperoni) PizzaPrice += 2;
            if (Pizza.Pineapple) PizzaPrice += 1;
			return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
	}
}

