using System;
using System.Data;
using System.Threading.Tasks;

namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// Interface for types that will connect to a database and execute queries
    /// and commands.
    /// </summary>
    public interface IDatabaseClient
    {
        /// <summary>
        /// Executes the supplied <paramref name="method"/> within a managed database
        /// connection.
        /// </summary>
        /// <typeparam name="T">
        /// The type of data to return.
        /// </typeparam>
        /// <param name="method">
        /// Required method to execute.
        /// </param>
        Task<T> ExecuteInManagedConnectionAsync<T>(Func<IDbConnection, Task<T>> method);
    }
}