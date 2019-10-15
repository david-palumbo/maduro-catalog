using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

using Maduro.Catalog.Infrastructure.SqlServer.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.Cigars.SqlCigarRepositoryTests
{
    /// <summary>
    /// Unit tests for the constructors of the <see cref="SqlCigarRepository"/>
    /// class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Tests that passing a null client argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        [ExcludeFromCodeCoverage]
        public void NullClientShouldThrowException()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => new SqlCigarRepository(null, new JsonEntitySerializer()));

            Assert.Equal("client", exception.ParamName);
        }

        /// <summary>
        /// Tests that passing a null serializer argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        [ExcludeFromCodeCoverage]
        public void NullSerializerShouldThrowException()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => new SqlCigarRepository(new SqlServerClient(new SqlServerSettings()), null));

            Assert.Equal("serializer", exception.ParamName);
        }
    }
}