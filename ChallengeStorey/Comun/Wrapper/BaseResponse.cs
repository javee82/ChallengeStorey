namespace ChallengeStorey.Comun.Wrapper
{
	public class BaseResponse
	{
		public bool Success { get; set; }
		public string ErrorMessage { get; set; }
		public object Body { get; set; }
	}
}
