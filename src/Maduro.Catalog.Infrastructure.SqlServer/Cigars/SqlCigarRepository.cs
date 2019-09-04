using System.Threading.Tasks;

using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Cigars
{
    /// <summary>
    /// SQL Server implementation of the <see cref="ICigarRepository"/> interface.
    /// </summary>
    public class SqlCigarRepository : ICigarRepository
    {
        /// <inheritdoc />
        public Task Save(Cigar cigar)
        {
            throw new System.NotImplementedException();
        }
    }
}