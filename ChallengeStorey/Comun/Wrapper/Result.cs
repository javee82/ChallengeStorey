namespace ChallengeStorey.Comun.Wrapper
{
    public class Result : IResult
	{
		public List<string> Messages { get; set; } = new List<string>();
		public bool Succeeded { get; set; }
	}

	public class Result<T> : Result, IResult<T>
	{
		public Result()
		{
		}
		public T Data { get; set; }

		public static Result<T> Success(T data, string message)
		{
			return new Result<T> { Succeeded = true, Data = data, Messages = new List<string> { message } };
		}
		public new static Result<T> Fail(string message)
		{
			return new Result<T> { Succeeded = false, Messages = new List<string> { message } };
		}
		public new static Task<Result<T>> FailAsync(string message)
		{
			return Task.FromResult(Fail(message));
		}
		public static Task<Result<T>> SuccessAsync(T data, string message)
		{
			return Task.FromResult(Success(data, message));
		}
	}
}
