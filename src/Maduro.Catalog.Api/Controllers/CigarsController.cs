using System;
using System.Threading.Tasks;

using MediatR;
using Microsoft.AspNetCore.Mvc;

using Maduro.Catalog.Application.Cigars.Commands;

namespace Maduro.Catalog.Api.Controllers
{
    /// <summary>
    /// API for cigars.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CigarsController : ControllerBase
    {
        /// <summary>
        /// Creates a new instance of the <see cref="CigarsController"/> class.
        /// </summary>
        /// <param name="mediator">
        /// Required type for mediating commands and queries.
        /// </param>
        public CigarsController(IMediator mediator)
        {
            _mediator = mediator 
                ?? throw new ArgumentNullException(nameof(mediator));
        }

        /// <summary>
        /// Gets a single cigar based on the supplied <paramref name="id" />.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the cigar to get.
        /// </param>
        [HttpGet]
        public ActionResult<string> Get(int id)
        {
            return string.Empty;
        }

        /// <summary>
        /// Adds a new cigar.
        /// </summary>
        /// <param name="command">
        /// Required command containing the data needed to create a new cigar.
        /// </param>
        [HttpPost]
        public async Task<ActionResult<Guid>> Post(AddCigarCommand command)
        {
            Guid commandResult = await _mediator.Send(command);

            return CreatedAtAction(nameof(Get), commandResult);
        }
        
        private readonly IMediator _mediator;
    }
}