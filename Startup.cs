using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using REST_SQL_New.Data;
using REST_SQL_New.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST_SQL_New
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
            services.AddDbContext<AthleteContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("OlympicsConnection")));
            services.AddDbContext<CoachContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("OlympicsConnection")));
            services.AddDbContext<MedalContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("OlympicsConnection")));
            services.AddDbContext<MedalTotalContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("OlympicsConnection")));

            services.AddControllers();
            //services.AddScoped<IAthleteRepo, MockOlympicsRepo>();
            services.AddScoped<IAthleteRepo, SqlAthleteRepo>();
            services.AddScoped<ICoachRepo, SqlCoachRepo>();
            services.AddScoped<IMedalRepo, SqlMedalRepo>();
            services.AddScoped<IMedalTotalRepo, SqlMedalTotalRepo>();
            services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });    
            });
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
            app.UseCors();
            app.UseAuthorization();
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapGraphQL("/graphql");
            });
        }
    }
}
