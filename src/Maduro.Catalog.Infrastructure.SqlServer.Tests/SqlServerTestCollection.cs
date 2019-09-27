using Xunit;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests
{
    /// <summary>
    /// Used to mark test classes as database tests.
    /// </summary>
    [CollectionDefinition("SQL Server Test")]
    public class SqlServerTestCollection : ICollectionFixture<SqlServerSettings>
    {
    }
}