using ChallengeStorey.Data;
using ChallengeStorey.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ChallengeStorey.Repository
{
	public class CategoriaRepository : IRepository<Categoria, int>
	{
		private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

		public async Task<IEnumerable<Categoria>> GetAllAsync() => await _context.Categorias.Include(i => i.Items).ToListAsync();

	}
}
