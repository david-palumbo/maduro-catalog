using System;
using System.Threading;
using System.Threading.Tasks;

using Moq;
using Xunit;

using Maduro.Catalog.Application.Cigars.Commands;
using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Application.Tests.Cigars.Commands.AddCigarCommandHandlerTests
{
    /// <summary>
    /// Unit tests for the Handle method of the <see cref="AddCigarCommandHandler"/>
    /// class.
    /// </summary>
    public class HandleTest
    {
        /// <summary>
        /// Creates a new instance of the <see cref="HandleTest"/>.
        /// </summary>
        public HandleTest()
        {
            _cigarRepositoryMock = new Mock<ICigarRepository>();
        }
        
        /// <summary>
        /// Tests that an <see cref="ArgumentNullException"/> is thrown if the
        /// request argument is not provided.
        /// </summary>
        [Fact]
        public async Task ShouldVerifyRequest()
        {
            AddCigarCommandHandler handler = CreateHandler();

            ArgumentNullException exception = await Assert.ThrowsAsync<ArgumentNullException>(
                () => handler.Handle(null, CancellationToken.None));

            Assert.Equal("request", exception.ParamName);
        }

        /// <summary>
        /// Tests that a new cigar is saved to the repository.
        /// </summary>
        [Fact]
        public async Task ShouldSendSaveNewCigarToRepository()
        {
            AddCigarCommand command = new AddCigarCommand();
            AddCigarCommandHandler handler = CreateHandler();

            await handler.Handle(command, CancellationToken.None);
            
            _cigarRepositoryMock.Verify(repository => 
                repository.Save(It.Is<Cigar>(cigar =>
                    cigar.Id != Guid.Empty)
                )
            );
        }

        private readonly Mock<ICigarRepository> _cigarRepositoryMock;
        
        /// <summary>
        /// Creates a new instance of the <see cref="AddCigarCommandHandler" />
        /// class configured for testing.
        /// </summary>
        private AddCigarCommandHandler CreateHandler()
        {
            return new AddCigarCommandHandler(_cigarRepositoryMock.Object);
        }
    }
}