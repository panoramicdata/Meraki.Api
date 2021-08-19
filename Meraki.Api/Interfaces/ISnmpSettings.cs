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
		/// Return the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/snmpSettings")]
		Task<SnmpSettingsUpdateRequest> GetNetworkSnmpSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

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
		/// Update the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSnmpSettings"></param>
		[Put("/networks/{networkId}/snmpSettings")]
		Task<SnmpSettingsUpdateRequest> UpdateNetworkSnmpSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SnmpSettingsUpdateRequest UpdateNetworkSnmpSettings,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the SNMP settings for an organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganizationSnmp"></param>
		[Put("/organizations/{organizationId}/snmp")]
		Task<SnmpUpdateRequest> UpdateOrganizationSnmpAsync(
			[AliasAs("organizationId")] string organizationId,
			[Body] SnmpUpdateRequest UpdateOrganizationSnmp,
			CancellationToken cancellationToken = default
			);
	}
}
