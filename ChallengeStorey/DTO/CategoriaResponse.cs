namespace ChallengeStorey.DTO
{
	public class CategoriaResponse
	{
		public string categoria { get; set; }
		public List<CategoriaItemResponse> items { get; set; } = [];
	}

	public class CategoriaItemResponse
	{
		public string elemento { get; set; }
		public decimal valor { get; set; }
	}
}
