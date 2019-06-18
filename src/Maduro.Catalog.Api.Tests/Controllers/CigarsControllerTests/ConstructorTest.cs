using System;

using Xunit;

using Maduro.Catalog.Api.Controllers;

namespace Maduro.Catalog.Api.Tests.Controllers.CigarsControllerTests
{
    /// <summary>
    /// Unit tests for the constructors of the <see cref="CigarsController"/> class.
    /// </summary>
    public class ConstructorTest
    {
        /// <summary>
        /// Test that an <see cref="ArgumentNullException"/> is thrown if the mediator
        /// argument is not provided.
        /// </summary>
        [Fact]
        public void ShouldValidateMediatorArgument()
        {
            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(
                () => new CigarsController(null));
            
            Assert.Equal("mediator", exception.ParamName);
        }
    }
}