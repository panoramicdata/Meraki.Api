using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISnmpSettings
	{
		/// <summary>
		/// getNetworkSnmpSettings
		/// </summary>
		/// <remarks>
		/// Return the SNMP settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/snmpSettings")]
		Task<object> GetNetworkSnmpSettings(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getOrganizationSnmp
		/// </summary>
		/// <remarks>
		/// Return the SNMP settings for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/snmp")]
		Task<object> GetOrganizationSnmp(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateNetworkSnmpSettings
		/// </summary>
		/// <remarks>
		/// Update the SNMP settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSnmpSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/snmpSettings")]
		Task<object> UpdateNetworkSnmpSettings(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetworkSnmpSettings updateNetworkSnmpSettings
			);

		/// <summary>
		/// updateOrganizationSnmp
		/// </summary>
		/// <remarks>
		/// Update the SNMP settings for an organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="updateOrganizationSnmp"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/snmp")]
		Task<object> UpdateOrganizationSnmp(
			[AliasAs("organizationId")]string organizationId,
			[Body]UpdateOrganizationSnmp updateOrganizationSnmp
			);
	}
}
