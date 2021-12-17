using Microsoft.AspNetCore.Builder;
using WEB_953501_Prokopovich.Middleware;

namespace WEB_953501_Prokopovich.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this
        IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}
