using System.IO;
using Microsoft.Extensions.Configuration;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests
{
    /// <summary>
    /// Contains the settings for integrating with SQL Server.
    /// </summary>
    public class SqlServerSettings
    {
        /// <summary>
        /// Creates a new instance of the <see cref="SqlServerSettings"/> class.
        /// </summary>
        public SqlServerSettings()
        {
            const string localSettingsFile = "settings.local.json";

            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            IConfigurationRoot configuration = builder
                .AddJsonFile(localSettingsFile, true, true)
                .Build();

            ConnectionString = configuration["ConnectionString"];
        }

        /// <summary>
		/// Gets or sets information for connecting to the SQL Server database.
		/// </summary>
		public string ConnectionString { get; }
    }
}