using System;
namespace VitosPizzeria.Models
{
	public class PizzaOrder
	{
		public PizzaOrder()
		{
		}

		public int Id { get; set; }
		public string PizzaName { get; set; }
		public float BasePrice { get; set; }
	}
}

