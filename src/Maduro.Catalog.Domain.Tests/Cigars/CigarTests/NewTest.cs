using System;

using Xunit;

using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Domain.Tests.Cigars.CigarTests
{
    /// <summary>
    /// Unit tests for the New method of the <see cref="Cigar"/> class.
    /// </summary>
    public class NewTest
    {
        /// <summary>
        /// Tests that the newly created cigar has the expected state.
        /// </summary>
        [Fact]
        public void ShouldHaveExpectedState()
        {
            Cigar cigar = Cigar.New();

            Assert.NotEqual(Guid.Empty, cigar.Id);
        }
    }
}