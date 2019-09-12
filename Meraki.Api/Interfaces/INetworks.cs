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
		/// List the networks in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllAsync(
			[AliasAs("organizationId")] int organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return a network
		/// </summary>
		/// <param name="networkId">The network Id</param>
		[Get("/networks/{networkId}")]
		Task<Network> GetAsync(
			[AliasAs("networkId")] int networkId,
			CancellationToken cancellationToken = default);
	}
}
