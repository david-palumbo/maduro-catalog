using System.Threading.Tasks;

namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// Interface for types that will handle handle serialization and deserialization
    /// of entities for storage in document fields.
    /// </summary>
    public interface IEntitySerializer
    {
        /// <summary>
        /// Serializes the provided <paramref name="entity"/> for storage in SQL
        /// Server.
        /// </summary>
        /// <typeparam name="T">
        /// The type of entity to serialize.
        /// </typeparam>
        /// <param name="entity">
        /// Required entity to serialize.
        /// </param>
        string Serialize<T>(T entity);

        /// <summary>
        /// Deserializes the provided <paramref name="data"/> in to an entity.
        /// </summary>
        /// <typeparam name="T">
        /// The type to deserialize the data to.
        /// </typeparam>
        /// <param name="data">
        /// Required data to deserialize.
        /// </param>
        T Deserialize<T>(string data);
    }
}