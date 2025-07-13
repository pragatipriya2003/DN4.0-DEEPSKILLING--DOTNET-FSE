using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace SwaggerDemo.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            // Write the error to a file (logs/errors.txt)
            var logPath = Path.Combine(Directory.GetCurrentDirectory(), "logs");
            Directory.CreateDirectory(logPath);

            var filePath = Path.Combine(logPath, "errors.txt");
            File.AppendAllText(filePath, $"[{DateTime.Now}] {exception.Message}{Environment.NewLine}");

            // Replace ExceptionResult with standard ObjectResult
            context.Result = new ObjectResult(new
            {
                Message = "An unexpected error occurred.",
                Details = exception.Message
            })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
