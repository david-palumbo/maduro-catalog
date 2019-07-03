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
    }
}