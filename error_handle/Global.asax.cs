using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using System.Text;
using System.IO;

namespace error_handle
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            //GlobalFilters.Filters.Add(new MvcExceptionFilterAttribute());
            //GlobalConfiguration.Configuration.Filters.Add(new ApiExceptionFilterAttribute());
        }

        #region For MVC
        //void Application_Error(object sender, EventArgs e)
        //{
        //    HttpContext con = HttpContext.Current;
        //    var exc = Server.GetLastError();
        //    // Open the log file for append and write the log
        //    var HttpEx = exc as HttpException;
        //    if (HttpEx != null && HttpEx.GetHttpCode() == 404)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        string source = con.Request.Url.ToString();
        //        string method = con.Request.HttpMethod;
        //        ExceptionUtility.LogException(exc, String.Format("{0} ---- Method: {1}", source, method));
        //        Server.Transfer("/error.html");
        //    }
        //}
        #endregion
    }
}