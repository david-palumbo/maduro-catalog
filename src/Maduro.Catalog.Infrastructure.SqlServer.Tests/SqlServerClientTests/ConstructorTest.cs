using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Options;
using Xunit;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.SqlServerClientTests
{
    /// <summary>
    /// Unit tests for the constructors of the <see cref="SqlServerClient" /> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests that passing a null sqlServerSettings argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        [ExcludeFromCodeCoverage]
        public void NullSqlServerSettingsShouldThrowException()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => new SqlServerClient((IOptions<SqlServerSettings>) null));
            Assert.Equal("sqlServerSettings", exception.ParamName);
        }
    }
}