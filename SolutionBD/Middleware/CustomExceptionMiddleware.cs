using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SolutionBD.Domain;
using SolutionBD.Service.CustomException;

namespace SolutionBD.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (CustomHttpException ex)
            {

                await HandleException(httpContext, ex);
            }
            catch (Exception ex)
            {

                await HandleException(httpContext, ex);
            }
        }

        private Task HandleException(HttpContext httpContext, Exception ex)
        {
            int statusCode = (int)HttpStatusCode.InternalServerError;
            if (ex is CustomHttpException)
            {
                CustomHttpException se = ex as CustomHttpException;
                statusCode = se.GetHttpCode();
            }

            httpContext.Response.ContentType = "application/json";
            httpContext.Response.StatusCode = statusCode;
            var result = new CustomHttpExceptionDTO { Message = ex.Message, MessageCode = statusCode };


            return httpContext.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }
    }


}
