using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Organizations interface
	/// </summary>
	public interface IOrganizations
	{
		/// <summary>
		/// List the organizations that the user has privileges on
		/// </summary>
		[Get("/organizations")]
		Task<List<Organization>> GetAllAsync(
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return an organization
		/// </summary>
		/// <param name="orgId"></param>
		[Get("/organizations/{organizationId}")]
		Task<Organization> GetAsync(
			[AliasAs("organizationId")] int organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the networks in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/networks")]
		Task<List<Network>> GetAllNetworksAsync(
			[AliasAs("organizationId")] int organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the devices in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/devices")]
		Task<List<Device>> GetAllDevicesAsync(
			[AliasAs("organizationId")] int organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the third party VPN peers in an organization
		/// </summary>
		[Get("/organizations/{organizationId}/thirdPartyVPNPeers")]
		Task<List<Network>> GetAllThirdPartyVpnPeersAsync(
			[AliasAs("organizationId")] int organizationId,
			CancellationToken cancellationToken = default);
	}
}
