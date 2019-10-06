namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// JSON implementation of the <see cref="IEntitySerializer"/> interface.
    /// </summary>
    public class JsonSerializer : IEntitySerializer
    {
        /// <inheritdoc />
        public string Serialize<T>(T entity)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public T Deserialize<T>(string data)
        {
            throw new System.NotImplementedException();
        }
    }
}