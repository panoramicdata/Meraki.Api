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
		/// Sets supported intrusion settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="updateOrganizationSecurityIntrusionSettings">Body for updating security intrusion settings</param>
		[Put("/organizations/{organizationId}/security/intrusionSettings")]
		Task<SecurityIntrusionSettingsUpdateRequest> UpdateOrganizationSecurityIntrusionSettingsAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SecurityIntrusionSettingsUpdateRequest updateOrganizationSecurityIntrusionSettings,
			CancellationToken cancellationToken = default
			);
	}
}
