using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

using Xunit;

using Maduro.Catalog.Domain.Cigars;
using Maduro.Catalog.Infrastructure.SqlServer.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.Cigars.SqlCigarRepositoryTests
{
    /// <summary>
    /// Unit tests for the Save method of the <see cref="SqlCigarRepository"/> class.
    /// </summary>
    public class SaveTest : SqlCigarRepositoryTest
    {
        /// <inheritdoc />
        /// <summary>
        /// Creates a new instance of the <see cref="SaveTest"/> class.
        /// </summary>
        public SaveTest(TestEnvironment testEnvironment)
            : base(testEnvironment)
        {
        }

        /// <summary>
        /// Tests that passing a null cigar argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        [ExcludeFromCodeCoverage]
        public async Task NullCigarShouldThrowException()
        {
            SqlCigarRepository repository = CreateRepository();

            ArgumentNullException exception = await Assert.ThrowsAsync<ArgumentNullException>(
                () => repository.Save(null));

            Assert.Equal("cigar", exception.ParamName);
        }

        /// <summary>
        /// Tests that the cigar provided to the repository is saved.
        /// </summary>
        [Fact]
        public async Task ShouldSaveProvidedCigar()
        {
            SqlCigarRepository repository = CreateRepository();

            Cigar newCigar = Cigar.New();

            await repository.Save(newCigar);

            Cigar savedCigar = await repository.Load(newCigar.Id);

            Assert.Equal(newCigar, savedCigar);
        }
    }
}