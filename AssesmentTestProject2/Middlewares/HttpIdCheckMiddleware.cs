using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace AssesmentTestProject2.Middlewares
{
    public class HttpIdCheckMiddleware
    {
        private readonly RequestDelegate _next;

        public HttpIdCheckMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            bool mustReturnError = false;
            string idAsString = context.Request.Query["Id"];
            if (idAsString != null)
            {
                if (int.TryParse(idAsString, out var id) && id == 2)
                {
                    mustReturnError = true;
                }
            }

            if (mustReturnError)
            {
                var responseData = new { message = "You are not allowed to use Id = 2" };

                var jsonResponse = JsonConvert.SerializeObject(responseData);

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;

                await context.Response.WriteAsync(jsonResponse);
            }
            else
            {
                await _next(context);
            }
        }
    }
}
