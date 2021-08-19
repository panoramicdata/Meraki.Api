using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IVppAccounts
	{
		/// <summary>
		/// List the VPP accounts in the organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/sm/vppAccounts")]
		Task<List<SmVppAccount>> GetOrganizationSmVppAccountsAsync(
			[AliasAs("organizationId")] string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// List the VPP accounts in the organization
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="vppAccountId">The VPP account id</param>
		[Get("/organizations/{organizationId}/sm/vppAccounts/{vppAccountId}")]
		Task<SmVppAccount> GetOrganizationSmVppAccountAsync(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("vppAccountId")] string vppAccountId,
			CancellationToken cancellationToken = default);
	}
}