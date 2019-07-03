using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Application.Cigars.Commands
{
    /// <summary>
    /// Processes the command to add a new cigar.
    /// </summary>
    public class AddCigarCommandHandler : IRequestHandler<AddCigarCommand, Guid>
    {

        /// <summary>
        /// Creates a new instance of the <see cref="AddCigarCommandHandler" />
        /// class.
        /// </summary>
        /// <param name="cigarRepository">
        /// Required type used to persist the new cigar.
        /// </param>
        public AddCigarCommandHandler(ICigarRepository cigarRepository)
        {
            _cigarRepository = cigarRepository;
        }
        
        /// <inheritdoc />
        public async Task<Guid> Handle(AddCigarCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            Cigar cigar = Cigar.New();

            await _cigarRepository.Save(cigar);

            return cigar.Id;
        }
        
        private readonly ICigarRepository _cigarRepository;
    }
}