using System;
using System.Threading;
using System.Threading.Tasks;

using MediatR;

namespace Maduro.Catalog.Application.Cigars.Commands
{
    /// <summary>
    /// Processes the command to add a new cigar.
    /// </summary>
    public class AddCigarCommandHandler : IRequestHandler<AddCigarCommand, Guid>
    {
        /// <inheritdoc />
        public Task<Guid> Handle(AddCigarCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Guid.Empty);
        }
    }
}