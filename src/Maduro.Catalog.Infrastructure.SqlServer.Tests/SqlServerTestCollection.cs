using Xunit;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests
{
    /// <summary>
    /// Used to mark test classes as database tests.
    /// </summary>
    [CollectionDefinition(CollectionName)]
    public class SqlServerTestCollection : ICollectionFixture<TestEnvironment>
    {
        public const string CollectionName = "SQL Server Test";
    }
}