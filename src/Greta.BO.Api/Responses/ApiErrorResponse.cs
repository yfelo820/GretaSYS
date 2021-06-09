namespace Greta.BO.Api.Responses
{
    public class ApiErrorResponse
    {
        public ApiErrorResponse(string msg)
        {
            Message = msg;
        }

        public int Status { get; set; }
        public string Message { get; set; }
        public string Detail { get; set; }
    }
}
