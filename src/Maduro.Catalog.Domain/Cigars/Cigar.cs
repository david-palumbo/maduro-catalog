using System;
using Maduro.Catalog.Domain.Cigars.State;

namespace Maduro.Catalog.Domain.Cigars
{
    /// <summary>
    /// Domain entity that represents a cigar.
    /// </summary>
    public class Cigar
    {
        /// <summary>
        /// Creates a new instance of the <see cref="Cigar"/> class.
        /// </summary>
        private Cigar()
        {
        }
        
        /// <summary>
        /// Gets the unique identifier for the cigar.
        /// </summary>
        public Guid Id => state.Id;

        /// <summary>
        /// Creates a new cigar.
        /// </summary>
        public static Cigar New()
        {
            return new Cigar()
            {
                state = new CigarState()
                {
                    Id = Guid.NewGuid()
                }
            };
        }

        private CigarState state;
    }
}