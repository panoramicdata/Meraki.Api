using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	public interface INetworkSnmp
	{
		/// <summary>
		/// Return the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/snmpSettings")]
		Task<NetworkSnmp> GetNetworkSnmpSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the SNMP settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkSnmp"></param>
		[Put("/networks/{networkId}/snmpSettings")]
		Task<NetworkSnmp> UpdateNetworkSnmpSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkSnmp networkSnmp,
			CancellationToken cancellationToken = default
			);
	}
}
