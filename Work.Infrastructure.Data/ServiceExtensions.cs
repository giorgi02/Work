using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Work.Core.Application.Interfaces;
using Work.Infrastructure.Data.Implementation;

namespace Work.Infrastructure.Data
{
    public static class ServiceExtensions
    {
        public static void AddDataLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
