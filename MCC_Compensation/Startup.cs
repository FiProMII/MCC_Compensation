using API.Context;
using API.Repositories.Data;
//using API.Middleware;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Microsoft.OpenApi.Models;
using System.Collections.Generic;

namespace MCC_Compensation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<MyContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("MyContext")));

            services.AddScoped<AccountRepository>();
            services.AddScoped<AccountRoleRepository>();
            services.AddScoped<ApprovalRepository>();
            services.AddScoped<CompensationRepository>();
            services.AddScoped<CompensationRequestRepository>();
            services.AddScoped<DepartmentRepository>();
            services.AddScoped<DocumentRepository>();
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<PositionRepository>();
            services.AddScoped<RoleRepository>();
            services.AddScoped<StatusRepository>();

            services.AddMvc()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore
                );

            services.AddMvc()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.DefaultValueHandling =
                Newtonsoft.Json.DefaultValueHandling.Ignore
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
