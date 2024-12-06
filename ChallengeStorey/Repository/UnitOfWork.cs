using ChallengeStorey.Data;
using ChallengeStorey.Data.Models;

namespace ChallengeStorey.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private AppDbContext _context;
		private CategoriaRepository _categoria;

		public IRepository<Categoria, int> Categorias
		{
			get
			{
				return _categoria ?? (_categoria = new CategoriaRepository(_context));
			}
		}

		public UnitOfWork(AppDbContext context)
		{
			_context = context;
		}
	}
}
