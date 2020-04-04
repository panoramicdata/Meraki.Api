using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISyslogServers
	{
		/// <summary>
		/// getNetworkSyslogServers
		/// </summary>
		/// <remarks>
		/// List the syslog servers for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/syslogServers")]
		Task<object> GetNetworkSyslogServers(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSyslogServers
		/// </summary>
		/// <remarks>
		/// Update the syslog servers for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSyslogServers"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/syslogServers")]
		Task<object> UpdateNetworkSyslogServers(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetworkSyslogServers updateNetworkSyslogServers
			);
	}
}
