using ChallengeStorey.Data.Models;
using System.Numerics;

namespace ChallengeStorey.Repository
{
	public interface IUnitOfWork
	{
		public IRepository<Categoria, int> Categorias { get; }
	}
}
