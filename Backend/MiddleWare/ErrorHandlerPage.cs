using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Backend.MiddleWare
{
    public class ErrorHandlerPage
    {
        private readonly RequestDelegate _next;
        public ErrorHandlerPage(RequestDelegate next)
        {
            this._next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

                //  Handle specific HTTP status codes
                switch (context.Response.StatusCode)
                {
                    case 404:
                        context.Response.Redirect("/PageNotFound");
                        break;
                }
            }

            finally
            {
            }
        }

    }
}