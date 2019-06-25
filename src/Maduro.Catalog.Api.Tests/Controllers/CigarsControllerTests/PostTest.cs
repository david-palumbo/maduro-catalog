using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

using Maduro.Catalog.Api.Controllers;
using Maduro.Catalog.Application.Cigars.Commands;

namespace Maduro.Catalog.Api.Tests.Controllers.CigarsControllerTests
{
    /// <summary>
    /// Unit tests for the Post method of the <see cref="CigarsController"/> class.
    /// </summary>
    public class PostTest
    {
        /// <summary>
        /// Tests that the provided command is sent to the mediator instance
        /// for handling.
        /// </summary>
        [Fact]
        public async Task ShouldSendCommandToMediator()
        {
            AddCigarCommand command = new AddCigarCommand()
            {
                Blend = "Family Reserve",
                Brand = "Padron",
                Gauge = 52,
                Length = 5.5M
            };
            
            Guid newCigarId = Guid.NewGuid();
            
            Mock<IMediator> mediatorMock = new Mock<IMediator>();
            mediatorMock
                .Setup(mediator => mediator.Send(command, CancellationToken.None))
                .ReturnsAsync(newCigarId);
            
            CigarsController controller = new CigarsController(mediatorMock.Object);

            ActionResult<Guid> result = await controller.Post(command);

            CreatedAtActionResult actionResult = (CreatedAtActionResult) result.Result;
            
            Assert.Equal(newCigarId, actionResult.Value);
        }
    }
}