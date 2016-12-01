using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace error_handle
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var source = actionExecutedContext.Request.RequestUri.ToString();
            var method = actionExecutedContext.Request.Method; 
            var exception = actionExecutedContext.Exception;
            ExceptionUtility.LogException(exception, String.Format("{0} ---- Method: {1}", source, method));
        }
    }
}