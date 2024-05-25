namespace HeightsBookHub.Domain.Entities.SharedEntities
{
    public class ApiResponse<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<string> Errors { get; set; }
        public T Data { get; set; }
        public int StatusCode { get; set; }

        public ApiResponse(bool isSucceeded, string message, List<string> errors, T data, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            Errors = errors;
            Data = data;
            StatusCode = statusCode;
        }
        public ApiResponse()
        {

        }

        public ApiResponse(bool isSucceeded, string message, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            StatusCode = statusCode;
        }

        public ApiResponse(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public ApiResponse(bool isSucceeded, List<string> errors, T data)
        {
            Succeeded = isSucceeded;
            Errors = errors;
            Data = data;
        }

        public ApiResponse(bool isSucceeded, string message, List<string> errors, int statusCode)
        {
            Succeeded = isSucceeded;
            Message = message;
            Errors = errors;
            StatusCode = statusCode;
        }

        public static ApiResponse<T> Success(T data, string message, int statusCode)
        {
            return new ApiResponse<T>(true, message, new List<string>(), data, statusCode);
        }

        public static ApiResponse<T> Failed(List<string> errors)
        {
            return new ApiResponse<T>(false, errors, default);
        }


        public static ApiResponse<T> Failed(bool isSucceeded, string message, int statusCode, List<string> errors)
        {
            return new ApiResponse<T>(isSucceeded, message, errors, statusCode);
        }

    }
}
