using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IIntrusionSettings
	{
		/// <summary>
		/// getNetworkSecurityIntrusionSettings
		/// </summary>
		/// <remarks>
		/// Returns all supported intrusion settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/security/intrusion")]
		Task<object> GetNetworkSecurityIntrusionSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getOrganizationSecurityIntrusionSettings
		/// </summary>
		/// <remarks>
		/// Returns all supported intrusion settings for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/appliance/security/intrusion")]
		Task<object> GetOrganizationSecurityIntrusionSettings(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateNetworkSecurityIntrusionSettings
		/// </summary>
		/// <remarks>
		/// Set the supported intrusion settings for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSecurityIntrusionSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/security/intrusion")]
		Task<object> UpdateNetworkSecurityIntrusionSettings(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkSecurityIntrusionSettingsUpdateRequest updateNetworkSecurityIntrusionSettings
			);

		/// <summary>
		/// updateOrganizationSecurityIntrusionSettings
		/// </summary>
		/// <remarks>
		/// Sets supported intrusion settings for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="updateOrganizationSecurityIntrusionSettings"></param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/security/intrusionSettings")]
		Task<object> UpdateOrganizationSecurityIntrusionSettings(
			[AliasAs("organizationId")]string organizationId,
			[Body]SecurityIntrusionSettingsUpdateRequest updateOrganizationSecurityIntrusionSettings
			);
	}
}
