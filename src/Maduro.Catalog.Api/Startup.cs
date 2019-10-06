using System.Diagnostics.CodeAnalysis;

using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Maduro.Catalog.Api.Middleware;
using Maduro.Catalog.Api.Middleware.Authentication;
using Maduro.Catalog.Application.Cigars.Commands;
using Microsoft.Extensions.Hosting;

[assembly: ApiConventionType(typeof(DefaultApiConventions))]

namespace Maduro.Catalog.Api
{
    /// <summary>
    /// Manages the application startup.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">
        /// Required configuration for the application.
        /// </param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// Gets the application configuration.
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the services used by the application.
        /// </summary>
        /// <param name="services">
        /// Required services to configure.
        /// </param>
        public void ConfigureServices(IServiceCollection services)
        {
            AzureActiveDirectoryAuthenticationSettings authenticationSettings
                = new AzureActiveDirectoryAuthenticationSettings();
            Configuration.Bind("Authentication:AzureActiveDirectory", authenticationSettings);
            services.AddAzureActiveDirectoryAuthentication(authenticationSettings);
            services
                .AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            services
                .AddMediatR(typeof(AddCigarCommand).Assembly);
            
            services
                .AddOpenApi();
        }

        /// <summary>
        /// Configures the application.
        /// </summary>
        /// <param name="app">
        /// Required application builder.
        /// </param>
        /// <param name="env">
        /// Required hosting environment.
        /// </param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseEndpoints(endpoints => {
                endpoints.MapControllers();
            });
            app.UseOpenApi();
        }
    }
}