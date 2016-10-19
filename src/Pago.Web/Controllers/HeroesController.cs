using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pago.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Pago.Web.Controllers
{
    [Route("api/[controller]")]
    public class HeroesController : Controller
    {
		private readonly PagoDbContext _context;

		public HeroesController(PagoDbContext context)
		{
			_context = context;
		}

		// GET api/values
		[HttpGet]
		public IEnumerable<Hero> Get()
		{
			return _context.Heroes.ToList();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public async Task<Hero> Get(int id) => await _context.Heroes.FirstOrDefaultAsync(x => x.id == id);

		// POST api/values
		[HttpPost]
		public async Task Post([FromBody]Hero hero)
		{
			_context.Heroes.Add(hero);
			await _context.SaveChangesAsync();
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public async Task Put(int id, [FromBody]Hero value)
		{
			_context.Update(value);
			await _context.SaveChangesAsync();
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public async Task Delete(int id)
		{
			var hero = await _context.Heroes.FirstOrDefaultAsync(x => x.id == id);
			if (hero != null)
			{
				_context.Remove(hero);
				await _context.SaveChangesAsync();
			}
		}
	}
}
