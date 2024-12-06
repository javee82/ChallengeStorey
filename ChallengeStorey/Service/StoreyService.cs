
using ChallengeStorey.Data.Models;
using ChallengeStorey.Repository;

namespace ChallengeStorey.Service
{
	public class StoreyService : IStoreyService
	{
		private readonly IUnitOfWork _unitOfWork;
		public StoreyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Categoria>> GetCategorias() => await _unitOfWork.Categorias.GetAllAsync();
	}
}
