using System;
using System.Threading.Tasks;

namespace Maduro.Catalog.Domain.Cigars
{
    /// <summary>
    /// Interface for classes that will implement cigar persistence.
    /// </summary>
    public interface ICigarRepository
    {
        /// <summary>
        /// Saves the supplied <paramref name="cigar"/> to persistent storage.
        /// </summary>
        /// <param name="cigar">
        /// Required <see cref="Cigar"/> to save.
        /// </param>
        Task Save(Cigar cigar);

        /// <summary>
        /// Loads a <see cref="Cigar"/> from the repository based on the
        /// supplied <paramref name="id"/>.
        /// </summary>
        /// <param name="id">
        /// Required unique identifier of the <see cref="Cigar"/> to load from
        /// the repository.
        /// </param>
        Task<Cigar> Load(Guid id);
    }
}