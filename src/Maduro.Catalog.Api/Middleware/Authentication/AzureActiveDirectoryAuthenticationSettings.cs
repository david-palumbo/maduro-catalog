using System;

namespace Maduro.Catalog.Api.Middleware.Authentication
{
    /// <summary>
    /// Represents the authentication settings for the API.
    /// </summary>
    public class AzureActiveDirectoryAuthenticationSettings
    {
        /// <summary>
		/// Gets or sets the Azure App Registration Client (Application) Id.
		/// </summary>
		public Guid ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Azure App Registration Tenant (Directory) Id.
        /// </summary>
        public Guid TenantId { get; set; }
    }
}