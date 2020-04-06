using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IFirewalledServices
	{
		/// <summary>
		/// getNetworkFirewalledService
		/// </summary>
		/// <remarks>
		/// Return the accessibility settings of the given service (&#39;ICMP&#39;, &#39;web&#39;, or &#39;SNMP&#39;)
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="service"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/firewalledServices/{service}")]
		Task<object> GetNetworkFirewalledService(
			[AliasAs("networkId")]string networkId,
			[AliasAs("service")]string service
			);

		/// <summary>
		/// getNetworkFirewalledServices
		/// </summary>
		/// <remarks>
		/// List the appliance services and their accessibility rules
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/firewalledServices")]
		Task<object> GetNetworkFirewalledServices(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkFirewalledService
		/// </summary>
		/// <remarks>
		/// Updates the accessibility settings for the given service (&#39;ICMP&#39;, &#39;web&#39;, or &#39;SNMP&#39;)
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="service"></param>
		/// <param name="updateNetworkFirewalledService"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/firewalledServices/{service}")]
		Task<object> UpdateNetworkFirewalledService(
			[AliasAs("networkId")]string networkId,
			[AliasAs("service")]string service,
			[Body]FirewalledServiceUpdateRequest updateNetworkFirewalledService);
	}
}
