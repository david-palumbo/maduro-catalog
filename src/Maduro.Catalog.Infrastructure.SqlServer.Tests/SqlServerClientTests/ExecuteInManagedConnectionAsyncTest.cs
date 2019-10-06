using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dapper;
using Xunit;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.SqlServerClientTests
{
    /// <summary>
    /// Unit tests for the ExecuteInManagedConnectionAsync method of the
    /// <see cref="SqlServerClient"/> class.
    /// </summary>
    [Collection(SqlServerTestCollection.CollectionName)]
    public class ExecuteInManagedConnectionAsyncTest
    {
        private readonly TestEnvironment _testEnvironment;

        /// <summary>
        /// Creates a new instance of the
        /// <see cref="ExecuteInManagedConnectionAsyncTest"/> class.
        /// </summary>
        /// <param name="testEnvironment">
        /// Required test execution environment.
        /// </param>
        public ExecuteInManagedConnectionAsyncTest(TestEnvironment testEnvironment)
        {
            _testEnvironment = testEnvironment;
        }

        /// <summary>
        /// Tests that the supplied method is execute in the created connection.
        /// </summary>
        [Fact]
        public async Task ShouldExecuteMethodInConnection()
        {
            SqlServerClient client = new SqlServerClient(_testEnvironment.SqlServerSettings);

            bool methodDidExecute = await client.ExecuteInManagedConnectionAsync(async connection =>
            {
                IEnumerable<dynamic> result 
                    = await connection.QueryAsync("SELECT TOP 1 * FROM sys.all_objects");
                return result.Any();
            });

            Assert.True(methodDidExecute);
        }
    }
}