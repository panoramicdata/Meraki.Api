using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISyslogServers
	{
		/// <summary>
		/// List the syslog servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/syslogServers")]
		Task<SyslogServersUpdateRequest> GetNetworkSyslogServersAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the syslog servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkSyslogServers"></param>
		[Put("/networks/{networkId}/syslogServers")]
		Task<SyslogServersUpdateRequest> UpdateNetworkSyslogServersAsync(
			[AliasAs("networkId")]string networkId,
			[Body]SyslogServersUpdateRequest UpdateNetworkSyslogServers,
			CancellationToken cancellationToken = default
			);
	}
}
