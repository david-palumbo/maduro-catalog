using Maduro.Catalog.Infrastructure.SqlServer.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Tests.Cigars.SqlCigarRepositoryTests
{
    /// <summary>
    /// Base class for testing the <see cref="SqlCigarRepository"/> class.
    /// </summary>
    public abstract class SqlCigarRepositoryTest
    {
        
        /// <summary>
        /// Creates a new instance of the <see cref="SqlCigarRepository"/> configured
        /// for testing.
        /// </summary>
        /// <returns></returns>
        protected static SqlCigarRepository CreateRepository()
        {
            return new SqlCigarRepository();
        }
    }
}