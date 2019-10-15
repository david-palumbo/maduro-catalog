namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// Represents the serialized state of an entity.
    /// </summary>
    internal class EntityState
    {
        #region : Public Properties :

        /// <summary>
        /// Gets or sets the serialized content of the entity.
        /// </summary>
        public string SerializedContent { get; set; }

        /// <summary>
        /// Gets or sets the version of the entity's schema.
        /// </summary>
        public int SchemaVersion { get; set; }

        #endregion
    }
}