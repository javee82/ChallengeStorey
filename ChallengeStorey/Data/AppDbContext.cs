using ChallengeStorey.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeStorey.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{
		}

		public virtual DbSet<Categoria> Categorias { get; set; }
		public virtual DbSet<Item> Items { get; set; }
	}
}
