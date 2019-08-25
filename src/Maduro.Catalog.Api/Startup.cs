using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Maduro.Catalog.Api.Middleware;
using Maduro.Catalog.Api.Middleware.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Maduro.Catalog.Api
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    {
                        AzureActiveDirectoryAuthenticationSettings authenticationSettings 
                            = new AzureActiveDirectoryAuthenticationSettings();
                        Configuration.Bind("Authentication:AzureActiveDirectory", authenticationSettings);
                        options.Audience = authenticationSettings.ClientId.ToString();
                        options.Authority = $"https://login.microsoftonline.com/{authenticationSettings.TenantId}/";
                        options.TokenValidationParameters.ValidIssuer = options.Authority + "v2.0";
                    }
                );
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            services.AddOpenApi();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {

                app.UseHsts();
            }

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseOpenApi();
        }
    }
}