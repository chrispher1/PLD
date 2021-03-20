using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PLD.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using PLD.WebApi.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using PLD.WebApi.Helper;
using Microsoft.AspNetCore.Http;

namespace PLD.WebApi.Angular
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
            services.AddCors(options =>
                                {
                                    options.AddPolicy("CorsPolicy",
                                        builder => builder.WithOrigins("http://localhost:4200")
                                        .AllowAnyMethod()
                                        .AllowAnyHeader()
                                        .AllowCredentials() );
                                });            
            services.AddAutoMapper();            
            var connection = Configuration.GetSection("DMTPLDConnectionString").Value;
            services.AddDbContext<DMTPLDContext>(options => options.UseSqlServer(connection));
            services.AddScoped<ICommissionRepository<DmtCommErr>, CommissionErrorRepository>();
            services.AddScoped<ICommissionRepository<DmtComm>, CommissionFinalRepository>();
            services.AddScoped<CarrierRepository, CarrierRepository>();
            services.AddScoped<ProductRepository, ProductRepository>();
            services.AddScoped<ActivityRepository, ActivityRepository>();
            services.AddScoped<StatusRepository, StatusRepository>();
            services.AddScoped<IUserRepository<User>, UserRepository>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer( options => {
                options.TokenValidationParameters = new TokenValidationParameters 
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = 
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetSection("AppSettings:Token").Value)),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // if (env.IsDevelopment())
            // {
            //     app.UseDeveloperExceptionPage();
            // }
            
            app.UseExceptionHandler(builder => {
                    builder.Run(async context => {
                        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                        var error = context.Features.Get<IExceptionHandlerFeature>();
                        if (error != null) 
                        {                            
                            context.Response.AddApplicationError(error.Error.Message);                            
                            await context.Response.WriteAsync(error.Error.Message);
                        }
                    });
                });
            
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();            
            app.UseCors("CorsPolicy");
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseEndpoints( endPoint => {
                endPoint.MapControllers();
            });
        }
    }
}
