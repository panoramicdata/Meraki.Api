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
		/// getOrganizationSmVppAccounts
		/// </summary>
		/// <remarks>
		/// List the VPP accounts in the organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/sm/vppAccounts")]
		Task<List<SmVppAccount>> GetOrganizationSmVppAccounts(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getOrganizationSmVppAccount
		/// </summary>
		/// <remarks>
		/// List the VPP accounts in the organization
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="vppAccountId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/sm/vppAccounts/{vppAccountId}")]
		Task<SmVppAccount> GetOrganizationSmVppAccount(
			[AliasAs("organizationId")] string organizationId,
			[AliasAs("vppAccountId")] string vppAccountId,
			CancellationToken cancellationToken = default);
	}
}