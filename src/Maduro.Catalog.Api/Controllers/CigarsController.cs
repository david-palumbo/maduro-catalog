
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
        /// <param name="mediator"></param>
        public CigarsController(IMediator mediator)
        {
            
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
    }
}