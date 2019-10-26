﻿using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Maduro.Catalog.Domain.Cigars;
using Maduro.Catalog.Infrastructure.SqlServer.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// Registers the SQL Server implementations.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class ServiceCollectionSqlExtensions
    {
        /// <summary>
        /// Registers the SQL Server repository providers.
        /// </summary>
        /// <param name="services">
        /// Required service collection to register the providers to.
        /// </param>
        /// <param name="configuration"></param>
        public static void AddSqlRepositories(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.Configure<SqlServerSettings>(configuration.GetSection("SqlServer"));
            services.AddSingleton<IEntitySerializer, JsonEntitySerializer>();
            services.AddSingleton<IDatabaseClient, SqlServerClient>();
            services.AddSingleton<ICigarRepository, SqlCigarRepository>();
        }
    }
}