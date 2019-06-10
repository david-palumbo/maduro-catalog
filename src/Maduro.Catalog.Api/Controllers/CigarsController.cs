
using Microsoft.AspNetCore.Mvc;

namespace Maduro.Catalog.Api.Controllers
{
    /// <summary>
    /// API for cigars.
    /// </summary>
    public class CigarsController
    {
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