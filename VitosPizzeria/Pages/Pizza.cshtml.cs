using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VitosPizzeria.Models;

namespace VitosPizzeria.Pages
{
	public class PizzaModel : PageModel
	{
		public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() {
         new PizzasModel()
        {
            ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4},
        new PizzasModel()
        {
            ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4},
        new PizzasModel()
        {
            ImageTitle = "Hawaiian",
                PizzaName = "Hawaiian",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Pineapple=true,
                FinalPrice = 4}

};

        

		public void OnGet() {
		}
	}
}

