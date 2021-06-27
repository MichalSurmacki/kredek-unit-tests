using System.Reflection;
using Application.Interfaces;
using Application.Repositories;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IDrawingService, DrawingService>();
            services.AddSingleton<DemoRepository>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}