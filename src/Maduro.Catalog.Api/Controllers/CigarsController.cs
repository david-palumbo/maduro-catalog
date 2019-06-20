
using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Maduro.Catalog.Api.Controllers
{
    /// <summary>
    /// API for cigars.
    /// </summary>
    public class CigarsController
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
        public ActionResult<string> Get(int id)
        {
            return string.Empty;
        }
        
        
        
        private readonly IMediator _mediator;
    }
}