using Newtonsoft.Json;
using Serilog;
using System.Net;
using System.Text;
using Teleperformance.Final.Project.Application.Exceptions;

namespace Teleperformance.Final.Project.WebAPI.Middleware
{

    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            HttpStatusCode statusCode = HttpStatusCode.InternalServerError;
            string result = JsonConvert.SerializeObject(new ErrorDeatils
            {
                ErrorMessage = exception.Message,
                ErrorType = "Hata:"
            });
            StringBuilder strResultBuilder = new StringBuilder();
            switch (exception)
            {
                case BadRequestException badRequestException:
                    statusCode = HttpStatusCode.BadRequest;
                    break;
                case ValidationException validationException:
                    statusCode = HttpStatusCode.BadRequest;

                    break;
                case NotFoundException notFoundException:
                    statusCode = HttpStatusCode.NotFound;
                    break;

                //case DatabaseValidationException databaseValidationException:
                //    statusCode = HttpStatusCode.BadRequest;                                                     
                //    break;


                case Exception ex:
                    strResultBuilder.Append(JsonConvert.SerializeObject(ex.Message));
                    strResultBuilder.Append(JsonConvert.SerializeObject(ex.InnerException));
                    strResultBuilder.Append(JsonConvert.SerializeObject(ex.Data));
                    break;
                default:

                    break;
            }

            context.Response.StatusCode = (int)statusCode;


            Log.Logger = new LoggerConfiguration()
                 .MinimumLevel.Debug()
                 .WriteTo.Console()
                  .WriteTo.File($"Logs\\{DateTime.Now.ToString("dd-MM-yyyy")}-log.txt",
                     outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                 .CreateLogger();

            Log.Error(strResultBuilder.ToString());

            return context.Response.WriteAsync(strResultBuilder.ToString());
        }
    }

    public class ErrorDeatils
    {
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }

}

