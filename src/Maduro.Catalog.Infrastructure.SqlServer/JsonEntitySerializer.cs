using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// JSON implementation of the <see cref="IEntitySerializer"/> interface.
    /// </summary>
    public class JsonEntitySerializer : IEntitySerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T entity)
        {
            return JsonSerializer.Serialize(entity);
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            return JsonSerializer.Deserialize<T>(data);
        }
    }
}