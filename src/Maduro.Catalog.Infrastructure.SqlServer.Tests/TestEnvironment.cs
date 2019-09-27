using System.IO;

using Microsoft.Extensions.Configuration;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests
{
    /// <summary>
    /// Represents the current test execution environment.
    /// </summary>
    public class TestEnvironment
    {
        /// <summary>
        /// Creates a new instance of the <see cref="TestEnvironment"/> class.
        /// </summary>
        public TestEnvironment()
        {
            const string localSettingsFile = "settings.local.json";

            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            IConfigurationRoot configuration = builder
                .AddJsonFile(localSettingsFile, true, true)
                .Build();

            SqlServerSettings = new SqlServerSettings()
            {
                ConnectionString = configuration["ConnectionString"]
            };
        }

        /// <summary>
        /// Gets the setting for integrating with SQL Server.
        /// </summary>
        public SqlServerSettings SqlServerSettings { get; }
    }
}