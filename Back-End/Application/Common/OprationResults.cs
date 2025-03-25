using Domain.Entities;

namespace Application.Common
{
    public class BookOprationResult
    {
        public string Message { get; set; }
        public Book Request {get; set;}

        private BookOprationResult(Book request,string message)
        {
            Message = message;
            Request = request;
        }

        public static BookOprationResult Success(string message , Book request) =>
            new(message:message,request:request);
        public static BookOprationResult Failure(string message) => 
            new(message:message,request:null);

    }
}