using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <inheritdoc />
    /// <summary>
    /// SQL Server implementation of the <see cref="IDatabaseClient"/> interface.
    /// </summary>
    public class SqlServerClient : IDatabaseClient
    {
        private readonly SqlServerSettings _sqlServerSettings;

        /// <summary>
        /// Creates a new instance of the <see cref="SqlServerClient"/> class.
        /// </summary>
        /// <param name="sqlServerSettings">
        /// Required settings for connecting and work with SQL Server.
        /// </param>
        public SqlServerClient(SqlServerSettings sqlServerSettings)
        {
            _sqlServerSettings = sqlServerSettings 
                ?? throw new ArgumentNullException(nameof(sqlServerSettings));
        }

        /// <summary>
        /// Creates a new instance of the <see cref="SqlServerClient"/> class.
        /// </summary>
        /// <param name="sqlServerOptions">
        /// Required settings for connecting and work with SQL Server.
        /// </param>
        public SqlServerClient(IOptions<SqlServerSettings> sqlServerOptions)
            : this(sqlServerOptions?.Value)
        {
        }

        /// <inheritdoc />
        public async Task<T> ExecuteInManagedConnectionAsync<T>(
            Func<IDbConnection, Task<T>> method)
        {
            using (SqlConnection connection = new SqlConnection(_sqlServerSettings.ConnectionString))
            {
                await connection.OpenAsync();

                return await method(connection);
            }
        }
    }
}