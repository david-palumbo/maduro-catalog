using System.Diagnostics.CodeAnalysis;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Swagger;

namespace Maduro.Catalog.Api.Middleware
{
    /// <summary>
    /// Extension methods to add OpenAPI features to the API.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class OpenApiExtensions
    {
        /// <summary>
        /// Adds OpenAPI (Swagger) generation to the provided <paramref name="serviceCollection"/>.
        /// </summary>
        /// <param name="serviceCollection">
        /// Required service collection to add OpenAPI to.
        /// </param>
        public static void AddOpenApi(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSwaggerGen(options =>
            {
                const string version = "v1";
                
                options.SwaggerDoc(version, new OpenApiInfo());

                
            });
        }
        
        /// <summary>
        /// Instructs the provided <paramref name="apiBuilder"/> to use OpenAPI features.
        /// </summary>
        /// <param name="apiBuilder">
        /// Required <see cref="IApplicationBuilder"/> to add the OpenAPI features to.
        /// </param>
        public static void UseOpenApi(this IApplicationBuilder apiBuilder)
        {
            apiBuilder.UseSwagger();
            apiBuilder.UseSwaggerUI(options =>
            {
                options.RoutePrefix = "swagger";
                options.SwaggerEndpoint(
                    "/swagger/v1/swagger.json",
                    _apiName
                );
            });
        }
        
        private const string _apiName = "Maduro Catalog API";
    }
}