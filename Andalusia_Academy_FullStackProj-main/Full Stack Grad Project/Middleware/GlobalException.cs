using Full_Stack_Grad_Project.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Full_Stack_Grad_Project.Middleware
{
    public class GlobalException
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalException> _logger;

        public GlobalException(RequestDelegate next, ILogger<GlobalException> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (NotFoundException ex)
            {
                await WriteProblemDetails(context, 404, "Not Found", ex.Message);
            }
            catch (ArgumentException ex)
            {
                await WriteProblemDetails(context, 400, "Bad Request", ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unhandled exception");
                await WriteProblemDetails(context, 500, "Server Error", ex.Message);
            }
        }

        private static async Task WriteProblemDetails(HttpContext context, int code, string title, string message)
        {
            context.Response.StatusCode = code;
            context.Response.ContentType = "application/problem+json";
            var problem = new ProblemDetails { Title = title, Detail = message, Status = code };
            await context.Response.WriteAsJsonAsync(problem);
        }
    }
}