using System.Net;

namespace MoviesWebApi.Data.Models
{
    public class ApiResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }

        public bool IsSuccess { get; set; } = true;

        public List<string> ErrorMessages { get; set; } = new List<string>();

        public object? Result { get; set; }
    }
}
