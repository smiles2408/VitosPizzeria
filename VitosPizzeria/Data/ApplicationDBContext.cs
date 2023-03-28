using Microsoft.EntityFrameworkCore;
using VitosPizzeria.Models;

namespace VitosPizzeria.Data
{
	public class ApplicationDBContext: DbContext
	{
		public ApplicationDBContext(DbContextOptions <ApplicationDBContext> options) : base()
		{

		}

		public DbSet <PizzaOrder>  PizzaOrders{ get; set; }
	}
}

