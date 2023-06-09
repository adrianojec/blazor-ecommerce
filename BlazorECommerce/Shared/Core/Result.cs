namespace BlazorECommerce.Shared.Core;

public class Result<T>
{
   public bool isSuccess { get; set; }
   public T Value { get; set; } = default!;
   public string Error { get; set; } = string.Empty;

   public static Result<T> Success(T value) => new Result<T>
   {
      isSuccess = true,
      Value = value,
   };


   public static Result<T> Failure(string error) => new Result<T>
   {
      isSuccess = false,
      Error = error,
   };
}
