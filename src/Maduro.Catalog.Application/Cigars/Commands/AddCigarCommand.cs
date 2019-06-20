using MediatR;

namespace Maduro.Catalog.Application.Cigars.Commands
{
    /// <summary>
    /// Contains the data required to add a new cigar.
    /// </summary>
    public class AddCigarCommand : IRequest
    {
        /// <summary>
        /// Gets or sets the brand of cigar.
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Gets or sets the blend of cigar.
        /// </summary>
        public string Blend { get; set; }

        /// <summary>
        /// Gets or sets the length of the cigar in inches.
        /// </summary>
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or sets the gauge of the cigar.
        /// </summary>
        public int Gauge { get; set; }
    }
}