namespace API.Errors
{
  public class ApiResponse
  {
    public ApiResponse(int statusCode, string message = null)
    {
      StatusCode = statusCode;
      Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }

    public string GetDefaultMessageForStatusCode(int statusCode)
    {
      return statusCode switch
      {
        400 => "A bad request occured",
        401 => "No authorized",
        404 => "Resource not found",
        500 => "Anything",
        _ => null
      };
    }
  }
}