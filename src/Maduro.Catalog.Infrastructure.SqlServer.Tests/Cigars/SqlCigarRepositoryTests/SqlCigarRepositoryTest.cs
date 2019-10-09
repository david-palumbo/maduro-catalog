using Xunit;

using Maduro.Catalog.Infrastructure.SqlServer.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.Cigars.SqlCigarRepositoryTests
{
    /// <summary>
    /// Base class for testing the <see cref="SqlCigarRepository"/> class.
    /// </summary>
    [Collection(SqlServerTestCollection.CollectionName)]
    public abstract class SqlCigarRepositoryTest
    {
        private readonly TestEnvironment _testEnvironment;

        /// <summary>
        /// Creates a new instance of the <see cref="SqlCigarRepositoryTest"/> class.
        /// </summary>
        /// <param name="testEnvironment">
        /// Required test execution environment.
        /// </param>
        protected SqlCigarRepositoryTest(TestEnvironment testEnvironment)
        {
            _testEnvironment = testEnvironment;
        }
        
        /// <summary>
        /// Creates a new instance of the <see cref="SqlCigarRepository"/> configured
        /// for testing.
        /// </summary>
        /// <returns></returns>
        protected SqlCigarRepository CreateRepository()
        {
            var client = new SqlServerClient(_testEnvironment.SqlServerSettings);

            return new SqlCigarRepository(client, new JsonSerializer());
        }
    }
}