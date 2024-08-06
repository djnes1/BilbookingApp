using Microsoft.EntityFrameworkCore;
using BlazorCalendar.Models;

namespace CarAPI
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}

		public DbSet<KoreseddelModel> Køresedler { get; set; }
	}
}
