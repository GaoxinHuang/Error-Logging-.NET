using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace error_handle
{
    public class MvcExceptionFilterAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var source = filterContext.HttpContext.Request.Url.ToString(); //"http://localhost:20646/home/index"
            //var source = filterContext.HttpContext.Request.RawUrl;// "/home/index"

            var method = filterContext.HttpContext.Request.HttpMethod;
            var exception = filterContext.Exception;
            ExceptionUtility.LogException(exception, String.Format("{0} ---- Method: {1}", source, method));
        }
    }
}