using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolutionBD.Middleware
{
    public static class MultipleMiddlewareConfig
    {
        public static IApplicationBuilder UseCustomMultipleHandler(
   this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }
}
