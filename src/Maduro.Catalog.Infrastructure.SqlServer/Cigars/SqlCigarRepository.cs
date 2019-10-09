﻿using System;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using Maduro.Catalog.Domain.Cigars;

namespace Maduro.Catalog.Infrastructure.SqlServer.Cigars
{
    /// <summary>
    /// SQL Server implementation of the <see cref="ICigarRepository"/> interface.
    /// </summary>
    public class SqlCigarRepository : ICigarRepository
    {
        private readonly IDatabaseClient _client;
        private readonly IEntitySerializer _serializer;

        /// <summary>
        /// Creates a new instance of the <see cref="SqlCigarRepository"/> class.
        /// </summary>
        /// <param name="client">
        /// Required client used to connect to the SQL Server database.
        /// </param>
        /// <param name="serializer"></param>
        public SqlCigarRepository(IDatabaseClient client, IEntitySerializer serializer)
        {
            _client = client
                ?? throw new ArgumentNullException(nameof(client));

            _serializer = serializer 
                ?? throw new ArgumentNullException(nameof(serializer));
        }

        /// <inheritdoc />
        public async Task<Cigar> Load(Guid id)
        {
            DynamicParameters parameters = new DynamicParameters();

            parameters.Add("@Id", id, DbType.Guid, ParameterDirection.Input);

            var model = await _client.ExecuteInManagedConnectionAsync(connection => 
                connection.QuerySingleOrDefaultAsync<object>(
                    "[Catalog].[Cigars_GetSingle]",
                    parameters,
                    commandType: CommandType.StoredProcedure)
                );

            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Task Save(Cigar cigar)
        {
            if (cigar == null)
            {
                throw new ArgumentNullException(nameof(cigar));
            }

            throw new NotImplementedException();
        }
    }
}