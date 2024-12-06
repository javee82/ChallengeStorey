using ChallengeStorey.Comun.Wrapper;
using ChallengeStorey.Data.Models;

namespace ChallengeStorey.Service
{
    public interface IStoreyService
	{
		Task<IEnumerable<Categoria>> GetCategorias();
	}
}
