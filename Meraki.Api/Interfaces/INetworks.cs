using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Networks interface
	/// </summary>
	public interface INetworks
	{
		/// <summary>
		/// Return a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network's SSIDs
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}/ssids")]
		Task<List<NetworkSsid>> GetAllSsidsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);
	}
}
