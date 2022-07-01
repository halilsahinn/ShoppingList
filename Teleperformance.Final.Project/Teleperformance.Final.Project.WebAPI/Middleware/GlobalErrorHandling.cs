using System.Net;
using System.Text.Json;

namespace Teleperformance.Final.Project.WebAPI.Middleware
{
    public class GlobalErrorHandling
    {
        private readonly RequestDelegate _next;
        public GlobalErrorHandling(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception err)
            {

                context.Response.ContentType = "application/json";

                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                //switch (err)
                //{
                //    case ApplicationException e:
                //        break;

                //    default:

                //        break;
                //}

                //{ message:"", statusCode:500 }

                var json = JsonSerializer.Serialize(new
                {
                    message = err.Message,
                    statusCode = (int)HttpStatusCode.InternalServerError
                });



                await context.Response.WriteAsync(json);
            }
        }

    }
}
