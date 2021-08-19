using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IIntrusionSettings
	{
		/// <summary>
		/// Returns all supported intrusion settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/security/intrusion")]
		Task<NetworkSecurityIntrusionSettingsUpdateRequest> GetNetworkSecurityIntrusionSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Returns all supported intrusion settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/appliance/security/intrusion")]
		Task<SecurityIntrusionSettingsUpdateRequest> GetOrganizationSecurityIntrusionSettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the supported intrusion settings for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSecurityIntrusionSettings">Body for updating security intrusion settings</param>
		[Put("/networks/{networkId}/appliance/security/intrusion")]
		Task<NetworkSecurityIntrusionSettingsUpdateRequest> UpdateNetworkSecurityIntrusionSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSecurityIntrusionSettingsUpdateRequest UpdateNetworkSecurityIntrusionSettings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Sets supported intrusion settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganizationSecurityIntrusionSettings">Body for updating security intrusion settings</param>
		[Put("/organizations/{organizationId}/security/intrusionSettings")]
		Task<SecurityIntrusionSettingsUpdateRequest> UpdateOrganizationSecurityIntrusionSettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SecurityIntrusionSettingsUpdateRequest UpdateOrganizationSecurityIntrusionSettings,
			CancellationToken cancellationToken = default
			);
	}
}
