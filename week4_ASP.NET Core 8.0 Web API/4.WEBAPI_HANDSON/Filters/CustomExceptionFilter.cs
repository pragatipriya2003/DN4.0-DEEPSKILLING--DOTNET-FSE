using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace WebApiLab3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var logPath = "ExceptionLog.txt";
            var logMessage = $"[{DateTime.Now}] Exception: {exception.Message}\nStackTrace: {exception.StackTrace}\n\n";

            File.AppendAllText(logPath, logMessage);

            context.Result = new ObjectResult("Something went wrong. Please contact support.")
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;
        }
    }
}
