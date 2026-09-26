using Full_Stack_Grad_Project.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Full_Stack_Grad_Project.Middleware
{
    public class GlobalException : Exception
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
            catch (ArgumentException ex)
            {
                await WriteProblemDetails(context, 400, "title", ex.Message);
            }
            catch (NotFoundException ex)
            {
                await WriteProblemDetails(context, 404, "title", ex.Message);
            }

        }
        public async Task WriteProblemDetails(HttpContext context, int code, string title, string message)
        {
            context.Response.StatusCode = code;
            context.Response.ContentType = "application/problem+json";
            var problem = new ProblemDetails
            {
                Title = title,
                Detail = message,
                Status = code
            };
            await context.Response.WriteAsJsonAsync(problem);

        }
    }
}
