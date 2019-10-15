using System;
using System.Diagnostics.CodeAnalysis;

using Xunit;

using Maduro.Catalog.Domain.Cigars;
using Maduro.Catalog.Domain.Cigars.State;

namespace Maduro.Catalog.Domain.Tests.Cigars.CigarTests
{
    /// <summary>
    /// Unit tests for the Load method of the <see cref="Cigar"/> class.
    /// </summary>
    public class LoadTest
    {
        /// <summary>
        /// Tests that passing a null state argument will result
        /// in an <see cref="ArgumentNullException" /> being thrown.
        /// </summary>
        [Fact]
        [ExcludeFromCodeCoverage]
        public void NullStateShouldThrowException()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => Cigar.Load(null));
            Assert.Equal("state", exception.ParamName);
        }

        /// <summary>
        /// Tests that the provided state is bound to the entity properties.
        /// </summary>
        [Fact]
        public void ShouldBindStateToProperties()
        {
            CigarState state = new CigarState()
            {
                Id = Guid.NewGuid()
            };

            Cigar cigar = Cigar.Load(state);

            Assert.Equal(state.Id, cigar.Id);
        }
    }
}