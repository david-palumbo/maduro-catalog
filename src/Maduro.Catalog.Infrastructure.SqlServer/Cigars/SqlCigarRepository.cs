using System;
using System.Threading.Tasks;

using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Cigars
{
    /// <summary>
    /// SQL Server implementation of the <see cref="ICigarRepository"/> interface.
    /// </summary>
    public class SqlCigarRepository : ICigarRepository
    {
        private readonly SqlServerSettings _settings;

        /// <summary>
        /// Creates a new instance of the <see cref="SqlCigarRepository"/> class.
        /// </summary>
        /// <param name="settings">
        /// Required settings for integrating with SQL Server.
        /// </param>
        public SqlCigarRepository(SqlServerSettings settings)
        {
            _settings = settings;
        }

        /// <inheritdoc />
        public Task<Cigar> Load(Guid id)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task Save(Cigar cigar)
        {
            if (cigar == null)
            {
                throw new ArgumentNullException(nameof(cigar));
            }

            throw new System.NotImplementedException();
        }
    }
}