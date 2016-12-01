using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace error_handle
{
    public class ExceptionUtility
    {
        private ExceptionUtility()
        { }
        public static void LogException(Exception exc, string source)
        {
            if (!Directory.Exists(HttpContext.Current.Server.MapPath("~/Errors")))
            {
               Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/Errors"));
            }
            string logFile = String.Format("~/Errors/{0}.txt", DateTime.Now.ToString("dd_MM_yyyy") );//
            logFile = HttpContext.Current.Server.MapPath(logFile);
            StreamWriter sw = new StreamWriter(logFile, true); //第二个参数,保存原来数据
            sw.WriteLine("********** {0} **********", DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss"));
            if (exc.InnerException != null)
            {
                sw.Write("Inner Exception Type: ");
                sw.WriteLine(exc.InnerException.GetType().ToString());
                sw.Write("Inner Exception: ");
                sw.WriteLine(exc.InnerException.Message);
                sw.Write("Inner Source: ");
                sw.WriteLine(exc.InnerException.Source);
                if (exc.InnerException.StackTrace != null)
                {
                    sw.WriteLine("Inner Stack Trace: ");
                    sw.WriteLine(exc.InnerException.StackTrace);
                }
            }
            sw.Write("Exception Type: ");
            sw.WriteLine(exc.GetType().ToString());
            sw.WriteLine("Exception: " + exc.Message);
            sw.WriteLine("Source: " + source);
            sw.WriteLine("Stack Trace: ");
            if (exc.StackTrace != null)
            {
                sw.WriteLine(exc.StackTrace);
                sw.WriteLine();
            }
            sw.Close();
            //HttpContext.Current.Server.Transfer("some error page");
        }
    }
}
