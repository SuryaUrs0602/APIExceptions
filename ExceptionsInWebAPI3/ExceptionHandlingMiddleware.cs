
using System.Net;

namespace ExceptionsInWebAPI3
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        //responsible for processing http request
        public async Task InvokeAsync(HttpContext context, RequestDelegate next) //next middleware inside the pipeline 
        {
            try
            {
                await next(context);
            }

            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
