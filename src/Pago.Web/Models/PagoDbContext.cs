using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pago.Web.Models
{
	public class PagoDbContext : DbContext
	{

		public PagoDbContext(DbContextOptions options) : base(options)
		{
		}

		protected PagoDbContext()
		{
		}

		public DbSet<Hero> Heroes { get; set; }
	}
}
