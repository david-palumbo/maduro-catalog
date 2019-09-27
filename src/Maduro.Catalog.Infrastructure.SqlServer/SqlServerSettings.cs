namespace Maduro.Catalog.Infrastructure.SqlServer
{
    /// <summary>
    /// Represents the settings for working with SQL Server.
    /// </summary>
    public class SqlServerSettings
    {
        /// <summary>
		/// Gets or sets the information required to connect to a SQL Server database.
		/// </summary>
		public string ConnectionString { get; set; }
    }
}