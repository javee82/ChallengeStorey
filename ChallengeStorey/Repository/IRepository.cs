namespace ChallengeStorey.Repository
{
	public interface IRepository<T, TKey>
	{
		Task<IEnumerable<T>> GetAllAsync();
	}
}
