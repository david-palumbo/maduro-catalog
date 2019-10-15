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
        /// <param name="state">
        /// Required cigar state.
        /// </param>
        private Cigar(CigarState state)
        {
            _state = state 
                ?? throw new ArgumentNullException(nameof(state));
        }
        
        /// <summary>
        /// Gets the unique identifier for the cigar.
        /// </summary>
        public Guid Id => _state.Id;

        /// <summary>
        /// Creates a new cigar.
        /// </summary>
        public static Cigar New()
        {
            CigarState state= new CigarState()
            {
                Id = Guid.NewGuid()
            };
            return new Cigar(state);
        }

        /// <summary>
        /// Loads a previously saved cigar.
        /// </summary>
        /// <param name="state">
        /// Required state of the cigar to load.
        /// </param>
        public static Cigar Load(CigarState state)
        {
            return new Cigar(state);
        }

        private readonly CigarState _state;
    }
}