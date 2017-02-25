using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace HostelSystem.Web.Api.Utility
{
    public class ValidateIdFormatAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            if (actionContext.ActionArguments.ContainsKey("id"))
            {

                try
                {
                    var id = (Guid)actionContext.ActionArguments["id"];
                }
                catch (NullReferenceException e)
                {
                    actionContext.Response = new HttpResponseMessage(HttpStatusCode.BadRequest);
                }
            }
        }
    }
}