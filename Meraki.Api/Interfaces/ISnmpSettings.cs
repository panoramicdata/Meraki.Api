using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISnmpSettings
	{
		/// <summary>
		/// Return the SNMP settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/snmp")]
		Task<SnmpUpdateRequest> GetOrganizationSnmpAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the SNMP settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="updateOrganizationSnmp"></param>
		[Put("/organizations/{organizationId}/snmp")]
		Task<SnmpUpdateRequest> UpdateOrganizationSnmpAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SnmpUpdateRequest updateOrganizationSnmp,
			CancellationToken cancellationToken = default
			);
	}
}
