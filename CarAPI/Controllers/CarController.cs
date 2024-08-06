using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorCalendar.Models;

namespace CarAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CarController : ControllerBase
	{
		private readonly AppDbContext _context;

		public CarController(AppDbContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<KoreseddelModel>>> GetKøresedler()
		{
			return await _context.Køresedler.ToListAsync();
		}

        [HttpPost("cars")]
        public async Task<ActionResult<KoreseddelModel>> PostKøreseddel(KoreseddelModel køreseddel)
		{
			_context.Køresedler.Add(køreseddel);
			await _context.SaveChangesAsync();
				
			return CreatedAtAction(nameof(GetKøresedler), new { id = køreseddel.KoreseddelModelId }, køreseddel);
		}

	}
}
