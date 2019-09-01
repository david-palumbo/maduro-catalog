using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;

namespace Maduro.Catalog.Api.Middleware.Authentication
{
    /// <summary>
    /// Extensions methods for adding authentication options to an <see cref="IServiceCollection" />.
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal static class ServiceCollectionAuthenticationExtensions
    {
        /// <summary>
        /// Adds Azure Active Directory authentication to the service collection.
        /// </summary>
        /// <param name="services"></param>
        public static void AddAzureActiveDirectoryAuthentication(
            this IServiceCollection services,
            AzureActiveDirectoryAuthenticationSettings authenticationSettings)
        {
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                    {
                        options.Audience = authenticationSettings.ClientId.ToString();
                        options.Authority = $"https://login.microsoftonline.com/{authenticationSettings.TenantId}/";
                        options.TokenValidationParameters.ValidIssuer = options.Authority + "v2.0";
                    }
                );
        }
    }
}