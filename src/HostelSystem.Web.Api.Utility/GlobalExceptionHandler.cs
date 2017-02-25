using System.Net;
using System.Net.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;
using HostelSystem.Service.CustomException;

namespace HostelSystem.Web.Api.Utility
{
    public class GlobalExceptionHandler : ExceptionHandler
    {
        public override void Handle(ExceptionHandlerContext context)
        {
            if (context.Exception is NotFoundException)
            {
                var errorMessage = string.Format("{0}", context.Exception.Message);
                var response = context.Request.CreateResponse(HttpStatusCode.NotFound,
                    new
                    {
                        Message = errorMessage
                    });

                response.Headers.Add("NotFound", errorMessage);
                context.Result = new ResponseMessageResult(response);
            }
            else
            {
                const string errorMessage =
                    "Unexpected error occured. Please contact Administrator.";
                var response = context.Request.CreateResponse(HttpStatusCode.InternalServerError,
                    new
                    {
                        Message = errorMessage
                    });

                response.Headers.Add("InternalServerError", errorMessage);
                context.Result = new ResponseMessageResult(response);
            }
        }
    }
}